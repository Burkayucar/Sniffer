
namespace WindowsFormsApp1
{
    partial class ReportView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.packetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PacketsDataSet = new WindowsFormsApp1.PacketsDataSet();
            this.reportViewerLog = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.UdpCheckBox = new System.Windows.Forms.CheckBox();
            this.TcpCheckBox = new System.Windows.Forms.CheckBox();
            this.packetTableAdapter = new WindowsFormsApp1.PacketsDataSetTableAdapters.packetTableAdapter();
            this.filter = new System.Windows.Forms.Button();
            this.clearLog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.packetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PacketsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // packetBindingSource
            // 
            this.packetBindingSource.DataMember = "packet";
            this.packetBindingSource.DataSource = this.PacketsDataSet;
            // 
            // PacketsDataSet
            // 
            this.PacketsDataSet.DataSetName = "PacketsDataSet";
            this.PacketsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewerLog
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.packetBindingSource;
            this.reportViewerLog.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerLog.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.ReportLog.rdlc";
            this.reportViewerLog.Location = new System.Drawing.Point(27, 24);
            this.reportViewerLog.Name = "reportViewerLog";
            this.reportViewerLog.ServerReport.BearerToken = null;
            this.reportViewerLog.Size = new System.Drawing.Size(558, 367);
            this.reportViewerLog.TabIndex = 0;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStart.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dateTimePickerStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStart.Location = new System.Drawing.Point(603, 24);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(221, 26);
            this.dateTimePickerStart.TabIndex = 1;
            this.dateTimePickerStart.ValueChanged += new System.EventHandler(this.dateTimePickerStart_ValueChanged);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEnd.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dateTimePickerEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(853, 24);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(243, 26);
            this.dateTimePickerEnd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(830, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "-";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UdpCheckBox
            // 
            this.UdpCheckBox.AutoSize = true;
            this.UdpCheckBox.Location = new System.Drawing.Point(603, 94);
            this.UdpCheckBox.Name = "UdpCheckBox";
            this.UdpCheckBox.Size = new System.Drawing.Size(46, 17);
            this.UdpCheckBox.TabIndex = 8;
            this.UdpCheckBox.Text = "Udp";
            this.UdpCheckBox.UseVisualStyleBackColor = true;
            // 
            // TcpCheckBox
            // 
            this.TcpCheckBox.AutoSize = true;
            this.TcpCheckBox.Location = new System.Drawing.Point(603, 126);
            this.TcpCheckBox.Name = "TcpCheckBox";
            this.TcpCheckBox.Size = new System.Drawing.Size(45, 17);
            this.TcpCheckBox.TabIndex = 9;
            this.TcpCheckBox.Text = "Tcp";
            this.TcpCheckBox.UseVisualStyleBackColor = true;
            // 
            // packetTableAdapter
            // 
            this.packetTableAdapter.ClearBeforeFill = true;
            // 
            // filter
            // 
            this.filter.Location = new System.Drawing.Point(666, 94);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(95, 31);
            this.filter.TabIndex = 10;
            this.filter.Text = "Filter";
            this.filter.UseVisualStyleBackColor = true;
            this.filter.Click += new System.EventHandler(this.filter_Click);
            // 
            // clearLog
            // 
            this.clearLog.BackColor = System.Drawing.Color.DarkRed;
            this.clearLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearLog.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.clearLog.Location = new System.Drawing.Point(603, 169);
            this.clearLog.Name = "clearLog";
            this.clearLog.Size = new System.Drawing.Size(95, 36);
            this.clearLog.TabIndex = 11;
            this.clearLog.Text = "Clear Log";
            this.clearLog.UseVisualStyleBackColor = false;
            this.clearLog.Click += new System.EventHandler(this.clearLog_Click);
            // 
            // ReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 450);
            this.Controls.Add(this.clearLog);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.TcpCheckBox);
            this.Controls.Add(this.UdpCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.reportViewerLog);
            this.Name = "ReportView";
            this.Text = "Report View";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.packetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PacketsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerLog;
        private System.Windows.Forms.BindingSource packetBindingSource;
        private PacketsDataSet PacketsDataSet;
        private PacketsDataSetTableAdapters.packetTableAdapter packetTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox UdpCheckBox;
        private System.Windows.Forms.CheckBox TcpCheckBox;
        private System.Windows.Forms.Button filter;
        private System.Windows.Forms.Button clearLog;
    }
}