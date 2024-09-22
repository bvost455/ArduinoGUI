Project Overview
ArduinoLink is a C# application designed to interface with garden sensors via an Arduino UNO. The application features a GUI that displays real-time sensor data, including soil moisture, light (LDR), and temperature readings.

Features
Real-time Sensor Monitoring: Displays soil moisture, light intensity, and temperature data from garden sensors connected to an Arduino.
Pump Control: Turn the water pump on or off through the GUI.
LED Control: Toggle an LED connected to the Arduino on or off.
Data Logging: Stores sensor readings in a data repository for historical analysis.
Error Handling: Alerts the user to potential connection issues and handles timeouts effectively.

Requirements
Hardware:
Arduino with connected sensors: soil moisture, light (LDR), and temperature.
Actuators: LED and water pump.
Software:
Arduino IDE (to load appropriate sketch onto the Arduino).
.NET Framework (supports Windows Forms for GUI).
Visual Studio (for building and running the C# application).
How It Works
Serial Communication: The application communicates with the Arduino through a serial port, sending commands and receiving sensor data.
Data Processing: Sensor data is captured and processed, updating the graphical interface.
User Interaction: Through buttons and text fields, users can control the pump and LED, as well as view sensor values.
Data Storage: The sensor data can be inserted into a repository for later analysis.

Installation & Setup
Clone or download the project from the repository.
Open the solution file (.sln) in Visual Studio.
Adjust the portName and baudRate in the ArduinoLink class to match your Arduino setup.
Build and run the application in Visual Studio.

Usage
Connect the application to the Arduino by selecting the correct COM port and baud rate in the GUI.
View live sensor data updates for soil moisture, light, and temperature.
Use the Pump On/Off button to control water irrigation.

Disconnect the application safely when finished to avoid port issues.

Code Overview
ArduinoLink: Handles serial communication with the Arduino, including reading sensor data and sending commands to the pump and LED.
Connect(): Establishes the serial connection with the Arduino.
Disconnect(): Safely closes the serial connection.
ReadIncomingData(): Reads and processes data received from the Arduino.
WriteIncomingData(): Updates the GUI with sensor data.
InsertDataCollection(): Stores sensor data into a repository for future reference.

Error Handling
The application catches connection and timeout errors to ensure smooth operation.
Alerts are shown via message boxes when issues occur with reading from the Arduino or sending commands.

Future Improvements
Add support for additional sensors (e.g., humidity, pH).
Enhance data visualization with graphs showing sensor trends over time.
Add cloud integration to remotely monitor garden conditions.
Add bluetooth capabilities
