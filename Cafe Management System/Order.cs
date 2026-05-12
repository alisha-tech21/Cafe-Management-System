using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;


namespace Cafe_Management_System
{
    public partial class Order : Form
    {
        int index;
        int TID = 1;
        private DataTable currentSessionData = new DataTable();
        private int currentOrderNo = 1;
       // private DateTime lastOrderDate = DateTime.Today; // Store today's date initially

        string MyConString = "Server=localhost;Database=cafe;Uid=root;Pwd='';Connect Timeout=30;";

        public Order()
        {
            InitializeComponent();
            InitializeCurrentSessionData();
            GridPay.DataSource = currentSessionData;
        }

        private void Order_Load(object sender, EventArgs e)
        {
            CmbType.SelectedIndex = 0;
            //CmbStatus.SelectedIndex = 0; 
           // InitializeGridPay();
            LoadDataByType();
            currentOrderNo = GetLatestOrderNo() + 1;
        }

        private void CmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // string selectedType = CmbType.SelectedItem.ToString();
            // LoadDataByType(selectedType);
        }
        private void LoadDataByType()//(string type)
        {
            MySqlConnection MyConnection = new MySqlConnection(MyConString);
            MySqlCommand MyCommand = new MySqlCommand("", MyConnection);
            MyConnection.Open();
            MyCommand.CommandText = "SELECT * FROM products";// WHERE Type = @Type";
            //MyCommand.Parameters.AddWithValue("@Type", type);
            MySqlDataAdapter adapter = new MySqlDataAdapter(MyCommand);
            //DataTable table = new DataTable();
            //adapter.Fill(table);
            //GridMenu.DataSource = table;
            DataSet Ds = new DataSet();
            adapter.Fill(Ds);
            GridMenu.DataSource = Ds.Tables[0].DefaultView;
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
            MyCommand.CommandText = "SELECT * FROM products";// WHERE ProductName LIKE '%" + TxtSearch.Text + "%'";
            //MyCommand.Parameters.AddWithValue("@ProductName", TxtSearch.Text);
            if (TxtSearch.Text.Length > 0)
            {
                MyCommand.CommandText += " WHERE ProductID = '" + TxtSearch.Text + "' OR ProductName LIKE '%" + TxtSearch.Text + "%' OR Type LIKE '%" + TxtSearch.Text + "%'";
            }
            MySqlDataAdapter da = new MySqlDataAdapter(MyCommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                GridMenu.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No matching product found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            MyConnection.Close();
        }

        private void GridMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow row = GridMenu.Rows[index];
                TxtProductID.Text = row.Cells[0].Value.ToString();
                TxtProductName.Text = row.Cells[1].Value.ToString();
                CmbType.Text = row.Cells[2].Value.ToString();
                //TxtStock.Text = row.Cells[3].Value.ToString();
                //TxtPrice.Text = row.Cells[4].Value.ToString();
                //CmbStatus.Text = row.Cells[5].Value.ToString();
                if (row.Cells[4].Value != null)
                {
                    // Ensure the value is of the correct numeric type
                    var priceValue = row.Cells[4].Value;
                    TxtPrice.Text = priceValue.ToString();  // Convert the numeric value to string
                }
            }
            else
            {
                MessageBox.Show("Price is null or not found in the expected cell.");
            }


            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = GridMenu.Rows[e.RowIndex];

