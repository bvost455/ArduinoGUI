using System;
using System.IO.Ports;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;
using System.Management;
using System.Xml.Linq;
using static ArduinoGUI.Form1;

namespace ArduinoGUI
{
    public class ArduinoLink
    {
        public delegate void d1(string indata);
        private string _portName;
        public Form1 _mainForm;

        public ArduinoLink(Form1 mainForm)
        {
            _mainForm = mainForm;
        }
        public string PortName
        {
            get { return _portName; }
            set { _portName = value; }
        }

        private int _baudRate;
        public int BaudRate
        {
            get { return _baudRate; }
            set { _baudRate = value; }
        }

        private int _lightReading;
        public int LightReading
        {
            get { return _lightReading; }
            set { _lightReading = value; }
        }

        private int _moistureReading;
        public int MoistureReading
        {
            get { return _moistureReading; }
            set { _moistureReading = value; }
        }

        private int _tempReading;
        public int TempReading
        {
            get { return _tempReading; }
            set { _tempReading = value; }
        }

        private SerialPort _port;

        public bool Connect()
        {
            _port = new SerialPort();
            _port.PortName = _portName;
            _port.BaudRate = _baudRate;
            _port.Parity = Parity.None;
            _port.DataBits = 8;
            _port.StopBits = StopBits.One;
            _port.ReadTimeout = 20000;
            _port.WriteTimeout = 20000;
            this._port.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this._port_DataReceived);
            this._port.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this._port_ErrorReceived);
            string loggingmessage = string.Empty;
            
            try
            {
                loggingmessage = "Opening serial port " + _port.PortName.ToString() + "...";
                _port.Open();
                _port.DiscardInBuffer();
                loggingmessage += "Succeeded";
                MessageBox.Show($"{loggingmessage}");
                TurnOnLED();
                return true;
            }
            catch (Exception ex)
            {
                loggingmessage += "Failed";
                MessageBox.Show($"{loggingmessage} {ex.Message}");
                return false;
            }
        }
        public void Disconnect()
        {
            try
            {
                TurnOffLED();
                _port.DiscardInBuffer();
                _port.DiscardOutBuffer();
                _port.DataReceived -= _port_DataReceived;
                _mainForm.tb_SoilMoisturePercent.Text = "";
                _mainForm.pb_SoilMoisture.Value = 0;
                _mainForm.tb_LDRReading.Text = "";
                _mainForm.lb_Temp.Text = "0";
                _mainForm.pb_LDR.Value = 0;
                _mainForm = null;
                _port.Close();
                Thread.Sleep(500);
                _port.Dispose();
                _port = null;

            }
            catch (Exception ex ) 
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void TurnOnLED()
        {
            try
            {
                _port.Write("1"); // Send '1' to turn on the LED
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void TurnOffLED()
        {
            try
            {
                _port.Write("0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void PumpON()
        {
            try
            {
                _port.Write("Pump On"); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void PumpOFF()
        {
            try
            {
                _port.Write("Pump Off");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void _port_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            if (e.EventType == SerialError.RXOver || e.EventType == SerialError.Overrun || e.EventType == SerialError.RXParity)
            {
                if (_port != null)
                {
                    MessageBox.Show("Arduino connection lost.");
                    Disconnect();
                }
            }
        }
        private void _port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string indata = ReadIncomingData();
            d1 writeData = new d1(WriteIncomingData);
            _mainForm.BeginInvoke(writeData, indata);
        }
        public string ReadIncomingData()
        {
            try
            {
                string data = _port.ReadLine();
                return data;
            }
            catch (TimeoutException ex)
            {
                MessageBox.Show("Timeout reading from Arduino: " + ex.Message);
                return null; // Return null in case of a timeout
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading from Arduino: " + ex.Message);
                return null; // Return null in case of other errors
            }
        }
        public void WriteIncomingData(string indata)
        {
            if (indata != null && indata.Length > 0)
            {
                char firstChar = indata[0];
                string sensordata = indata.Substring(1);
                Single volts;
                if (_port != null && _mainForm != null)
                {
                    switch (firstChar)
                    {
                        case 'S':
                            _mainForm.tb_SoilMoisturePercent.Text = sensordata;
                            _mainForm.pb_SoilMoisture.Value = Convert.ToInt16(sensordata);
                            MoistureReading = Convert.ToInt16(sensordata);
                            break;
                        case 'L':
                            volts = Convert.ToSingle(sensordata);
                            _mainForm.tb_LDRReading.Text = String.Format("{0:0.00}", volts);
                            _mainForm.pb_LDR.Value = Convert.ToInt16(sensordata);
                            LightReading = Convert.ToInt16(sensordata);
                            break;
                        case 'T':
                            string temperatureString = $"{sensordata}°";
                            _mainForm.lb_Temp.Text = temperatureString;
                            TempReading = Convert.ToInt16(sensordata);
                            break;
                    }
                }
            }
        }
        public void InsertDataCollection(ArduinoDataRepo arduinoDataRepo)
        {
            try
            {
                arduinoDataRepo.InsertSensorData(LightReading, MoistureReading, TempReading);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Insert Failed. {ex.Message}");
            }
        }
    }
}
