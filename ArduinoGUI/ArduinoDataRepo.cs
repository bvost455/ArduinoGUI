using System;
using System.Linq;
using System.Data.SqlClient;
using System.Windows.Forms;
using Dapper;

namespace ArduinoGUI
{
    public class ArduinoDataRepo
    {
        private string _connectionString = "Data Source = DESKTOP-P7RDJVL\\SQLEXPRESS;Initial Catalog=Arduino;Integrated Security=True";
        public Form1 _mainForm;

        public ArduinoDataRepo(Form1 mainForm)
        {
            _mainForm = mainForm;
        }
        public void BuildUpdateDGV()
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            var dataSet = connection.Query<SensorDataModel>("SELECT * FROM ArduinoSensorData ORDER BY ID DESC").ToList();
            _mainForm.dgv_GardenData.DataSource = dataSet;
            _mainForm.dgv_GardenData.Columns["ID"].Width = 50;  // Set your desired width
            _mainForm.dgv_GardenData.Columns["Date_of_Reading"].Width = 150;  // Set your desired width
            _mainForm.dgv_GardenData.Columns["Light_Reading"].Width = 100;  // Set your desired width
            _mainForm.dgv_GardenData.Columns["Temperature"].Width = 100;  // Set your desired width
            _mainForm.dgv_GardenData.Columns["Soil_Moisture_Content"].Width = 150;  // Set your desired width
        }

        public bool InsertSensorData(int LDRreading, int SoilMoistureReading, int TempReading)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO ArduinoSensorData " +
                                   "(Date_Of_Reading, Light_Reading, Temperature, Soil_Moisture_Content)" +
                                  $"VALUES (SYSDATETIME(),'{LDRreading}','{TempReading}','{SoilMoistureReading}')";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int rowcount = command.ExecuteNonQuery();
                        if (rowcount > 0)
                        {
                            BuildUpdateDGV();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string loggingmessage = "Failed to insert data";
                MessageBox.Show($"{loggingmessage} {ex.Message}");
                return false;
            }
        }
    }
}
