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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            Login F = new Login();
            F.Show();
            this.Hide();
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            if (TxtUserName.Text == "" || TxtPassword.Text == "" || TxtConfirmPassword.Text == "")
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TxtPassword.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtPassword.Focus();
                return;
            }
            if (TxtPassword.Text != TxtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtPassword.Text = "";
                TxtConfirmPassword.Text = "";
                TxtPassword.Focus();
                return;
            }
            string MyConString = "Server=localhost;Database=cafe;Uid=root;Pwd='';Connect Timeout=30;";
            MySqlConnection MyConnection = new MySqlConnection(MyConString);
            MySqlCommand MyCommand = new MySqlCommand("", MyConnection);
            //MySqlDataReader MyReader;
            MyConnection.Open();
            MyCommand.CommandText = "INSERT INTO adminlogin (UserName, Password, ConfirmPassword) VALUES (@UserName, @Password, @ConfirmPassword)";
            MyCommand.Parameters.AddWithValue("@UserName", TxtUserName.Text);
            MyCommand.Parameters.AddWithValue("@Password", TxtPassword.Text);
            MyCommand.Parameters.AddWithValue("@ConfirmPassword", TxtConfirmPassword.Text);
            MyCommand.ExecuteNonQuery();
            MessageBox.Show("Sign up successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dashboard D = new Dashboard();
            D.Show();
            this.Hide();
            MyConnection.Close();
        }

        private void ChkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkShowPassword.Checked)
            {
                TxtPassword.UseSystemPasswordChar = false;
                TxtConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                TxtPassword.UseSystemPasswordChar = true;
                TxtConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        
    }
}
