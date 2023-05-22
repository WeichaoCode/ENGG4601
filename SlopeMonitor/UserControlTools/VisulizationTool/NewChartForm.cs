using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
/// <summary>
/// These codes for creating new chart on Visulization page
/// Delegate is used to transmit data from different windows
/// becuse the data input in NewChartForm will be used in 
/// other froms like Visulization form
/// </summary>
namespace SlopeMonitor.UserControlTools.VisulizationTool
{
    /// <summary>
    /// Create a delegate handler event params in these event can be transimitted
    /// from different page
    /// </summary>
    /// <param name="chartType"></param>
    /// <param name="SeriesNum"></param>
    /// <param name="ChartSeriesName"></param>
    /// <param name="xLabel"></param>
    /// <param name="yLabel"></param>
    /// <param name="color"></param>
    /// <param name="chartNum"></param>
    /// <param name="Xvalue"></param>
    public delegate void ChartTypeSelectedHandler(string chartType, string SeriesNum, string ChartSeriesName,
        string xLabel, string yLabel, string color, string chartNum, string Xvalue);
    public partial class NewChartForm : Form
    {
        /// <summary>
        /// Create a ChartTypeSelected
        /// </summary>
        public event ChartTypeSelectedHandler ChartTypeSelected;
        public NewChartForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Control each combox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string color;
            if (comboBox6.SelectedIndex != -1)
            {
                color = comboBox6.SelectedItem.ToString();
            } else
            {
                color = "blue";
            }
            string SeriesNum;
            if (comboBox5.SelectedIndex == -1) 
            { 
                SeriesNum = "series1"; 
            } else
            {
                SeriesNum = comboBox5.SelectedItem.ToString();
            }
            string chartNum;
            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Please Enter the chart type！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                chartNum = "chart1";
            } else
            {
                chartNum = comboBox2.SelectedItem.ToString();
            }
            string Xvalue = "accX";
            if (comboBox3.SelectedIndex != -1)
            {
                Xvalue = comboBox3.SelectedItem.ToString();
            }
            string ChartSeriesName;
            string xLabel, yLabel;
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Please Enter the missing value！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                ChartSeriesName = textBox1.Text;
                xLabel = textBox2.Text;
                yLabel = textBox3.Text;
                ChartTypeSelected.Invoke(comboBox1.SelectedItem.ToString(), SeriesNum, ChartSeriesName, xLabel, 
                    yLabel, color, chartNum, Xvalue);
            }   
        }
        /// <summary>
        /// SelectedIndexChanged event use for user to click the select item
        /// and use this item to other events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem.ToString();
        }
        /// <summary>
        /// Add items to combox when the form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewChartForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("point");
            comboBox1.Items.Add("line");
            comboBox1.Items.Add("spline");
            comboBox1.Items.Add("column");
            comboBox1.Items.Add("bar");
            comboBox2.Items.Add("chart1");
            comboBox2.Items.Add("chart2");
            comboBox2.Items.Add("chart3");
            comboBox2.Items.Add("chart4");
            comboBox3.Items.Add("accX");
            comboBox3.Items.Add("accY");
            comboBox3.Items.Add("accZ");
            comboBox3.Items.Add("gyroX");
            comboBox3.Items.Add("gyroY");
            comboBox3.Items.Add("gyroZ");
            comboBox3.Items.Add("angleX");
            comboBox3.Items.Add("angleY");
            comboBox3.Items.Add("angleZ");
            comboBox3.Items.Add("magX");
            comboBox3.Items.Add("magY");
            comboBox3.Items.Add("magZ");
            comboBox3.Items.Add("temperature");
            comboBox3.Items.Add("humidity");
            comboBox4.Items.Add("accX");
            comboBox4.Items.Add("accY");
            comboBox4.Items.Add("accZ");
            comboBox4.Items.Add("gyroX");
            comboBox4.Items.Add("gyroY");
            comboBox4.Items.Add("gyroZ");
            comboBox4.Items.Add("angleX");
            comboBox4.Items.Add("angleY");
            comboBox4.Items.Add("angleZ");
            comboBox4.Items.Add("magX");
            comboBox4.Items.Add("magY");
            comboBox4.Items.Add("magZ");
            comboBox4.Items.Add("temperature");
            comboBox4.Items.Add("humidity");
            comboBox5.Items.Add("series1");
            comboBox5.Items.Add("series2");
            comboBox5.Items.Add("series3");
            comboBox6.Items.Add("blue");
            comboBox6.Items.Add("red");
            comboBox6.Items.Add("green");
            comboBox6.Items.Add("yellow");
            comboBox7.Items.Add("blue");
            comboBox7.Items.Add("red");
            comboBox7.Items.Add("green");
            comboBox7.Items.Add("yellow");
            comboBox8.Items.Add("blue");
            comboBox8.Items.Add("red");
            comboBox8.Items.Add("green");
            comboBox8.Items.Add("yellow");

        }
    }
}
