using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using MapWinGIS;
using SlopeMonitor.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// These codes control the map form, Gmap is used in this form
/// </summary>
namespace SlopeMonitor.UserControlTools
{
    public partial class MapPosition : UserControl
    {   
        // Use this to add point on map
        private List<PointLatLng> _points;
        public MapPosition()
        {
            InitializeComponent();

            Table();
            _points = new List<PointLatLng>();
        }

        private List<string[]> dataList = new List<string[]>();
        private int maxDataCount = 300; // limit the number of newest data display 
        private void Table()
        {
            // clear old data
            dataGridView1.Rows.Clear();

            // read newest data
            Dao dao = new Dao();
            string sql = "select top " + maxDataCount + " * from Sensor order by ID desc";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                string[] data = { dc[1].ToString(), dc[2].ToString(), dc[3].ToString(),
                dc[4].ToString(), dc[5].ToString(), dc[6].ToString(),
                dc[7].ToString(), dc[8].ToString(), dc[9].ToString(),
                dc[10].ToString(), dc[11].ToString(), dc[12].ToString(),
                dc[13].ToString(), dc[14].ToString()};
                dataList.Add(data);
            }
            dc.Close();
            dao.DaoClose();

            // Determine if the number of data exceeds the limit, and if it exceeds the
            // limit, delete the previous data
            if (dataList.Count > maxDataCount)
            {
                dataList.RemoveRange(0, dataList.Count - maxDataCount);
            }

            // Display the latest data in the table
            for (int i = 0; i < dataList.Count; i++)
            {
                dataGridView1.Rows.Add(dataList[i]);
            }
        }
        // Add a marker layer on the map layer to add marker on the map
        GMapOverlay markers = new GMapOverlay("markers");

        private void button1_Click(object sender, EventArgs e)
        {
            // Show latitude and longtitude data on the map
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            double latitude = Convert.ToDouble(textBox1.Text);
            double longtitude = Convert.ToDouble(textBox2.Text);
            gMapControl1.Position = new PointLatLng(latitude, longtitude);
            gMapControl1.MinZoom = 5;//Min Zoom Level
            gMapControl1.MaxZoom = 100;//Max Zoom Level
            gMapControl1.Zoom = 10;//Current Zoom Level
            // Mark the position of the sensor
            PointLatLng point = new PointLatLng(latitude, longtitude);
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_pushpin);
            //1. Create an overlay
            GMapOverlay markers = new GMapOverlay("markers");
            //2. Add all avaiable markers to that overlay
            markers.Markers.Add(marker);
            //3. Cover map with overlay
            gMapControl1.Overlays.Add(markers);
        }
        /// <summary>
        /// Add DataGridView row data to three textBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            this.textBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            this.textBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
        /// <summary>
        /// Button2 click event add point to the map and show the
        /// x and y position of the sensor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            _points.Add(new PointLatLng(Convert.ToDouble(textBox1.Text),
            Convert.ToDouble(textBox2.Text)));
        }
        /// <summary>
        /// Button 3 click event clear and refresh the points on the map
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            _points.Clear();
            if (gMapControl1.Overlays.Count > 0)
            {
                gMapControl1.Overlays.RemoveAt(0);
                gMapControl1.Refresh();
            }
        }
        /// <summary>
        /// Button4 click event change the postion and shape of the points on the map
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            gMapControl1.Position = new GMap.NET.PointLatLng(39.9, 116.4);
            gMapControl1.Zoom = 10;
            gMapControl1.MinZoom = 2;
            gMapControl1.MaxZoom = 18;
            gMapControl1.Manager.Mode = GMap.NET.AccessMode.ServerOnly;
        }
    }
}
