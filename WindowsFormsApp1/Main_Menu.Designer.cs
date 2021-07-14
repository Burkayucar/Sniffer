
namespace WindowsFormsApp1
{
    partial class Main_Menu
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
            this.selected_device = new System.Windows.Forms.TextBox();
            this.read_device = new System.Windows.Forms.Button();
            this.add_database = new System.Windows.Forms.CheckBox();
            this.stop = new System.Windows.Forms.Button();
            this.device_list = new System.Windows.Forms.Button();
            this.list_log = new System.Windows.Forms.Button();
            this.listViewDevice = new System.Windows.Forms.ListView();
            this.PacketsDataSet = new WindowsFormsApp1.PacketsDataSet();
            this.packetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.packetTableAdapter = new WindowsFormsApp1.PacketsDataSetTableAdapters.packetTableAdapter();
            this.logView = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.PacketsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // selected_device
            // 
            this.selected_device.Location = new System.Drawing.Point(39, 200);
            this.selected_device.Name = "selected_device";
            this.selected_device.ReadOnly = true;
            this.selected_device.Size = new System.Drawing.Size(1041, 20);
            this.selected_device.TabIndex = 3;
            // 
            // read_device
            // 
            this.read_device.Location = new System.Drawing.Point(39, 297);
            this.read_device.Name = "read_device";
            this.read_device.Size = new System.Drawing.Size(102, 41);
            this.read_device.TabIndex = 4;
            this.read_device.Text = "Read Device";
            this.read_device.UseVisualStyleBackColor = true;
            this.read_device.Click += new System.EventHandler(this.read_device_Click);
            // 
            // add_database
            // 
            this.add_database.AutoSize = true;
            this.add_database.Enabled = false;
            this.add_database.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_database.Location = new System.Drawing.Point(163, 297);
            this.add_database.Name = "add_database";
            this.add_database.Size = new System.Drawing.Size(115, 20);
            this.add_database.TabIndex = 5;
            this.add_database.Text = "Add Database";
            this.add_database.UseVisualStyleBackColor = true;
            this.add_database.CheckedChanged += new System.EventHandler(this.add_database_CheckedChanged);
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.Red;
            this.stop.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.stop.Location = new System.Drawing.Point(41, 355);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(102, 37);
            this.stop.TabIndex = 6;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // device_list
            // 
            this.device_list.Location = new System.Drawing.Point(1107, 22);
            this.device_list.Name = "device_list";
            this.device_list.Size = new System.Drawing.Size(82, 38);
            this.device_list.TabIndex = 7;
            this.device_list.Text = "List Devices";
            this.device_list.UseVisualStyleBackColor = true;
            this.device_list.Click += new System.EventHandler(this.device_list_Click);
            // 
            // list_log
            // 
            this.list_log.Location = new System.Drawing.Point(39, 407);
            this.list_log.Name = "list_log";
            this.list_log.Size = new System.Drawing.Size(104, 38);
            this.list_log.TabIndex = 8;
            this.list_log.Text = "List Log";
            this.list_log.UseVisualStyleBackColor = true;
            this.list_log.Click += new System.EventHandler(this.list_log_Click);
            // 
            // listViewDevice
            // 
            this.listViewDevice.HideSelection = false;
            this.listViewDevice.Location = new System.Drawing.Point(41, 22);
            this.listViewDevice.Name = "listViewDevice";
            this.listViewDevice.Size = new System.Drawing.Size(1041, 164);
            this.listViewDevice.TabIndex = 9;
            this.listViewDevice.UseCompatibleStateImageBehavior = false;
            this.listViewDevice.SelectedIndexChanged += new System.EventHandler(this.listViewDevice_SelectedIndexChanged);
            // 
            // PacketsDataSet
            // 
            this.PacketsDataSet.DataSetName = "PacketsDataSet";
            this.PacketsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // packetBindingSource
            // 
            this.packetBindingSource.DataMember = "packet";
            this.packetBindingSource.DataSource = this.PacketsDataSet;
            // 
            // packetTableAdapter
            // 
            this.packetTableAdapter.ClearBeforeFill = true;
            // 
            // logView
            // 
            this.logView.HideSelection = false;
            this.logView.Location = new System.Drawing.Point(310, 256);
            this.logView.Name = "logView";
            this.logView.Size = new System.Drawing.Size(770, 301);
            this.logView.TabIndex = 10;
            this.logView.UseCompatibleStateImageBehavior = false;
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 569);
            this.Controls.Add(this.logView);
            this.Controls.Add(this.listViewDevice);
            this.Controls.Add(this.list_log);
            this.Controls.Add(this.device_list);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.add_database);
            this.Controls.Add(this.read_device);
            this.Controls.Add(this.selected_device);
            this.Name = "Main_Menu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PacketsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource packetBindingSource;
        private PacketsDataSet PacketsDataSet;
        private PacketsDataSetTableAdapters.packetTableAdapter packetTableAdapter;
        private System.Windows.Forms.TextBox selected_device;
        private System.Windows.Forms.Button read_device;
        private System.Windows.Forms.CheckBox add_database;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button device_list;
        private System.Windows.Forms.Button list_log;
        private System.Windows.Forms.ListView listViewDevice;
        private System.Windows.Forms.ListView logView;
    }
}

