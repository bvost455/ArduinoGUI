using System;
using System.IO.Ports;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;
using ArduinoGUI;

namespace ArduinoGUI
{
    public class SensorDataModel
    {
        public int ID { get; set; }
        public DateTime Date_of_Reading { get; set; }
        public int Light_Reading { get; set; }
        public int Temperature { get; set; }
        public int Soil_Moisture_Content { get; set; }
    }
}
