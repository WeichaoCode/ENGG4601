using SlopeMonitor.Common;
using SlopeMonitor.UserControlTools.VisulizationTool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SlopeMonitor.UserControlTools
{
    public partial class Visulization : UserControl
    {
        public Visulization()
        {
            InitializeComponent();

        }

        [DllImport("user32")]
        private static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, IntPtr lParam);
        private const int WM_SETREDRAW = 0xB;
        // set default chart value using mutliple threads
        /**
         * Handles the click event of button2.
         * @param sender The object that raised the event.
         * @param e An EventArgs object that contains the event data.
         * This method is triggered when button2 is clicked. It performs the following actions:
         * Calls the UpdateChart method multiple times with different parameters to update the 
         * specified charts with new data.
         * Each UpdateChart call corresponds to a specific chart and series, and sets the chart 
         * type, data column, chart area, color, data length,
         * series name, x-axis label, y-axis label, and series number.
         */
        private void button2_Click(object sender, EventArgs e)
        {
            UpdateChart(chart1, 3, "line", "ChartArea1", Color.Blue, 100, "Accz", "time(/10s)", "Acc(x,y,z)", 0);
            UpdateChart(chart1, 2, "line", "ChartArea1", Color.Green, 100, "Accy", "time(/10s)", "Acc(x,y,z)", 1);
            UpdateChart(chart1, 1, "line", "ChartArea1", Color.Red, 100, "Accx", "time(/10s)", "Acc(x,y,z)", 2);
            UpdateChart(chart2, 4, "line", "ChartArea1", Color.Blue, 100, "Gyrox", "time(/10s)", "Gyro(x,y,z)", 0);
            UpdateChart(chart2, 5, "line", "ChartArea1", Color.Green, 100, "Gyroy", "time(/10s)", "Gyro(x,y,z)", 1);
            UpdateChart(chart2, 6, "line", "ChartArea1", Color.Red, 100, "Gyroz", "time(/10s)", "Gyro(x,y,z)", 2);
            UpdateChart(chart4, 7, "line", "ChartArea1", Color.Blue, 100, "Anglex", "time(/10s)", "Angle(x,y,z)", 0);
            UpdateChart(chart4, 8, "line", "ChartArea1", Color.Green, 100, "Angley", "time(/10s)", "Angle(x,y,z)", 1);
            UpdateChart(chart4, 9, "line", "ChartArea1", Color.Red, 100, "Anglez", "time(/10s)", "Angle(x,y,z)", 2);
            UpdateChart(chart3, 13, "line", "ChartArea1", Color.Green, 100, "Temperature", "time(/10s)", "Temperature", 0);
            UpdateChart(chart3, 14, "line", "ChartArea1", Color.Blue, 100, "Humidity", "time(/10s)", "Humidity", 1);

        }
        /**
         * Handles the click event of the newChartToolStripMenuItem.
         * @param sender The object that raised the event.
         * @param e An EventArgs object that contains the event data.
         * This method is triggered when the newChartToolStripMenuItem is clicked. 
         * It performs the following actions:
         * Creates a new instance of the NewChartForm class.
         * Subscribes to the ChartTypeSelected event of the newChartForm by adding 
         * the UpdateChartType method as a handler.
         * Displays the newChartForm by calling the Show() method.
         * Note: The NewChartForm class is assumed to be defined and accessible 
         * within the scope of this method. The UpdateChartType method is also assumed 
         * to be defined and accessible.
         */
        private void newChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewChartForm newChartForm = new NewChartForm();
            newChartForm.ChartTypeSelected += UpdateChartType;
            newChartForm.Show();
        }
        /**
         * Updates the specified chart with the provided settings and data.
         * @param chartType The string representing the desired chart type.
         * @param SeriesNum The string representing the series number.
         * @param ChartSeriesName The name of the chart series.
         * @param xLabel The label for the X-axis.
         * @param yLabel The label for the Y-axis.
         * @param color The string representing the desired color.
         * @param chartNum The string representing the chart number.
         * @param Xvalue The string representing the X-value.
         * This method updates the specified chart with the provided settings 
         * and data. It performs the following actions:
         * Maps the chartNum parameter to the corresponding Chart control.
         * Maps the color parameter to the corresponding Color value.
         * Maps the SeriesNum parameter to the corresponding series number.
         * Maps the Xvalue parameter to the corresponding data column.
         * Calls the UpdateChart method with the mapped values to update the chart.
         * Note: The UpdateChart method and the Chart controls (chart1, chart2, chart3, 
         * chart4) are assumed to be defined and accessible within the scope of this method.
         */
        private void UpdateChartType(string chartType, string SeriesNum, string ChartSeriesName, string xLabel, string yLabel,
            string color, string chartNum, string Xvalue)
        {
            Chart chart;
            switch (chartNum)
            {
                case "chart1":
                    chart = chart1;
                    break;
                case "chart2":
                    chart = chart2;
                    break;
                case "chart3":
                    chart = chart3;
                    break;
                case "chart4":
                    chart = chart4;
                    break;
                default:
                    chart = chart1;
                    break;
            }
            Color userColor;
            switch (color)
            {
                case "blue":
                    userColor = Color.Blue;
                    break;
                case "red":
                    userColor = Color.Red;
                    break;
                case "green":
                    userColor = Color.Green;
                    break;
                case "yellow":
                    userColor = Color.Yellow;
                    break;
                default:
                    userColor = Color.Blue;
                    break;
            }
            int NumSeries;
            switch (SeriesNum)
            {
                case "series1":
                    NumSeries = 0;
                    break;
                case "series2":
                    NumSeries = 1;
                    break;
                case "series3":
                    NumSeries = 2;
                    break;
                default:
                    NumSeries = 0;
                    break;
            }
            int dataColumn;
            switch(Xvalue)
            {
                case "accX":
                    dataColumn = 1;
                    break;
                case "accY":
                    dataColumn = 2;
                    break;
                case "accZ":
                    dataColumn = 3;
                    break;
                case "gyroX":
                    dataColumn = 4;
                    break;
                case "gyroY":
                    dataColumn = 5;
                    break;
                case "gyroZ":
                    dataColumn = 6;
                    break;
                case "angleX":
                    dataColumn = 7;
                    break;
                case "angleY":
                    dataColumn = 8;
                    break;
                case "angleZ":
                    dataColumn = 9;
                    break;
                case "magX":
                    dataColumn = 10;
                    break;
                case "magY":
                    dataColumn = 11;
                    break;
                case "magZ":
                    dataColumn = 12;
                    break;
                case "temperature":
                    dataColumn = 13;
                    break;
                case "humidity":
                    dataColumn = 14;
                    break;
                default: dataColumn = 1;
                    break;
            }
            UpdateChart(chart, dataColumn, chartType, "ChartArea1", userColor, 100, ChartSeriesName, xLabel, yLabel, NumSeries);
        }
        /**
         * Handles the click event of the reviseChartToolStripMenuItem.
         * @param sender The object that raised the event.
         * @param e An EventArgs object that contains the event data.
         * This method is triggered when the reviseChartToolStripMenuItem is clicked. 
         * It performs the following actions:
         * Creates a new instance of the ReviseChartForm class.
         * Displays the reviseChartForm by calling the Show() method.
         * Note: The ReviseChartForm class is assumed to be defined and accessible within 
         * the scope of this method.
         */
        private void reviseChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReviseChartForm reviseChartForm = new ReviseChartForm();
            reviseChartForm.Show();
        }
        /**
         * Handles the click event of the chartProfileToolStripMenuItem.
         * @param sender The object that raised the event.
         * @param e An EventArgs object that contains the event data.
         * This method is triggered when the chartProfileToolStripMenuItem is clicked. 
         * It performs the following actions:
         * Creates a new instance of the ChartProfileForm class.
         *Displays the chartProfileForm by calling the Show() method.
         *Note: The ChartProfileForm class is assumed to be defined and accessible 
         *within the scope of this method.
         */
        private void deleteChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteChartForm deleteChartForm = new DeleteChartForm();
            deleteChartForm.Show();
        }
        /**
         * Handles the click event of the chartProfileToolStripMenuItem.
         * @param sender The object that raised the event.
         * @param e An EventArgs object that contains the event data.
         * This method is triggered when the chartProfileToolStripMenuItem is clicked. 
         * It performs the following actions:
         * Creates a new instance of the ChartProfileForm class.
         * Displays the chartProfileForm by calling the Show() method.
         * Note: The ChartProfileForm class is assumed to be defined and accessible within 
         * the scope of this method.
         */
        private void chartProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChartProfileForm chartProfileForm = new ChartProfileForm();
            chartProfileForm.Show();
        }
        /**
         * Handles the click event of button1.
         * @param sender The object that raised the event.
         * @param e An EventArgs object that contains the event data.
         * This method is triggered when button1 is clicked. It displays an 
         * error message box with a specific error message and icon.
         */
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("An error has occurred, please contact the administrator!", 
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /**
         * Updates the provided Chart control with new data and settings.
         * @param chart The Chart control to be updated.
         * @param dataCol The column index of the data to be plotted.
         * @param chartType The string representing the desired chart type.
         * @param chartArea The name of the chart area to be used.
         * @param color The color of the chart series.
         * @param dataLength The maximum value for the X-axis.
         * @param ChartSeriesName The name of the chart series.
         * @param xLabel The label for the X-axis.
         * @param yLabel The label for the Y-axis.
         * @param SeriesNum The index of the series to be updated.
         * This method updates the provided Chart control with new data and settings.
         * It performs the following actions:
         * Clears all data points from the specified series.
         * Sets the chart type for the specified series based on the provided chartType string 
         * using the GetChartType method.
         * Sets the minimum and maximum values for the X-axis of the chart.
         * Sets the line color for the specified series.
         * Sets the name for the specified series.
         * Sets the X-axis and Y-axis labels for the chart area.
         * Retrieves data from a SQL database using the Dao class.
         * Adds data points to the specified series using the retrieved data.
         * Note: The Dao class is assumed to be defined and accessible within the scope of this method.
         */
        public void UpdateChart(Chart chart, int dataCol, string chartType, string chartArea, Color color, 
            int dataLength, string ChartSeriesName, string xLabel, string yLabel, int SeriesNum)
        {
            chart.Series[SeriesNum].Points.Clear();
            // set chart type
            chart.Series[SeriesNum].ChartType = GetChartType(chartType);

            // set minimum and maximum value of chart
            chart.ChartAreas[0].AxisX.Minimum = 0;
            chart.ChartAreas[0].AxisX.Maximum = dataLength;

            // set line color of chart
            chart.Series[SeriesNum].Color = color;
            // set name of Series
            chart.Series[SeriesNum].Name = ChartSeriesName;
            // add x and y axis labels
            chart.ChartAreas[0].AxisX.Title = xLabel;
            chart.ChartAreas[0].AxisY.Title = yLabel;

            // add data
            // Init Dao 
            Dao dao = new Dao();
            // select top 100 lines of data in data table
            string sql = "select TOP 100 * from Sensor ORDER BY ID DESC";
            // Read from SQL database
            IDataReader dc = dao.read(sql);
            int counter = 1;
            //Series series = new Series();
            while (dc.Read())
            {
                float value = float.Parse(dc[dataCol].ToString());
                chart.Series[SeriesNum].Points.AddXY(counter++, value);
            }
            dc.Close();
            dao.DaoClose();
        }
        /**
         * Returns the corresponding SeriesChartType based on the provided chartType string.
         * @param chartType The string representing the desired chart type.
         * @return The corresponding SeriesChartType value.
         * This method takes a string parameter called chartType and uses a switch statement to determine 
         * the corresponding SeriesChartType value based on the input. The valid chart types are "line", 
         * "column", "point", "spline", and "bar". If the provided chart type is not recognized, it defaults
         * to SeriesChartType.Line.
         * Example usage:
         * string type = "column";
         * SeriesChartType chartType = GetChartType(type);
         * // chartType now holds the value SeriesChartType.Column
         * Note: The SeriesChartType enum is a part of the System.Windows.Forms.DataVisualization.Charting 
         * namespace.
         * EOF: This is auto generate by chatgpt
         */
        private SeriesChartType GetChartType(string chartType)
        {
            // Returns the corresponding chart type based on a string
            switch (chartType)
            {
                case "line":
                    return SeriesChartType.Line;
                case "column":
                    return SeriesChartType.Column;
                case "point":
                    return SeriesChartType.Point;
                case "spline":
                    return SeriesChartType.Spline;
                case "bar":
                    return SeriesChartType.Bar;
                default:
                    return SeriesChartType.Line;
            }
        }
        /**
         * Handles the click event of button3.
         * @param sender The object that raised the event.
         * @param e An EventArgs object that contains the event data.
         * This method is triggered when button3 is clicked. It performs the following actions:
         * Refreshes chart1, chart2, chart3, and chart4. This updates the display of the charts.
         * Creates an instance of the DataGridViewSetTool class.
         * Retrieves a DataGridView object using the GetDataGridView method from the DataGridViewSetTool class.
         * Refreshes the DataGridView, updating its display.
         * Note: The chart objects and the DataGridViewSetTool class are assumed to be defined and accessible 
         * within the scope of this method.
         */
        private void button3_Click(object sender, EventArgs e)
        {
            chart1.Refresh();
            chart2.Refresh();
            chart3.Refresh();
            chart4.Refresh();
            DataGridViewSetTool dataGridViewSetTool = new DataGridViewSetTool();
            DataGridView dataGridView1 = dataGridViewSetTool.GetDataGridView();

            dataGridView1.Refresh();
        }
        /**
         * Handles the click event of the dataGridViewToolStripMenuItem.
         * @param sender The object that raised the event.
         * @param e An EventArgs object that contains the event data.
         * This method is triggered when the dataGridViewToolStripMenuItem is clicked. It performs the following actions:
         * Creates a new instance of the DataGridViewSetTool class.
         * Adds the DataGridViewSetTool control to the Controls collection of panel2. This adds the DataGridViewSetTool 
         * control to the panel2 control.
         * Brings the panel2 control to the front, ensuring that it is visible and overlays other controls if necessary.
         * Note: The panel2 control is assumed to be defined and accessible within the scope of this method.
         */
        private void dataGridViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Add(new DataGridViewSetTool());
            panel2.BringToFront();
        }
    }
}
