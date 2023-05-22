using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
/// <summary>
/// These codes for database connection. Note these codes only suitable for SQL database
/// This codes need to be modified before using them
/// User needs to modify the string str = @"Data Source=LAPTOP-28Q7CG90;Initial Catalog=IOT
/// ;Integrated Security=True"; to connect to your local database 
/// If you want more SQL operations you can add more functions but it is highly recommand that 
/// user do not change these codes except connect string.
/// </summary>
namespace SlopeMonitor.Common
{
    class Dao
    {
        SqlConnection sc;
        public SqlConnection connect()
        {
            string str = @"Data Source=LAPTOP-28Q7CG90;Initial Catalog=IOT;Integrated Security=True";// Dataset connection string 
            sc = new SqlConnection(str);// Create database connection object
            sc.Open();// Open database
            return sc;// Returns the database connection object
        }
        public SqlCommand command(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, connect());
            return cmd;
        }
        public int Execute(string sql)// Update operation 
        {
            return command(sql).ExecuteNonQuery();
        }
        public SqlDataReader read(string sql)// Read operation 
        {
            return command(sql).ExecuteReader();
        }
        public void DaoClose()
        {
            sc.Close();// Close database connection
        }
    }
}

