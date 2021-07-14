using PcapDotNet.Core;
using PcapDotNet.Packets;
using PcapDotNet.Packets.IpV4;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Sniffer
    {

        public static LivePacketDevice selectedDevice; // Required to show available devices
        public static Queue<Packet> queue = new Queue<Packet>(); // Required to not any lose packet
        public static Queue<Packet> queueList = new Queue<Packet>(); // Required to list recieved packets
        public static bool control = true;
        public static SqlConnection database_connection = new SqlConnection("Data Source=DESKTOP-BQSMLU9;Initial Catalog=Packets;Integrated Security=True");

        public static void Filter(int index)    // The Function that open packets and add packets to queue
        {

            database_connection.Open();

            control = true;

            IList<LivePacketDevice> allDevices = LivePacketDevice.AllLocalMachine;
            LivePacketDevice device = allDevices[index];
            selectedDevice = device;

            // Open the device
            using (PacketCommunicator communicator =
                selectedDevice.Open(65536,                                  // portion of the packet to capture
                                                                            // 65536 guarantees that the whole packet will be captured on all the link layers
                                    PacketDeviceOpenAttributes.Promiscuous, // promiscuous mode
                                    1000))                                  // read timeout
            {
                Packet packet;

                do
                {
                    PacketCommunicatorReceiveResult result = communicator.ReceivePacket(out packet);
                    switch (result)
                    {
                        case PacketCommunicatorReceiveResult.Timeout:

                            continue;
                        case PacketCommunicatorReceiveResult.Ok:

                            if (packet.Ethernet.IpV4.Protocol == IpV4Protocol.Udp || packet.Ethernet.IpV4.Protocol == IpV4Protocol.Tcp)
                            {

                                queue.Enqueue(packet);
                                queueList.Enqueue(packet);

                            }
                            break;
                        default:
                            throw new InvalidOperationException("The result " + result + " shoudl never be reached here");
                    }

                } while (control == true);
                communicator.Break();
            }
        }


        public static void Stop()
        {

            control = false;
            database_connection.Close();

        }


        public static void Add_Database() // Function that uses queue to get packets and add them to db
        {
            Packet _packet;

            string add_query = "Insert into packet (Time,Packet_type,Destination_port , Source_Ip,  Destination_Ip) values(@time,@packet,@destinationPort,@sourceIp,@destinationIp)";
            while (queue.Count > 0)
            {
                if (queue.Count > 0)
                {
                    lock (queue)
                    {
                        _packet = queue.Dequeue();

                        SqlCommand add_packet = new SqlCommand(add_query, database_connection);
                        add_packet.Parameters.AddWithValue("@time", _packet.Timestamp.ToString("yyyy-MM-dd hh:mm:ss.fff"));
                        add_packet.Parameters.AddWithValue("@packet", _packet.Ethernet.IpV4.Protocol.ToString());
                        add_packet.Parameters.AddWithValue("@sourceIp", _packet.Ethernet.IpV4.Source.ToString());
                        add_packet.Parameters.AddWithValue("@destinationIp", _packet.Ethernet.IpV4.Destination.ToString());

                        if (_packet.Ethernet.IpV4.Protocol == IpV4Protocol.Udp)
                        {
                            add_packet.Parameters.AddWithValue("@destinationPort", _packet.Ethernet.IpV4.Udp.DestinationPort.ToString());
                        }

                        else if (_packet.Ethernet.IpV4.Protocol == IpV4Protocol.Tcp)
                        {
                            add_packet.Parameters.AddWithValue("@destinationPort", _packet.Ethernet.IpV4.Tcp.DestinationPort.ToString());
                        }


                        add_packet.ExecuteNonQuery();
                    }
                }
            }

        }

        internal class PacketsDataSet
        {
            internal object packet;

            public SchemaSerializationMode SchemaSerializationMode { get; internal set; }
            public string DataSetName { get; internal set; }
        }

        internal class PacketsDataSetTableAdapters
        {
            internal class packetTableAdapter
            {
                public bool ClearBeforeFill { get; internal set; }

                internal void Fill(object packet)
                {
                    throw new NotImplementedException();
                }
            }
        }

    }
}
