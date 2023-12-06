namespace ArduinoGUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_BaudRate = new System.Windows.Forms.ComboBox();
            this.btn_Disconnect = new System.Windows.Forms.Button();
            this.cb_COMPorts = new System.Windows.Forms.ComboBox();
            this.lb_Port = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.tb_ControlPanel = new System.Windows.Forms.TabControl();
            this.tb_Controls = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.btn_WaterPumpOff = new System.Windows.Forms.Button();
            this.btn_WaterPumpOn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_SolarTrackUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_Temp = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_LDRReading = new System.Windows.Forms.TextBox();
            this.pb_LDR = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_SoilMoisturePercent = new System.Windows.Forms.TextBox();
            this.pb_SoilMoisture = new System.Windows.Forms.ProgressBar();
            this.tb_Data = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_CollectData = new System.Windows.Forms.Button();
            this.dgv_GardenData = new System.Windows.Forms.DataGridView();
            this.tb_ControlPanel.SuspendLayout();
            this.tb_Controls.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tb_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GardenData)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(598, 12);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(122, 35);
            this.btn_Connect.TabIndex = 1;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Baud Rate:";
            // 
            // cb_BaudRate
            // 
            this.cb_BaudRate.FormattingEnabled = true;
            this.cb_BaudRate.Location = new System.Drawing.Point(117, 16);
            this.cb_BaudRate.Name = "cb_BaudRate";
            this.cb_BaudRate.Size = new System.Drawing.Size(175, 28);
            this.cb_BaudRate.TabIndex = 4;
            this.cb_BaudRate.SelectedIndexChanged += new System.EventHandler(this.cb_BaudRate_SelectedIndexChanged);
            // 
            // btn_Disconnect
            // 
            this.btn_Disconnect.Enabled = false;
            this.btn_Disconnect.Location = new System.Drawing.Point(736, 12);
            this.btn_Disconnect.Name = "btn_Disconnect";
            this.btn_Disconnect.Size = new System.Drawing.Size(122, 35);
            this.btn_Disconnect.TabIndex = 5;
            this.btn_Disconnect.Text = "Disconnect";
            this.btn_Disconnect.UseVisualStyleBackColor = true;
            this.btn_Disconnect.Click += new System.EventHandler(this.btn_Disconnect_Click);
            // 
            // cb_COMPorts
            // 
            this.cb_COMPorts.FormattingEnabled = true;
            this.cb_COMPorts.Location = new System.Drawing.Point(347, 16);
            this.cb_COMPorts.Name = "cb_COMPorts";
            this.cb_COMPorts.Size = new System.Drawing.Size(131, 28);
            this.cb_COMPorts.TabIndex = 6;
            this.cb_COMPorts.SelectedIndexChanged += new System.EventHandler(this.cb_COMPorts_SelectedIndexChanged);
            this.cb_COMPorts.Click += new System.EventHandler(this.cb_COMPorts_Click);
            // 
            // lb_Port
            // 
            this.lb_Port.AutoSize = true;
            this.lb_Port.Location = new System.Drawing.Point(303, 19);
            this.lb_Port.Name = "lb_Port";
            this.lb_Port.Size = new System.Drawing.Size(42, 20);
            this.lb_Port.TabIndex = 7;
            this.lb_Port.Text = "Port:";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(487, 15);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(82, 32);
            this.btn_Refresh.TabIndex = 8;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // tb_ControlPanel
            // 
            this.tb_ControlPanel.Controls.Add(this.tb_Controls);
            this.tb_ControlPanel.Controls.Add(this.tb_Data);
            this.tb_ControlPanel.Location = new System.Drawing.Point(5, 62);
            this.tb_ControlPanel.Name = "tb_ControlPanel";
            this.tb_ControlPanel.SelectedIndex = 0;
            this.tb_ControlPanel.Size = new System.Drawing.Size(1258, 566);
            this.tb_ControlPanel.TabIndex = 9;
            this.tb_ControlPanel.SelectedIndexChanged += new System.EventHandler(this.tb_ControlPanel_SelectedIndexChanged);
            // 
            // tb_Controls
            // 
            this.tb_Controls.BackColor = System.Drawing.Color.LightGray;
            this.tb_Controls.Controls.Add(this.label9);
            this.tb_Controls.Controls.Add(this.label6);
            this.tb_Controls.Controls.Add(this.panel5);
            this.tb_Controls.Controls.Add(this.label8);
            this.tb_Controls.Controls.Add(this.panel4);
            this.tb_Controls.Controls.Add(this.label5);
            this.tb_Controls.Controls.Add(this.label4);
            this.tb_Controls.Controls.Add(this.panel3);
            this.tb_Controls.Controls.Add(this.panel2);
            this.tb_Controls.Controls.Add(this.panel1);
            this.tb_Controls.Location = new System.Drawing.Point(4, 29);
            this.tb_Controls.Name = "tb_Controls";
            this.tb_Controls.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Controls.Size = new System.Drawing.Size(1250, 533);
            this.tb_Controls.TabIndex = 0;
            this.tb_Controls.Text = "Controls";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(474, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(247, 29);
            this.label9.TabIndex = 14;
            this.label9.Text = "Water Pump Control";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(473, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Soil Temperature";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.trackBar3);
            this.panel5.Controls.Add(this.btn_WaterPumpOff);
            this.panel5.Controls.Add(this.btn_WaterPumpOn);
            this.panel5.Location = new System.Drawing.Point(449, 37);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(365, 187);
            this.panel5.TabIndex = 15;
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(73, 117);
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(201, 69);
            this.trackBar3.TabIndex = 10;
            this.trackBar3.Value = 5;
            // 
            // btn_WaterPumpOff
            // 
            this.btn_WaterPumpOff.BackColor = System.Drawing.Color.Red;
            this.btn_WaterPumpOff.Enabled = false;
            this.btn_WaterPumpOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_WaterPumpOff.Location = new System.Drawing.Point(175, 44);
            this.btn_WaterPumpOff.Name = "btn_WaterPumpOff";
            this.btn_WaterPumpOff.Size = new System.Drawing.Size(86, 63);
            this.btn_WaterPumpOff.TabIndex = 1;
            this.btn_WaterPumpOff.Text = "OFF";
            this.btn_WaterPumpOff.UseVisualStyleBackColor = false;
            this.btn_WaterPumpOff.Click += new System.EventHandler(this.btn_WaterPumpOff_Click);
            // 
            // btn_WaterPumpOn
            // 
            this.btn_WaterPumpOn.BackColor = System.Drawing.Color.Green;
            this.btn_WaterPumpOn.Enabled = false;
            this.btn_WaterPumpOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_WaterPumpOn.Location = new System.Drawing.Point(81, 44);
            this.btn_WaterPumpOn.Name = "btn_WaterPumpOn";
            this.btn_WaterPumpOn.Size = new System.Drawing.Size(85, 63);
            this.btn_WaterPumpOn.TabIndex = 0;
            this.btn_WaterPumpOn.Text = "ON";
            this.btn_WaterPumpOn.UseVisualStyleBackColor = false;
            this.btn_WaterPumpOn.Click += new System.EventHandler(this.btn_WaterPumpOn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(55, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(313, 29);
            this.label8.TabIndex = 5;
            this.label8.Text = "Solar Tracker Parameters";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.trackBar2);
            this.panel4.Controls.Add(this.trackBar1);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.btn_SolarTrackUpdate);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(31, 257);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(392, 255);
            this.panel4.TabIndex = 13;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(44, 64);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.Size = new System.Drawing.Size(69, 161);
            this.trackBar2.TabIndex = 1;
            this.trackBar2.Value = 5;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(119, 75);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(241, 69);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Value = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Elevation";
            // 
            // btn_SolarTrackUpdate
            // 
            this.btn_SolarTrackUpdate.Location = new System.Drawing.Point(246, 150);
            this.btn_SolarTrackUpdate.Name = "btn_SolarTrackUpdate";
            this.btn_SolarTrackUpdate.Size = new System.Drawing.Size(114, 37);
            this.btn_SolarTrackUpdate.TabIndex = 2;
            this.btn_SolarTrackUpdate.Text = "Send Update";
            this.btn_SolarTrackUpdate.UseVisualStyleBackColor = true;
            this.btn_SolarTrackUpdate.Click += new System.EventHandler(this.btn_Adjust_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Azimuth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(883, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "LDR Sensor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(883, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Soil Moisture Content";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lb_Temp);
            this.panel3.Location = new System.Drawing.Point(449, 257);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(365, 255);
            this.panel3.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(216, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 73);
            this.label7.TabIndex = 1;
            this.label7.Text = "°";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Temp
            // 
            this.lb_Temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Temp.Location = new System.Drawing.Point(70, 85);
            this.lb_Temp.Margin = new System.Windows.Forms.Padding(0);
            this.lb_Temp.Name = "lb_Temp";
            this.lb_Temp.Size = new System.Drawing.Size(167, 73);
            this.lb_Temp.TabIndex = 0;
            this.lb_Temp.Text = "0";
            this.lb_Temp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tb_LDRReading);
            this.panel2.Controls.Add(this.pb_LDR);
            this.panel2.Location = new System.Drawing.Point(844, 257);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 255);
            this.panel2.TabIndex = 7;
            // 
            // tb_LDRReading
            // 
            this.tb_LDRReading.Location = new System.Drawing.Point(29, 35);
            this.tb_LDRReading.Name = "tb_LDRReading";
            this.tb_LDRReading.ReadOnly = true;
            this.tb_LDRReading.Size = new System.Drawing.Size(100, 26);
            this.tb_LDRReading.TabIndex = 0;
            // 
            // pb_LDR
            // 
            this.pb_LDR.Location = new System.Drawing.Point(29, 67);
            this.pb_LDR.Maximum = 500;
            this.pb_LDR.Name = "pb_LDR";
            this.pb_LDR.Size = new System.Drawing.Size(235, 40);
            this.pb_LDR.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tb_SoilMoisturePercent);
            this.panel1.Controls.Add(this.pb_SoilMoisture);
            this.panel1.Location = new System.Drawing.Point(844, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 187);
            this.panel1.TabIndex = 6;
            // 
            // tb_SoilMoisturePercent
            // 
            this.tb_SoilMoisturePercent.Location = new System.Drawing.Point(29, 31);
            this.tb_SoilMoisturePercent.Name = "tb_SoilMoisturePercent";
            this.tb_SoilMoisturePercent.ReadOnly = true;
            this.tb_SoilMoisturePercent.Size = new System.Drawing.Size(100, 26);
            this.tb_SoilMoisturePercent.TabIndex = 5;
            // 
            // pb_SoilMoisture
            // 
            this.pb_SoilMoisture.Location = new System.Drawing.Point(29, 63);
            this.pb_SoilMoisture.Maximum = 500;
            this.pb_SoilMoisture.Name = "pb_SoilMoisture";
            this.pb_SoilMoisture.Size = new System.Drawing.Size(235, 32);
            this.pb_SoilMoisture.TabIndex = 7;
            // 
            // tb_Data
            // 
            this.tb_Data.Controls.Add(this.label10);
            this.tb_Data.Controls.Add(this.btn_CollectData);
            this.tb_Data.Controls.Add(this.dgv_GardenData);
            this.tb_Data.Location = new System.Drawing.Point(4, 29);
            this.tb_Data.Name = "tb_Data";
            this.tb_Data.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Data.Size = new System.Drawing.Size(1250, 533);
            this.tb_Data.TabIndex = 1;
            this.tb_Data.Text = "Data Collection";
            this.tb_Data.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(386, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(191, 29);
            this.label10.TabIndex = 2;
            this.label10.Text = "Data Collection";
            // 
            // btn_CollectData
            // 
            this.btn_CollectData.Enabled = false;
            this.btn_CollectData.Location = new System.Drawing.Point(23, 48);
            this.btn_CollectData.Name = "btn_CollectData";
            this.btn_CollectData.Size = new System.Drawing.Size(164, 35);
            this.btn_CollectData.TabIndex = 1;
            this.btn_CollectData.Text = "Collect Data";
            this.btn_CollectData.UseVisualStyleBackColor = true;
            this.btn_CollectData.Click += new System.EventHandler(this.btn_CollectData_Click);
            // 
            // dgv_GardenData
            // 
            this.dgv_GardenData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_GardenData.Location = new System.Drawing.Point(23, 105);
            this.dgv_GardenData.Name = "dgv_GardenData";
            this.dgv_GardenData.ReadOnly = true;
            this.dgv_GardenData.RowHeadersWidth = 62;
            this.dgv_GardenData.RowTemplate.Height = 28;
            this.dgv_GardenData.Size = new System.Drawing.Size(974, 351);
            this.dgv_GardenData.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 640);
            this.Controls.Add(this.tb_ControlPanel);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.lb_Port);
            this.Controls.Add(this.cb_COMPorts);
            this.Controls.Add(this.btn_Disconnect);
            this.Controls.Add(this.cb_BaudRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Connect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.tb_ControlPanel.ResumeLayout(false);
            this.tb_Controls.ResumeLayout(false);
            this.tb_Controls.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tb_Data.ResumeLayout(false);
            this.tb_Data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GardenData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_BaudRate;
        private System.Windows.Forms.ComboBox cb_COMPorts;
        private System.Windows.Forms.Label lb_Port;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.TabPage tb_Controls;
        private System.Windows.Forms.TabPage tb_Data;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btn_SolarTrackUpdate;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.ProgressBar pb_SoilMoisture;
        public System.Windows.Forms.Button btn_Connect;
        public System.Windows.Forms.Button btn_Disconnect;
        public System.Windows.Forms.Button btn_CollectData;
        internal System.Windows.Forms.DataGridView dgv_GardenData;
        internal System.Windows.Forms.TabControl tb_ControlPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Label lb_Temp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Button btn_WaterPumpOff;
        private System.Windows.Forms.Button btn_WaterPumpOn;
    }
}

