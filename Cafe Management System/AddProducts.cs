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
    public partial class AddProducts : Form
    {
        DataTable table = new DataTable("table");
        int index;
        int EmpID = 0;
        string MyConString = "Server=localhost;Database=cafe;Uid=root;Pwd='';Connect Timeout=30;";

        public AddProducts()
        {
            InitializeComponent();
        }



        private void AddProducts_Load(object sender, EventArgs e)
        {
            CmbStatus.SelectedIndex = 0;
            CmbType.SelectedIndex = 0;

            table.Columns.Add("Product ID", Type.GetType("System.Int32"));
            table.Columns.Add("Product Name", Type.GetType("System.String"));
            table.Columns.Add("Type", Type.GetType("System.String"));
            table.Columns.Add("Stock", Type.GetType("System.Int32"));
            table.Columns.Add("Price(PKR)", Type.GetType("System.Int32"));
            table.Columns.Add("Status", Type.GetType("System.String"));
            //GridAddProduct.DataSource = table;


            MySqlConnection MyConnection = new MySqlConnection(MyConString);
            MySqlCommand MyCommand = new MySqlCommand("", MyConnection);
            MyConnection.Open();
            MyCommand.CommandText = "SELECT * FROM products";
            MySqlDataAdapter adapter = new MySqlDataAdapter(MyCommand);
            DataSet Ds = new DataSet();
            adapter.Fill(Ds);
            GridAddProduct.DataSource = Ds.Tables[0].DefaultView;
            MyConnection.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TxtProductName.Text == ""
                || CmbType.SelectedIndex == 0 || TxtStock.Text == ""
                || TxtPrice.Text == "" || CmbStatus.SelectedIndex == 0)
            {
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //table.Rows.Add(EmpID,TxtProductName.Text, CmbType.Text, TxtStock.Text, TxtPrice.Text, CmbStatus.Text);
                MySqlConnection MyConnection = new MySqlConnection(MyConString);
                MySqlCommand MyCommand = new MySqlCommand("", MyConnection);
                MySqlDataReader MyReader;
                MyConnection.Open();
                MyCommand.CommandText = "SELECT Max(ProductID) As ProductID FROM products";
                MyReader = MyCommand.ExecuteReader();
                if (MyReader.HasRows == true)
                {
                    MyReader.Read();
                    EmpID = MyReader.GetInt32("ProductID");
                }
                EmpID = EmpID + 1;
                table.Rows.Add(EmpID, TxtProductName.Text, CmbType.Text, TxtStock.Text, TxtPrice.Text, CmbStatus.Text);
                MyReader.Close();
                MyCommand.CommandText = "INSERT INTO products (ProductID, ProductName, Type, Stock, Price, Status) " +
                            "VALUES (@ProductID, @ProductName, @Type, @Stock, @Price, @Status)";
                MyCommand.Parameters.AddWithValue("@ProductID", EmpID);
                MyCommand.Parameters.AddWithValue("@ProductName", TxtProductName.Text);
                MyCommand.Parameters.AddWithValue("@Type", CmbType.Text);
                MyCommand.Parameters.AddWithValue("@Stock", TxtStock.Text);
                MyCommand.Parameters.AddWithValue("@Price", TxtPrice.Text);
                MyCommand.Parameters.AddWithValue("@Status", CmbStatus.Text);
                MyCommand.ExecuteNonQuery();
                MyConnection.Close();
                MessageBox.Show("Data added successfully to GridView and Database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void GridAddProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = GridAddProduct.Rows[index];
           // EmpID = row.Cells[0].Value.ToInt();
            TxtProductName.Text = row.Cells[1].Value.ToString();
            CmbType.Text = row.Cells[2].Value.ToString();
            TxtStock.Text = row.Cells[3].Value.ToString();
            TxtPrice.Text = row.Cells[4].Value.ToString();
            CmbStatus.Text = row.Cells[5].Value.ToString();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdata = GridAddProduct.Rows[index];
           // newdata.Cells[0].Value = TxtProductID.Text;
            newdata.Cells[1].Value = TxtProductName.Text;
            newdata.Cells[2].Value = CmbType.Text;
            newdata.Cells[3].Value = TxtStock.Text;
            newdata.Cells[4].Value = TxtPrice.Text;
            newdata.Cells[5].Value = CmbStatus.Text;

            MySqlConnection MyConnection = new MySqlConnection(MyConString);
            MySqlCommand MyCommand = new MySqlCommand("", MyConnection);
            MyConnection.Open();
            MyCommand.CommandText = "UPDATE products SET ProductName = @ProductName, Type = @Type, Stock = @Stock, " +
                    "Price = @Price, Status = @Status WHERE ProductID = @ProductID";
            MyCommand.Parameters.AddWithValue("@ProductID", EmpID);
            MyCommand.Parameters.AddWithValue("@ProductName", TxtProductName.Text);
            MyCommand.Parameters.AddWithValue("@Type", CmbType.Text);
            MyCommand.Parameters.AddWithValue("@Stock", TxtStock.Text);
            MyCommand.Parameters.AddWithValue("@Price", TxtPrice.Text);
            MyCommand.Parameters.AddWithValue("@Status", CmbStatus.Text);
            MyCommand.ExecuteNonQuery();
            MyConnection.Close();
            MessageBox.Show("Data updated successfully in GridView and Database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            index = GridAddProduct.CurrentCell.RowIndex;
            int productId = Convert.ToInt32(GridAddProduct.Rows[index].Cells[0].Value);
            GridAddProduct.Rows.RemoveAt(index);

            MySqlConnection MyConnection = new MySqlConnection(MyConString);
            MySqlCommand MyCommand = new MySqlCommand("", MyConnection);
            MyConnection.Open();
            MyCommand.CommandText = "DELETE FROM products WHERE ProductID = @ProductID";
            MyCommand.Parameters.AddWithValue("@ProductID", productId);
            MyCommand.ExecuteNonQuery();
            MyConnection.Close();
            MessageBox.Show("Data deleted successfully from GridView and Database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            //TxtProductID.Text = String.Empty;
            TxtProductName.Text = String.Empty;
           // CmbType.Text = String.SelectedIndex = 0;
            CmbType.SelectedIndex = 0; ;
            TxtStock.Text = String.Empty;
            TxtPrice.Text = String.Empty;
           // CmbStatus.Text = String.Empty;
            CmbStatus.SelectedIndex = 0;
        }

        private void Search()
        {
            MySqlConnection MyConnection = new MySqlConnection(MyConString);
            MySqlCommand MyCommand = new MySqlCommand("", MyConnection);
            MyConnection.Open();
            MyCommand.CommandText = "SELECT * FROM products"; //WHERE ProductName = @ProductName";
            // MyCommand.Parameters.AddWithValue("@ProductName", TxtSearch.Text);
            if (TxtSearch.Text.Length > 0)
            {
                MyCommand.CommandText += " WHERE ProductID = '" + TxtSearch.Text + "' OR ProductName LIKE '%" + TxtSearch.Text + "%' OR Type LIKE '%" + TxtSearch.Text + "%'";
            }
            MySqlDataAdapter da = new MySqlDataAdapter(MyCommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                GridAddProduct.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No matching product found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            MyConnection.Close();
        }


        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (TxtSearch.Text == "")
            {
                MessageBox.Show("Please enter something to search.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Search();
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }


    }
    }
 


