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

namespace SlopeMonitor
{
    public partial class Form1 : Form
    {
        private string checkCode = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Login button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && CheckInput())
            {
                Login();
            }
            else if (CheckInput())
            {
                MessageBox.Show("PLease enter the username or passworld!");
            }
            else
            {
                MessageBox.Show("The verify code is wrong!");
            }
        }

        private bool CheckInput()
        {
            if (!textBox3.Text.Trim().Contains(checkCode))
            {
                //MessageBox.Show("Error occurs!");
                return false;
            }
            return true;
        }

        //Login methods, check if login is allowed
        public Boolean Login()
        {
            // user
            if (radioButton1.Checked == true)
            {
                Dao dao = new Dao();
                string sql = "select * from iot_user where id='" + textBox1.Text + "' and psw='" + textBox2.Text + "'";
                string sql2 = $"select * from iot_user where id='{textBox1.Text}'and psw='{textBox2.Text}'";
                IDataReader dc = dao.read(sql);
                if (dc.Read())
                {
                    // save data to Data.cs
                    Data.UID = dc["id"].ToString();
                    Data.UID = dc["name"].ToString();
                    Form1 beforeLogin = new Form1();
                    beforeLogin.ShowDialog();
                    this.Close();
                    MessageBox.Show("Successfully login!");
                    return true;
                }
                else
                {
                    MessageBox.Show("Login denied!");
                    return false;
                }
                dao.DaoClose();
            }
            // admin
            if (radioButton2.Checked == true)
            {
                Dao dao = new Dao();
                string sql = "select * from iot_admin where id='" + textBox1.Text + "' and pwd='" + textBox2.Text + "'";
                string sql2 = $"select * from iot_user where id='{textBox1.Text}'and psw='{textBox2.Text}'";
                IDataReader dc = dao.read(sql);
                if (dc.Read())
                {
                    MainForm beforeLogin = new MainForm();
                    beforeLogin.ShowDialog();
                    MessageBox.Show("Successfully login!");
                    // Close the login page if login successfully.
                    this.Close();
                    return true;
                }
                else
                {
                    MessageBox.Show("Login denied!");
                    return false;
                }
                dao.DaoClose();
            }
            MessageBox.Show("Please select admin or user first!");
            return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitialVerifyCode();
        }
        private void InitialVerifyCode()
        {
            Verify verify = new Verify()
            {
                CodeCount = 5
            };
            label5.Image = verify.CreateVerfiyCode();
            checkCode = verify.CheckCode;
            //MessageBox.Show(verify.CheckCode);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
