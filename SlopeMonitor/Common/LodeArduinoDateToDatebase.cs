using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// These codes provide serials communication between Arduino and PC
/// These codes just an example and only suitable for certain hardware
/// </summary>
namespace SlopeMonitor.Common
{
    public class LodeArduinoDateToDatebase
    {
        private SerialPort serialPort;
        private SqlConnection dbConnection;

        public LodeArduinoDateToDatebase(string portName, int baudRate, string dbConnectionString)
        {
            // Init serials connection and database connection
            serialPort = new SerialPort(portName, baudRate);
            dbConnection = new SqlConnection(dbConnectionString);
        }

        public void Start()
        {
            // open serial port and connect to database
            serialPort.Open();
            dbConnection.Open();

            try
            {
                while (true)
                {
                    //  wait for data from buffer
                    while (serialPort.BytesToRead == 0) ;

                    // read one line from buffer
                    string line = serialPort.ReadLine();

                    // process the data
                    if (line.StartsWith("Received packet time"))
                    {
                        //Received packet time 
                        //string[] timeValues = line.Split(' ');
                        //int r_time = int.Parse(timeValues[3]);
                        // Acc[g] [m/s^2]
                        string[] accValues = serialPort.ReadLine().Split(':')[1].Split(' ');
                        float accX = float.Parse(accValues[1]);
                        float accY = float.Parse(accValues[2]);
                        float accZ = float.Parse(accValues[3]);

                        // Gyro[deg/s]
                        string[] gyroValues = serialPort.ReadLine().Split(':')[1].Split(' ');
                        float gyroX = float.Parse(gyroValues[1]);
                        float gyroY = float.Parse(gyroValues[2]);
                        float gyroZ = float.Parse(gyroValues[3]);

                        // Angle[deg]
                        string[] angleValues = serialPort.ReadLine().Split(':')[1].Split(' ');
                        float angleX = float.Parse(angleValues[1]);
                        float angleY = float.Parse(angleValues[2]);
                        float angleZ = float.Parse(angleValues[3]);

                        // Mag[T]
                        string[] magValues = serialPort.ReadLine().Split(':')[1].Split(' ');
                        float magX = float.Parse(magValues[1]);
                        float magY = float.Parse(magValues[2]);
                        float magZ = float.Parse(magValues[3]);

                        // Temperature[K]
                        float minValue = -30.0f;
                        float maxValue = 40.0f;
                        float range = maxValue - minValue;
                        float randomValue1 = (float)(minValue + range * new Random().NextDouble()); // [minValue, maxValue) random value 
                        float temperature = randomValue1;

                        // Humidity
                        float minValue2 = 0.0f;
                        float maxValue2 = 100.0f;
                        float range2 = maxValue - minValue;
                        float randomValue2 = (float)(minValue2 + range2 * new Random().NextDouble()); // [minValue, maxValue) random value
                        float humidity = randomValue2;

                        // write data to datbase
                        using (SqlCommand cmd = new SqlCommand("INSERT INTO Sensor (AccX, AccY, AccZ, GyroX, GyroY, GyroZ, AngleX, AngleY, AngleZ, MagX, MagY, MagZ, Temperature, Humidity) VALUES (@AccX, @AccY, @AccZ, @GyroX, @GyroY, @GyroZ, @AngleX, @AngleY, @AngleZ, @MagX, @MagY, @MagZ, @Temperature, @Humidity)", dbConnection))
                        {
                            //cmd.Parameters.AddWithValue("@R_time", r_time);
                            cmd.Parameters.AddWithValue("@AccX", accX);
                            cmd.Parameters.AddWithValue("@AccY", accY);
                            cmd.Parameters.AddWithValue("@AccZ", accZ);
                            cmd.Parameters.AddWithValue("@GyroX", gyroX);
                            cmd.Parameters.AddWithValue("@GyroY", gyroY);
                            cmd.Parameters.AddWithValue("@GyroZ", gyroZ);
                            cmd.Parameters.AddWithValue("@AngleX", angleX);
                            cmd.Parameters.AddWithValue("@AngleY", angleY);
                            cmd.Parameters.AddWithValue("@AngleZ", angleZ);
                            cmd.Parameters.AddWithValue("@MagX", magX);
                            cmd.Parameters.AddWithValue("@MagY", magY);
                            cmd.Parameters.AddWithValue("@MagZ", magZ);
                            cmd.Parameters.AddWithValue("@Temperature", temperature);
                            cmd.Parameters.AddWithValue("@Humidity", humidity);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            // close serial port and database connection
            serialPort.Close();
            dbConnection.Close();
        }
    }
}

