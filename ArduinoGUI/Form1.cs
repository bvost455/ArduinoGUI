using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoGUI
{
    public partial class Form1 : Form
    {
        internal TextBox tb_SoilMoisturePercent;
        internal TextBox tb_LDRReading;
        internal ProgressBar pb_LDR;
        private ArduinoLink arduino;
        private ArduinoDataRepo arduinoDataRepo;
        
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateBaudRates();
            //PopulateCOMPorts();
        }
        private void PopulateCOMPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            cb_COMPorts.Items.Clear();
            foreach (string port in ports)
            {
                cb_COMPorts.Items.Add(port);
            }
            if (cb_COMPorts.Items.Count > 0)
            {
                cb_COMPorts.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("No COM ports detected. Make sure device is connected.");
            }
        }

        private void PopulateBaudRates()
        {
            {
                int[] standardBaudRates = { 300, 1200, 2400, 4800, 9600, 19200, 38400, 57600, 115200 };

                foreach (int baudRate in standardBaudRates)
                {
                    cb_BaudRate.Items.Add(baudRate.ToString());
                }
                cb_BaudRate.SelectedIndex = 4; // 9600 bps (index 4 in the array)
            }
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            int selectedBaudRate = Convert.ToInt32(cb_BaudRate.SelectedItem);
            string selectedPort = cb_COMPorts.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedPort))
            {
                MessageBox.Show("Please select a valid COM port and Baud Rate before attempting to connect.");
                PopulateBaudRates();
                PopulateCOMPorts();
                return;
            }

            arduino = new ArduinoLink(this)
            {
                BaudRate = (int)selectedBaudRate,
                PortName = selectedPort
            };
            if (arduino.Connect())
            {
                btn_Disconnect.Enabled = true;
                btn_Connect.Enabled = false;
                btn_CollectData.Enabled = true;
                btn_WaterPumpOn.Enabled = true;
                btn_WaterPumpOff.Enabled = true;
            }
        }
        private void btn_Disconnect_Click(object sender, EventArgs e)
        {
            if (arduino != null)
            {
                arduino.Disconnect();
                arduino = null;
                arduinoDataRepo = null;
                btn_Disconnect.Enabled = false;
                btn_Connect.Enabled = true;
                btn_CollectData.Enabled = false;
                btn_WaterPumpOn.Enabled = false;
                btn_WaterPumpOff.Enabled = false;
            }
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            PopulateCOMPorts();
        }

        private void cb_BaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (arduino != null)
            {
                MessageBox.Show("Must Disconnect and device before changing Baud Rate.");
            }
        }

        private void cb_COMPorts_Click(object sender, EventArgs e)
        {
            PopulateCOMPorts();
        }
        private void cb_COMPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (arduino != null)
            {
                MessageBox.Show("Must Disconnect and device before changing to a different Serial Port.");
            }
        }

        private void btn_Adjust_Click(object sender, EventArgs e)
        {

        }

        private void tb_ControlPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tb_ControlPanel.SelectedTab == tb_Data)
            {
                arduinoDataRepo = new ArduinoDataRepo(this);
                arduinoDataRepo.BuildUpdateDGV();
            }
        }

        private void btn_CollectData_Click(object sender, EventArgs e)
        {
            arduino.InsertDataCollection(arduinoDataRepo);
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (arduino != null)
            {
                arduino.Disconnect();
            }
        }

        private void btn_WaterPumpOn_Click(object sender, EventArgs e)
        {
            arduino.PumpON();
        }

        private void btn_WaterPumpOff_Click(object sender, EventArgs e)
        {
            arduino.PumpOFF();
        }
    }
}