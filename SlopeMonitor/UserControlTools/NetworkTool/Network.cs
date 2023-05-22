using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using SlopeMonitor.Common;
/// <summary>
/// These codes for Network form two threads are create and one
/// thread for network connection and load data to database; 
/// the other thread for UI interface.
/// </summary>
namespace SlopeMonitor.UserControlTools.NetworkTool
{
    public partial class Network : Form
    {
        // Define a backend thread in a custom control class
        private Thread listeningThread;
        public Network()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Create a new thread to listen the client(network)
        /// </summary>
        private void StartListeningThread()
        {
            // Create a new backend thread to run the listening method
            listeningThread = new Thread(new ThreadStart(ListenForData));
            listeningThread.IsBackground = true; // Set thread as background thread
            listeningThread.Start(); // Start Thread
        }
        /// <summary>
        /// Create a method to listen to ports and store data in the database
        /// </summary>
        private void ListenForData()
        {
            // Update prompt information on the UI: only shows when connection is successful
            UpdateTextBox("Successfully connect to database IOT from LAPTOP-28Q7CG90 and the" +
                "Initial Catalog=IOT... \n Successfully connect to COM5 at baudRate 9600... \n" +
                "Start to recieve data from Arduino IDE and load data to database...");

            // Write the code logic for listening to the port and storing it in the database here
            string portName = "COM5"; // the serial port connected to the computer
            int baudRate = 9600; // the baud rate used to transmit data
            string dbConnectionString = "Data Source=LAPTOP-28Q7CG90;Initial Catalog=IOT;Integrated Security=True";// sql server connection string

            // instantiation  of ArduinoDataReader class
            LodeArduinoDateToDatebase lodeArduinoDateToDatebase = new LodeArduinoDateToDatebase(portName, baudRate, dbConnectionString);

            // Start reading and processing data
            lodeArduinoDateToDatebase.Start();

        }
        /// <summary>
        /// Update textBox1 container note this should update on UI thread and 
        /// if your code still in other thread, it needs to transmit to UI thread
        /// </summary>
        /// <param name="message"></param>
        private void UpdateTextBox(string message)
        {
            if (this.InvokeRequired)
            {
                // If the current thread is not a UI thread, call the Invoke method to
                // perform the update operation on the UI thread
                this.Invoke(new Action<string>(UpdateTextBox), message);
            }
            else
            {
                // Update textBox container on UI thread
                textBox1.Text = message;
            }
        }
        /// <summary>
        /// Event when form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Network_Load(object sender, EventArgs e)
        {
            StartListeningThread();
        }
        /// <summary>
        /// Stop listening thread when the form is closed
        /// Please do not close this page when software runs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Network_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listeningThread != null && listeningThread.IsAlive)
            {
                listeningThread.Abort();
            }
        }
    }
}
