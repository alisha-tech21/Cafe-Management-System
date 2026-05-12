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
    public partial class Customer : Form
    {
        DataTable table = new DataTable("table");
        int index;
        int CustID = 0;
        string MyConString = "Server=localhost;Database=cafe;Uid=root;Pwd='';Connect Timeout=30;";

        public static int? SelectedCustomerId { get; private set; }
        public static string SelectedCustomerName { get; private set; }

        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Customer ID", Type.GetType("System.Int32"));
            table.Columns.Add("Customer Name", Type.GetType("System.String"));
            table.Columns.Add("Phone", Type.GetType("System.String"));
            table.Columns.Add("Email", Type.GetType("System.String"));
            //table.Columns.Add("Address", Type.GetType("System.String"));
            //table.Columns.Add("Status", Type.GetType("System.String"));
            GridAddCustomer.DataSource = table;
            LoadCustomerData();
        }

        private void LoadCustomerData()
        {
            MySqlConnection MyConnection = new MySqlConnection(MyConString);
            MySqlCommand MyCommand = MyConnection.CreateCommand();
            MyConnection.Open();
            MyCommand.CommandText = "SELECT * FROM customer";
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter(MyCommand);
            DataSet Ds = new DataSet();
            MyAdapter.Fill(Ds);
            GridAddCustomer.DataSource = Ds.Tables[0].DefaultView;
            MyConnection.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TxtCustomerName.Text == ""
           || TxtPhone.Text == "" || TxtEmail.Text == "") 
        {
        MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            MySqlConnection MyConnection = new MySqlConnection(MyConString);
            MySqlCommand MyCommand = new MySqlCommand("", MyConnection);
            MySqlDataReader MyReader;
            MyConnection.Open();
            MyCommand.CommandText = "SELECT Max(customer_id) As customer_id FROM customer";
            MyReader = MyCommand.ExecuteReader();
            if (MyReader.HasRows)
            {
                MyReader.Read();


                CustID = MyReader.GetInt32("customer_id");
            }
            CustID = CustID + 1;
            table.Rows.Add(CustID, TxtCustomerName.Text, TxtPhone.Text, TxtEmail.Text);
            MyReader.Close();
            MyCommand.CommandText = "INSERT INTO customer (customer_id, customer_name, phone_no, email) " +
                        " VALUES (@customer_id, @customer_name, @phone_no, @email)";
            MyCommand.Parameters.AddWithValue("@customer_id", CustID);
            MyCommand.Parameters.AddWithValue("@customer_name", TxtCustomerName.Text);
            MyCommand.Parameters.AddWithValue("@phone_no", TxtPhone.Text);
            MyCommand.Parameters.AddWithValue("@email", TxtEmail.Text);
            //MyCommand.Parameters.AddWithValue("@Address", TxtAddress.Text);
            //MyCommand.Parameters.AddWithValue("@Status", CmbStatus.Text);
            MyCommand.ExecuteNonQuery();
            LoadCustomerData();
            MyConnection.Close();
            MessageBox.Show("Data added successfully to GridView and Database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        }

        private void GridAddCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = GridAddCustomer.Rows[index];
            CustID = Convert.ToInt32(row.Cells[0].Value); // Set the CustomerID for update/delete
            TxtCustomerName.Text = row.Cells[1].Value.ToString();
            TxtPhone.Text = row.Cells[2].Value.ToString();
            TxtEmail.Text = row.Cells[3].Value.ToString();
            //TxtAddress.Text = row.Cells[4].Value.ToString();
            //CmbStatus.Text = row.Cells[5].Value.ToString();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdata = GridAddCustomer.Rows[index];
            newdata.Cells[1].Value = TxtCustomerName.Text;
            newdata.Cells[2].Value = TxtPhone.Text;
            newdata.Cells[3].Value = TxtEmail.Text;
            //newdata.Cells[4].Value = TxtAddress.Text;
            //newdata.Cells[5].Value = CmbStatus.Text;

            MySqlConnection MyConnection = new MySqlConnection(MyConString);
            MySqlCommand MyCommand = new MySqlCommand("", MyConnection);
            MyConnection.Open();
            MyCommand.CommandText = "UPDATE customer SET customer_name = @customer_name , phone_no = @phone_no , email = @email " +
                    " WHERE customer_id = @customer_id";
            MyCommand.Parameters.AddWithValue("@customer_id", CustID);
            MyCommand.Parameters.AddWithValue("@customer_name", TxtCustomerName.Text);
            MyCommand.Parameters.AddWithValue("@phone_no", TxtPhone.Text);
            MyCommand.Parameters.AddWithValue("@email", TxtEmail.Text);
            // MyCommand.Parameters.AddWithValue("@Address", TxtAddress.Text);
            // MyCommand.Parameters.AddWithValue("@Status", CmbStatus.Text);
            MyCommand.ExecuteNonQuery();
            MyConnection.Close();
            MessageBox.Show("Data updated successfully in GridView and Database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int customerId = Convert.ToInt32(GridAddCustomer.Rows[index].Cells[0].Value);
            GridAddCustomer.Rows.RemoveAt(index);

            MySqlConnection MyConnection = new MySqlConnection(MyConString);
            MySqlCommand MyCommand = new MySqlCommand("", MyConnection);
            MyConnection.Open();
            MyCommand.CommandText = "DELETE FROM customer WHERE customer_id = @customer_id";
            MyCommand.Parameters.AddWithValue("@customer_id", customerId);
            MyCommand.ExecuteNonQuery();
            MyConnection.Close();
            MessageBox.Show("Data deleted successfully from GridView and Database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtCustomerName.Text = String.Empty;
            TxtPhone.Text = String.Empty;
            TxtEmail.Text = String.Empty;
            //TxtAddress.Text = String.Empty;
            //CmbStatus.SelectedIndex = 0;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (TxtSearch.Text == "")
            {
                MessageBox.Show("Please enter a Customer Name to search.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Search();
        }
        private void Search()
        {
            MySqlConnection MyConnection = new MySqlConnection(MyConString);
            MySqlCommand MyCommand = new MySqlCommand("", MyConnection);
            MyConnection.Open();
            MyCommand.CommandText = "SELECT * FROM customer"; // WHERE CustomerName = @CustomerName";
            //MyCommand.Parameters.AddWithValue("@CustomerName", TxtSearch.Text);
            if (TxtSearch.Text.Length > 0)
            {
                MyCommand.CommandText += " WHERE customer_id = '" + TxtSearch.Text + "' OR customer_name LIKE '%" + TxtSearch.Text + "%'";
            }
            MySqlDataAdapter da = new MySqlDataAdapter(MyCommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                GridAddCustomer.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No matching customer found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            MyConnection.Close();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            // Ensure a customer is selected
            if (index >= 0 && index < GridAddCustomer.Rows.Count)
            {
                DataGridViewRow row = GridAddCustomer.Rows[index];
                SelectedCustomerId = Convert.ToInt32(row.Cells[0].Value);
                SelectedCustomerName = row.Cells[1].Value.ToString();

                this.Close(); // Close the customer form
            }
            else
            {
                MessageBox.Show("Please select a customer.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
