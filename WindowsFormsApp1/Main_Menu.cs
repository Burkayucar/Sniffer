using PcapDotNet.Core;
using PcapDotNet.Packets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main_Menu : Form
    {

        IList<LivePacketDevice> allDevices = LivePacketDevice.AllLocalMachine;
        Sniffer sniffer = new Sniffer();
        Thread sniffing, add, log;

        
        public int deviceIndex = 0;

        public Main_Menu()
        {
            InitializeComponent();

            // Listview configuration
            listViewDevice.View = View.Details;
            listViewDevice.FullRowSelect = true;
            listViewDevice.Columns.Add("Index", 100);
            listViewDevice.Columns.Add("Interface Name", 900);

            logView.Columns.Add("Time",200);
            logView.Columns.Add("Protocol",100);
            logView.Columns.Add("Destination Port",100);
            logView.Columns.Add("Source Ip",150);
            logView.Columns.Add("Destination Ip", 200);
            logView.View = View.Details;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void read_device_Click(object sender, EventArgs e)
        {
            sniffing = new Thread(() => Sniffer.Filter(deviceIndex));
            log = new Thread(LogList);
            add_database.AutoCheck = true;
            sniffing.Start();
            add_database.Enabled = true;
            log.Start();
            Thread.Sleep(1000);
        }

        private void add_database_CheckedChanged(object sender, EventArgs e)
        {
            if (add_database.Checked)
            {
                add = new Thread(Sniffer.Add_Database);
                add.Start();

            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            Sniffer.Stop();
            add_database.Checked = false;
        }

        private void device_list_Click(object sender, EventArgs e)
        {
            listViewDevice.Items.Clear();
            List_device();
        }

        private void list_log_Click(object sender, EventArgs e)
        {
            ReportView form2 = new ReportView();
            form2.ShowDialog();
        }

        // Select Device
        private void listViewDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_device.Text = this.listViewDevice.Items[listViewDevice.FocusedItem.Index].SubItems[0].Text + "  -  " + this.listViewDevice.Items[listViewDevice.FocusedItem.Index].SubItems[1].Text;
            deviceIndex = listViewDevice.FocusedItem.Index;
        }

        // Listing available devices
        private void List_device()
        {
            for (int i = 0; i != allDevices.Count; i++)
            {
                LivePacketDevice device = allDevices[i];
                string index = (i + 1).ToString();
                string device_name = device.Name + "    " + device.Description;
                string[] _device = { index, device_name };
                listViewDevice.Items.Add(new ListViewItem(_device));

            }

        }

        // List Log
        public void LogList()
        {
            Packet packet;
            string[] row;
            while (Sniffer.control)
            {
                if (Sniffer.queueList.Count > 0) { 
                lock (Sniffer.queueList) { 
                    packet = Sniffer.queueList.Dequeue();
                    
                    if(packet.Ethernet.IpV4.Protocol.ToString()=="Udp")
                    { 
                        row = new string[5] { packet.Timestamp.ToString("yyyy-MM-dd hh:mm:ss.fff").ToString(), packet.Ethernet.IpV4.Protocol.ToString(), packet.Ethernet.IpV4.Udp.DestinationPort.ToString(),packet.Ethernet.IpV4.Source.ToString(), packet.Ethernet.IpV4.Destination.ToString() };
                    }
                    else 
                    { 
                        row = new string[5] { packet.Timestamp.ToString("yyyy-MM-dd hh:mm:ss.fff").ToString(), packet.Ethernet.IpV4.Protocol.ToString(), packet.Ethernet.IpV4.Tcp.DestinationPort.ToString(), packet.Ethernet.IpV4.Source.ToString(), packet.Ethernet.IpV4.Destination.ToString() };
                    }
                        var logViewItem = new ListViewItem(row);
                        logView.Items.Add(logViewItem);
                        logView.Refresh();
                        Thread.Sleep(100);
                    
                }
                }
            }

        }

    }
}
