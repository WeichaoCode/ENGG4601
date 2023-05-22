using SlopeMonitor.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// These codes control the DataGridView
/// </summary>
namespace SlopeMonitor.UserControlTools.VisulizationTool
{
    public partial class DataGridViewSetTool : UserControl
    {
        public DataGridViewSetTool()
        {
            InitializeComponent();
            UpdateDataGridView();
        }
        // Create a list to save the latest N data
        private List<string[]> dataList = new List<string[]>();
        private int maxDataCount = 300; // Limit on the number of latest data
        private void UpdateDataGridView()
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

            // Determine if the number of data exceeds the limit, and if it exceeds
            // the limit, delete the previous data
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
        public DataGridView GetDataGridView()
        {
            // return DataGridView container
            return dataGridView1;
        }
    }
}
