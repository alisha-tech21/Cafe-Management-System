using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Cafe_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Register R = new Register();
            R.Show();
            this.Hide();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtUserName.Text == "")
            {
                MessageBox.Show("Please Enter the User Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtUserName.Text = "";
                TxtUserName.Focus();
                return;
            }
            if (TxtPassword.Text == "")
            {
                MessageBox.Show("Please Enter the Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtPassword.Text = "";
                TxtPassword.Focus();
                return;
            }


            string MyConString = "Server=localhost;Database=cafe;Uid=root;Pwd='';Connect Timeout=30;";
            MySqlConnection MyConnection = new MySqlConnection(MyConString);
            MySqlCommand MyCommand = new MySqlCommand("", MyConnection);
            MySqlDataReader MyReader;
            MyConnection.Open();
            string storedPassword = "";
            string storedUsername = "";
            bool LoginFlag = false;            
           // MyCommand.CommandText = "SELECT UserName, Password FROM adminlogin WHERE UserName = @UserName";
            //MyCommand.Parameters.AddWithValue("@UserName", enteredUsername);
            MyCommand.CommandText = "SELECT UserName, Password FROM adminlogin WHERE UserName = '" + TxtUserName.Text + "' AND Password = '" + TxtPassword.Text +"'";
            MyReader = MyCommand.ExecuteReader();
            if (MyReader.HasRows == true)
            {
                MyReader.Read();
                storedUsername = MyReader.GetString("UserName");
                storedPassword = MyReader.GetString("Password");
                LoginFlag = true;               
            }
            if (LoginFlag == true)
            {
                Dashboard D = new Dashboard();
                D.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtUserName.Text = "";
                TxtPassword.Text = "";
                TxtUserName.Focus();

            }
            MyConnection.Close();
        }

        private void ChkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkShowPassword.Checked)
            {
                TxtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                TxtPassword.UseSystemPasswordChar = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            TxtUserName.Text = "Admin";
            TxtPassword.Text = "admin@1136";

        }
    }
}