            //    if (row.Cells[0].Value != null)
            //        TxtProductID.Text = row.Cells[0].Value.ToString();
            //    if (row.Cells[1].Value != null)
            //        TxtProductName.Text = row.Cells[1].Value.ToString();
            //    if (row.Cells[2].Value != null)
            //        CmbType.Text = row.Cells[2].Value.ToString();
            //    if (row.Cells[4].Value != null)
            //    {
            //     TxtPrice.Text = row.Cells[4].Value.ToString();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Price is null or not found in the expected cell.");
            //    }
            //}
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtProductID.Text = String.Empty;
            TxtProductName.Text = String.Empty;
            // CmbType.Text = String.SelectedIndex = 0;
            CmbType.SelectedIndex = 0; ;
            //TxtStock.Text = String.Empty;
            TxtPrice.Text = String.Empty;
            // CmbStatus.Text = String.Empty;
            // CmbStatus.SelectedIndex = 0;
            NUDQuantity.Value = 0;
            TxtSearch.Text = String.Empty;
        }

        private void InitializeOrderNo()
        {
            // Check if a new day has started, if so, reset the OrderNo to 1
            //if (DateTime.Today > lastOrderDate)
            //{
            //    currentOrderNo = 1; // Reset OrderNo
            //    lastOrderDate = DateTime.Today;
            //}

            // Optionally, fetch the last used OrderNo from the database for the current day
            using (MySqlConnection MyConnection = new MySqlConnection(MyConString))
            {
                MyConnection.Open();
                MySqlCommand MyCommand = new MySqlCommand("SELECT MAX(OrderNo) FROM customer_order WHERE DATE(OrderTime) = @Today", MyConnection);
                MyCommand.Parameters.AddWithValue("@Today", DateTime.Today);

                object result = MyCommand.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                {
                    currentOrderNo = Convert.ToInt32(result) + 1; // Increment the last used OrderNo
                }
            }
        }

        private int GetLatestOrderNo()
        {
            int latestOrderNo = 0;

            using (MySqlConnection MyConnection = new MySqlConnection(MyConString))
            {
                MyConnection.Open();
                MySqlCommand MyCommand = new MySqlCommand("SELECT MAX(OrderNo) FROM customer_order", MyConnection);

                object result = MyCommand.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    latestOrderNo = Convert.ToInt32(result);
                }
            }

            return latestOrderNo;
        }



        private void BtnAddToCart_Click(object sender, EventArgs e)
        {
            if (NUDQuantity.Value == 0)
            {
                MessageBox.Show("Please enter quantity");
                return;
            }

            // Get the quantity and price per item
            int quantity = (int)NUDQuantity.Value;
            int pricePerItem = int.Parse(TxtPrice.Text);

            // Calculate total price based on the quantity
            int totalPrice = pricePerItem * quantity;

            int nextTransitionID = 1; // Default to 1 if no rows exist

            if (GridPay.Rows.Count > 0)
            {
                // Iterate through the GridPay to find the highest TransitionID
                foreach (DataGridViewRow row in GridPay.Rows)
                {
                    if (row.Cells["TransitionID"].Value != null)
                    {
                        int currentID = Convert.ToInt32(row.Cells["TransitionID"].Value);
                        if (currentID >= nextTransitionID)
                        {
                            nextTransitionID = currentID + 1; // Next TransitionID should be the highest + 1
                        }
                    }
                }
            }



            // Add the current item to the session-based DataTable
            DataRow newRow = currentSessionData.NewRow();
            newRow["OrderNo"] = currentOrderNo;
            newRow["TransitionID"] = nextTransitionID;
            newRow["ProductID"] = TxtProductID.Text;
            newRow["ProductName"] = TxtProductName.Text;
            newRow["Type"] = CmbType.Text;
            newRow["Price"] = totalPrice;  // Set the total price (price * quantity)
            newRow["Quantity"] = quantity;
            newRow["OrderTime"] = DateTime.Now;
            currentSessionData.Rows.Add(newRow);

            // Update GridPay to reflect the added items
            GridPay.DataSource = currentSessionData;

            //DateTime lastOrderTime = DateTime.MinValue;

            //using (MySqlConnection MyConnection = new MySqlConnection(MyConString))
            //{
            //    MyConnection.Open();
            //    MySqlCommand command = new MySqlCommand("SELECT MAX(OrderTime) FROM customer_order", MyConnection);
            //    object result = command.ExecuteScalar();

            //    if (result != DBNull.Value)
            //    {
            //        lastOrderTime = Convert.ToDateTime(result);
            //    }
            //}

            //DateTime currentDate = DateTime.Now.Date; // Get the current date (without time)

            //if (lastOrderTime.Date != currentDate)
            //{
            //    // Step 3: Reset the OrderNo if the date has changed
            //    currentOrderNo = 1; // Reset to 1 for the new day
            //}
            //else
            //{
            //    // If the date has not changed, increment the OrderNo
            //   // currentOrderNo++;
            //    currentOrderNo = GetLatestOrderNo() + 1;
            //}

            // Get the current date and time
            DateTime currentTime = DateTime.Now;

            //currentOrderNo = GetLatestOrderNo() + 1;

            // Insert the current item into the database
            using (MySqlConnection MyConnection = new MySqlConnection(MyConString))
            {
                MyConnection.Open();
                MySqlCommand insertCommand = new MySqlCommand("INSERT INTO customer_order (OrderNo, TransitionID, ProductID, ProductName, Type, Price, Quantity, OrderTime) VALUES (@OrderNo, @TransitionID, @ProductID, @ProductName, @Type, @Price, @Quantity, @OrderTime)", MyConnection);
                insertCommand.Parameters.AddWithValue("@OrderNo", currentOrderNo);
                insertCommand.Parameters.AddWithValue("@TransitionID", nextTransitionID);  // Insert TransitionID
                insertCommand.Parameters.AddWithValue("@ProductID", TxtProductID.Text);
                insertCommand.Parameters.AddWithValue("@ProductName", TxtProductName.Text);
                insertCommand.Parameters.AddWithValue("@Type", CmbType.Text);
                insertCommand.Parameters.AddWithValue("@Price", totalPrice);  // Insert total price (price * quantity)
                insertCommand.Parameters.AddWithValue("@Quantity", quantity);
                insertCommand.Parameters.AddWithValue("@OrderTime", currentTime);
                insertCommand.ExecuteNonQuery();
            }

            TID++;

            // Clear the input fields after adding the data
            TxtProductID.Text = string.Empty;
            TxtProductName.Text = string.Empty;
            CmbType.SelectedIndex = 0;
            TxtPrice.Text = string.Empty;
            NUDQuantity.Value = 0;

            // Update the total amount
            CalculateTotalAmount();
        }

        private void LoadNewlyAddedData()
        {
            using (MySqlConnection MyConnection = new MySqlConnection(MyConString))
            {
                MyConnection.Open();
                MySqlCommand MyCommand = new MySqlCommand("SELECT * FROM customer_order WHERE ProductID = @ProductID", MyConnection);
                MyCommand.Parameters.AddWithValue("@ProductID", TxtProductID.Text);

                MySqlDataAdapter adapter = new MySqlDataAdapter(MyCommand);
                DataTable dt = new DataTable();

                // Clear the GridView data source before reloading
                GridPay.DataSource = null;
                GridPay.Rows.Clear();
                GridPay.Refresh();

                // Fill the DataTable with only the newly added record
                adapter.Fill(dt);
                GridPay.DataSource = dt;
            }
        }

        private void InitializeCurrentSessionData()
        {
            // Create the columns for the DataTable (even when there's no data)
            currentSessionData.Columns.Add("OrderNo", typeof(int));
            currentSessionData.Columns.Add("TransitionID", typeof(int));
            currentSessionData.Columns.Add("ProductID");
            currentSessionData.Columns.Add("ProductName");
            currentSessionData.Columns.Add("Type");
            currentSessionData.Columns.Add("Price", typeof(int));
            currentSessionData.Columns.Add("Quantity", typeof(int));
            currentSessionData.Columns.Add("OrderTime", typeof(DateTime)); 
            ClearGridPayData();
        }


        //    bool productExists = false;
        //    foreach (DataGridViewRow row in GridPay.Rows)
        //    {
        //        if (row.Cells["ProductID"].Value != null && row.Cells["ProductID"].Value.ToString() == TxtProductID.Text)
        //        {
        //            int existingQuantity = int.Parse(row.Cells["Quantity"].Value.ToString());
        //            int newQuantity = existingQuantity + quantity;
        //            row.Cells["Quantity"].Value = newQuantity;
        //            row.Cells["Price"].Value = (newQuantity * pricePerItem).ToString();
        //            productExists = true;
        //            break;
        //        }
        //    }

        //    if (!productExists)
        //    {
        //        int rowIndex = GridPay.Rows.Add();
        //        DataGridViewRow newRow = GridPay.Rows[rowIndex];

        //        newRow.Cells["ProductID"].Value = TxtProductID.Text;
        //        newRow.Cells["ProductName"].Value = TxtProductName.Text;
        //        newRow.Cells["Type"].Value = CmbType.Text;
        //        newRow.Cells["Quantity"].Value = quantity;
        //        newRow.Cells["Price"].Value = (quantity * pricePerItem).ToString();
        //    }

        //    TxtProductID.Text = string.Empty;
        //    TxtProductName.Text = string.Empty;
        //    CmbType.SelectedIndex = 0;
        //    TxtPrice.Text = string.Empty;
        //    NUDQuantity.Value = 0;

        //    CalculateTotalAmount();
        //}


        // private void Grid()
        // {
        //  DataSet ds = new DataSet();
        // DataTable dt = new DataTable();
        //  dt.Columns.Add(new DataColumn("ProductID", typeof(int)));
        // dt.Columns.Add(new DataColumn("ProductName", typeof(string)));
        // dt.Columns.Add(new DataColumn("Type", typeof(string)));
        //   dt.Columns.Add(new DataColumn("Price", typeof(string)));


        // }



        //private void InitializeGridPay()
        //{
        //    // Add columns to GridPay DataGridView
        //    // GridPay.Columns.Add("TransitionID", "Transition ID");
        //    GridPay.Columns.Add("ProductID", "Product ID");
        //    GridPay.Columns.Add("ProductName", "Product Name");
        //    GridPay.Columns.Add("Type", "Type");
        //    GridPay.Columns.Add("Price", "Price (PKR)");
        //    GridPay.Columns.Add("Quantity", "Quantity");

        //    // Ensure the columns are in the correct order
        //    // GridPay.Columns["TransitionID"].DisplayIndex = 0;
        //    GridPay.Columns["ProductID"].DisplayIndex = 0;
        //    GridPay.Columns["ProductName"].DisplayIndex = 1;
        //    GridPay.Columns["Type"].DisplayIndex = 2;
        //    GridPay.Columns["Price"].DisplayIndex = 3;
        //    GridPay.Columns["Quantity"].DisplayIndex = 4;
        //}


        // private void GridPay_CellClick(object sender, DataGridViewCellEventArgs e)
        // {
        //    index = e.RowIndex;
        //   DataGridViewRow row = GridMenu.Rows[index];
        //    TxtProductID.Text = row.Cells[0].Value.ToString();
        //    TxtProductName.Text = row.Cells[1].Value.ToString();
        //    CmbType.Text = row.Cells[2].Value.ToString();
        //TxtStock.Text = row.Cells[3].Value.ToString();
        //    TxtPrice.Text = row.Cells[4].Value.ToString();
        //CmbStatus.Text = row.Cells[5].Value.ToString();
        // }

        


        //if (GridPay.CurrentCell != null)
        // {
        //   int index = GridPay.CurrentCell.RowIndex;
        //  if (index >= 0)
        // {
        // Remove the selected row
        //   GridPay.Rows.RemoveAt(index);

        // Recalculate the total amount after removing the row
        // CalculateTotalAmount();
        //  }
        //}
        //}

        private void CalculateTotalAmount()
        {
            decimal totalAmount = 0;

            foreach (DataGridViewRow row in GridPay.Rows)
            {
                if (row.Cells["Price"].Value != null)
                {
                    // Ensure the price is correctly parsed as a decimal
                    decimal price;
                    if (decimal.TryParse(row.Cells["Price"].Value.ToString(), out price))
                    {
                        totalAmount += price;
                    }
                }
            }
            TxtTotalAmount.Text = totalAmount.ToString("0.00");
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {

            //currentSessionData.Clear();
            //GridPay.DataSource = null;
            GridPay.Refresh();

            // Check if GridPay is empty
            if (GridPay.Rows.Count == 0 || GridPay.Rows.Cast<DataGridViewRow>().All(row => row.Cells["ProductID"].Value == null))
            {
                MessageBox.Show("Please enter data into the grid before proceeding.", "Empty Grid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Prompt user to add a customer
            var result = MessageBox.Show("Do you want to add a customer?", "Add Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           // bool includeCustomerDetails = false;

            if (result == DialogResult.Yes)
            {
                // Show the customer form and wait for the user to select a customer
                Customer customerForm = new Customer();
                customerForm.ShowDialog();

                // Check if a customer was selected; if not, handle accordingly
                if (Customer.SelectedCustomerId == null)
                {
                    MessageBox.Show("No customer selected. Please select a customer to proceed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
               // includeCustomerDetails = true;
            }

            // Generate the receipt text with customer details
            string receiptText = GenerateReceipt();

            // Save the receipt to a file and get the file path
            string filePath = SaveReceiptToFile(receiptText);

            // Open the receipt in Notepad if filePath is valid
            if (!string.IsNullOrEmpty(filePath))
            {
                try
                {
                    // Open the receipt in Notepad
                    System.Diagnostics.Process.Start("notepad.exe", filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening Notepad: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Optionally, clear the GridPay and other relevant fields if needed
           // GridPay.Rows.Clear();

            currentSessionData.Clear();
           // GridPay.DataSource = null;
           // ClearGridPayData();
            //currentOrderNo++;
            TID = 1;
            TxtTotalAmount.Text = "0.00";
            TxtProductID.Text = string.Empty;
            TxtProductName.Text = string.Empty;
            CmbType.SelectedIndex = 0;
            TxtPrice.Text = string.Empty;
            NUDQuantity.Value = 0;
            currentOrderNo = GetLatestOrderNo() + 1;
            //if (DateTime.Today > lastOrderDate)
            //{
            //    currentOrderNo = 1; // Reset OrderNo for the next day
            //    lastOrderDate = DateTime.Today;
            //}

        }
        private void ClearGridPayData()
        {
            // Preserve column structure
            DataGridViewColumnCollection columns = GridPay.Columns;
            DataTable dt = new DataTable();

            // Re-add columns to the new DataTable
            foreach (DataGridViewColumn column in columns)
            {
                dt.Columns.Add(column.HeaderText, typeof(string));  // Or use appropriate type
            }

            // Set the new DataTable as the DataSource
            GridPay.DataSource = dt;
        }


        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void TxtTotalAmount_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalAmount();
        }


        private string GenerateReceipt()
        {
            string receipt = "Receipt\n\n";
            string cafeName = "Magnor Cafe";
            int receiptWidth = 100; // Adjust the width according to your needs
            string borderChar = "="; // Character to create a border around the cafe name

            // Add space and border before the cafe name
            int padding = (receiptWidth - cafeName.Length) / 2;
            receipt += new string(borderChar[0], receiptWidth) + "\n"; // Top border
            receipt += new string(' ', padding) + cafeName + "\n"; // Cafe name centered
            receipt += new string(borderChar[0], receiptWidth) + "\n\n"; // Bottom border
            // Define column widths
            int columnWidthID = 10;
            int columnWidthName = 30;
            int columnWidthType = 15;
            int columnWidthQuantity = 5;
            int columnWidthPrice = 10;
            int columnWidthTime = 29;

            // Add customer details if available
            if (Customer.SelectedCustomerId != null)
            {
                receipt += string.Format("Customer ID: {0}\n", Customer.SelectedCustomerId);
                receipt += string.Format("Customer Name: {0}\n\n", Customer.SelectedCustomerName);
            }

            // Header
            receipt += string.Format("{0,-" + columnWidthID + "}{1,-" + columnWidthName + "}{2,-" + columnWidthType + "}{3,-" + columnWidthQuantity + "}{4, -" + columnWidthPrice + "}{5,-" + columnWidthTime + "}\n",
                                     "Product ID ", "  Product Name", "Type", "Quantity ", " Price (PKR)", "      Order Time");
            receipt += new string('-', columnWidthID + columnWidthName + columnWidthType + columnWidthQuantity + columnWidthPrice + columnWidthTime) + "\n";

            // Body
            foreach (DataGridViewRow row in GridPay.Rows)
            {
                if (row.Cells["ProductID"].Value != null)
                {
                    string productID = row.Cells["ProductID"].Value.ToString();
                    string productName = row.Cells["ProductName"].Value.ToString();
                    string type = row.Cells["Type"].Value.ToString();
                    string quantity = row.Cells["Quantity"].Value.ToString();
                    string price = row.Cells["Price"].Value.ToString();
                    string orderTime = row.Cells["OrderTime"].Value.ToString();

                    // Ensure that text fits within the column width
                    productName = productName.Length > columnWidthName ? productName.Substring(0, columnWidthName) : productName;
                    receipt += string.Format("{0,-" + columnWidthID + "}{1,-" + columnWidthName + "}{2,-" + columnWidthType + "}{3," + columnWidthQuantity + "}{4," + columnWidthPrice + "}{5," + columnWidthTime + "}\n",
                         productID,
                         productName.PadRight(columnWidthName),
                         type.PadRight(columnWidthType),
                         quantity.PadLeft(columnWidthQuantity),
                         price.PadLeft(columnWidthPrice),
                         orderTime.PadLeft(columnWidthTime)); // Include orderTime here

                }
            }


            // Footer
            receipt += new string('-', columnWidthID + columnWidthName + columnWidthType + columnWidthQuantity + columnWidthPrice + columnWidthTime) + "\n";
            receipt += string.Format("Total Amount: {0, -" + (columnWidthPrice + 1) + "}PKR\n", TxtTotalAmount.Text);
            receipt += "Thank you for your purchase!";

            return receipt; // Return the receipt as a string
        }

        private string SaveReceiptToFile(string receiptText)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (.txt)|*.txt|All Files (.)|.";
                saveFileDialog.Title = "Save Receipt";
                saveFileDialog.FileName = "Receipt_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Write the receipt text to the file
                        System.IO.File.WriteAllText(saveFileDialog.FileName, receiptText);
                        MessageBox.Show("Receipt saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return saveFileDialog.FileName; // Return the file path to open in Notepad
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving receipt: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return null; // Return null if saving fails
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (GridPay.CurrentCell == null || GridPay.CurrentCell.RowIndex < 0)
            {
                MessageBox.Show("No row selected.");
                return;
            }

            // Get the index and TransitionID of the selected row
            int selectedIndex = GridPay.CurrentCell.RowIndex;
            int selectedTransitionID = Convert.ToInt32(GridPay.Rows[selectedIndex].Cells["TransitionID"].Value);

            // Remove the selected row from the database
            using (MySqlConnection MyConnection = new MySqlConnection(MyConString))
            {
                MyConnection.Open();

                // Delete the selected row from the database
                MySqlCommand deleteCommand = new MySqlCommand("DELETE FROM customer_order WHERE TransitionID = @TransitionID", MyConnection);
                deleteCommand.Parameters.AddWithValue("@TransitionID", selectedTransitionID);
                deleteCommand.ExecuteNonQuery();

                // Update the TransitionID for all records with TransitionID greater than the deleted one
                MySqlCommand updateCommand = new MySqlCommand("UPDATE customer_order SET TransitionID = TransitionID - 1 WHERE TransitionID > @TransitionID", MyConnection);
                updateCommand.Parameters.AddWithValue("@TransitionID", selectedTransitionID);
                updateCommand.ExecuteNonQuery();
            }

            // Remove the selected row from GridPay
            GridPay.Rows.RemoveAt(selectedIndex);

            // Adjust the TransitionID for the remaining rows in GridPay
            for (int i = selectedIndex; i < GridPay.Rows.Count; i++)
            {
                // Decrement TransitionID in GridPay
                int currentTransitionID = Convert.ToInt32(GridPay.Rows[i].Cells["TransitionID"].Value);
                GridPay.Rows[i].Cells["TransitionID"].Value = currentTransitionID - 1;
            }

            // Recalculate the total amount after removing the row
            CalculateTotalAmount();

            // Reload the updated data into GridPay from the database
            //LoadUpdatedData();

            MessageBox.Show("Row removed and TransitionIDs adjusted.");
        }

    }  
}

