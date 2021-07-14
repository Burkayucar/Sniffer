using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ReportView : Form
    {

        
        public ReportView()
        {
            InitializeComponent();    
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PacketsDataSet.packet' table. You can move, or remove it, as needed.
            this.packetTableAdapter.Fill(this.PacketsDataSet.packet);
            this.reportViewerLog.RefreshReport();

        }


        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerEnd.MinDate = dateTimePickerStart.Value;
            dateTimePickerEnd.Value = dateTimePickerStart.Value;
        }

        // Filtering Reportview by using adapter
        private void filter_Click(object sender, EventArgs e)
        {
            try
            {

                if (UdpCheckBox.Checked && TcpCheckBox.Checked)
                {

                    this.packetTableAdapter.FillByMultiple(this.PacketsDataSet.packet, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePickerStart.Text, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePickerEnd.Text, typeof(System.DateTime))))), UdpCheckBox.Text, TcpCheckBox.Text);
                    reportViewerLog.RefreshReport();
                }
                else if (TcpCheckBox.Checked)
                {


                    this.packetTableAdapter.FillByMultiple(this.PacketsDataSet.packet, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePickerStart.Text, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePickerEnd.Text, typeof(System.DateTime))))), null, TcpCheckBox.Text);
                    reportViewerLog.RefreshReport();
                }
                else if (UdpCheckBox.Checked)
                {

                    this.packetTableAdapter.FillByMultiple(this.PacketsDataSet.packet, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePickerStart.Text, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePickerEnd.Text, typeof(System.DateTime))))), UdpCheckBox.Text, null);
                    reportViewerLog.RefreshReport();
                }
                else
                {
                    this.packetTableAdapter.FillByMultiple(this.PacketsDataSet.packet, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePickerStart.Text, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePickerEnd.Text, typeof(System.DateTime))))), UdpCheckBox.Text, TcpCheckBox.Text);
                    reportViewerLog.RefreshReport();
                }
            }
            catch (System.Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
                reportViewerLog.RefreshReport();
            }
        }

        private void clearLog_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure To Delete All Logs","Delete Logs", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            { 
                string deleteQuery = " DELETE FROM [dbo].[packet]";
                SqlConnection sql = new SqlConnection("Data Source=DESKTOP-BQSMLU9;Initial Catalog=Packets;Integrated Security=True");
                sql.Open();
                SqlCommand delete = new SqlCommand(deleteQuery, sql);
                delete.ExecuteNonQuery();
                MessageBox.Show("Logs Has Been Deleted Succesfully!");
                sql.Close();
                this.packetTableAdapter.Fill(this.PacketsDataSet.packet);
                reportViewerLog.RefreshReport();
            }
        }
    }
}
