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
    public partial class ViewOrder : Form
    {
        string MyConString = "Server=localhost;Database=cafe;Uid=root;Pwd='';Connect Timeout=30;";
        public ViewOrder()
        {
            InitializeComponent();
        }

        private void ViewOrder_Load(object sender, EventArgs e)
        {
            Order();
        }

        private void Order()//(string type)
        {
            MySqlConnection MyConnection = new MySqlConnection(MyConString);
            MySqlCommand MyCommand = new MySqlCommand("", MyConnection);
            MyConnection.Open();
            MyCommand.CommandText = "SELECT * FROM customer_order";// WHERE Type = @Type";
            //MyCommand.Parameters.AddWithValue("@Type", type);
            MySqlDataAdapter adapter = new MySqlDataAdapter(MyCommand);
            //DataTable table = new DataTable();
            //adapter.Fill(table);
            //GridMenu.DataSource = table;
            DataSet Ds = new DataSet();
            adapter.Fill(Ds);
            GridViewOrder.DataSource = Ds.Tables[0].DefaultView;
            MyConnection.Close();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (TxtSearch.Text == "")
            {
                MessageBox.Show("Please enter a Product Name to search.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Search();
            }
        }

        private void Search()
        {
            MySqlConnection MyConnection = new MySqlConnection(MyConString);
            MySqlCommand MyCommand = new MySqlCommand("", MyConnection);
            MyConnection.Open();
            MyCommand.CommandText = "SELECT * FROM customer_order";// WHERE ProductName LIKE '%" + TxtSearch.Text + "%'";
            //MyCommand.Parameters.AddWithValue("@ProductName", TxtSearch.Text);
            if (TxtSearch.Text.Length > 0)
            {
                MyCommand.CommandText += " WHERE OrderNo = '" + TxtSearch.Text + "' OR ProductName LIKE '%" + TxtSearch.Text + "%' OR OrderTime LIKE '%" + TxtSearch.Text + "%'";
            }
            MySqlDataAdapter da = new MySqlDataAdapter(MyCommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                GridViewOrder.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No matching product found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            MyConnection.Close();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}
