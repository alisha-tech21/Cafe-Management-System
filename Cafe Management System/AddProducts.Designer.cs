namespace Cafe_Management_System
{
    partial class AddProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlDataOfProduct = new System.Windows.Forms.Panel();
            this.GridAddProduct = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlAddProduct = new System.Windows.Forms.Panel();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.LblSearch = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.CmbStatus = new System.Windows.Forms.ComboBox();
            this.LblStatus = new System.Windows.Forms.Label();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.LblPrice = new System.Windows.Forms.Label();
            this.TxtStock = new System.Windows.Forms.TextBox();
            this.CmbType = new System.Windows.Forms.ComboBox();
            this.TxtProductName = new System.Windows.Forms.TextBox();
            this.LblProductName = new System.Windows.Forms.Label();
            this.LblType = new System.Windows.Forms.Label();
            this.LblStock = new System.Windows.Forms.Label();
            this.PnlDataOfProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridAddProduct)).BeginInit();
            this.PnlAddProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlDataOfProduct
            // 
            this.PnlDataOfProduct.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PnlDataOfProduct.Controls.Add(this.GridAddProduct);
            this.PnlDataOfProduct.Controls.Add(this.label1);
            this.PnlDataOfProduct.Location = new System.Drawing.Point(12, 12);
            this.PnlDataOfProduct.Name = "PnlDataOfProduct";
            this.PnlDataOfProduct.Size = new System.Drawing.Size(1052, 377);
            this.PnlDataOfProduct.TabIndex = 0;
            // 
            // GridAddProduct
            // 
            this.GridAddProduct.AllowUserToAddRows = false;
            this.GridAddProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridAddProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(92)))), ((int)(((byte)(84)))));
            this.GridAddProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAddProduct.Location = new System.Drawing.Point(16, 39);
            this.GridAddProduct.Name = "GridAddProduct";
            this.GridAddProduct.Size = new System.Drawing.Size(1022, 323);
            this.GridAddProduct.TabIndex = 1;
            this.GridAddProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridAddProduct_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data of Products";
            // 
            // PnlAddProduct
            // 
            this.PnlAddProduct.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PnlAddProduct.Controls.Add(this.BtnSearch);
            this.PnlAddProduct.Controls.Add(this.LblSearch);
            this.PnlAddProduct.Controls.Add(this.TxtSearch);
            this.PnlAddProduct.Controls.Add(this.BtnUpdate);
            this.PnlAddProduct.Controls.Add(this.BtnDelete);
            this.PnlAddProduct.Controls.Add(this.BtnClear);
            this.PnlAddProduct.Controls.Add(this.BtnAdd);
            this.PnlAddProduct.Controls.Add(this.CmbStatus);
            this.PnlAddProduct.Controls.Add(this.LblStatus);
            this.PnlAddProduct.Controls.Add(this.TxtPrice);
            this.PnlAddProduct.Controls.Add(this.LblPrice);
            this.PnlAddProduct.Controls.Add(this.TxtStock);
            this.PnlAddProduct.Controls.Add(this.CmbType);
            this.PnlAddProduct.Controls.Add(this.TxtProductName);
            this.PnlAddProduct.Controls.Add(this.LblProductName);
            this.PnlAddProduct.Controls.Add(this.LblType);
            this.PnlAddProduct.Controls.Add(this.LblStock);
            this.PnlAddProduct.Location = new System.Drawing.Point(12, 408);
            this.PnlAddProduct.Name = "PnlAddProduct";
            this.PnlAddProduct.Size = new System.Drawing.Size(1052, 291);
            this.PnlAddProduct.TabIndex = 1;
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(92)))), ((int)(((byte)(84)))));
            this.BtnSearch.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSearch.Location = new System.Drawing.Point(36, 136);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(151, 38);
            this.BtnSearch.TabIndex = 18;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // LblSearch
            // 
            this.LblSearch.AutoSize = true;
            this.LblSearch.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSearch.Location = new System.Drawing.Point(48, 45);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(130, 36);
            this.LblSearch.TabIndex = 17;
            this.LblSearch.Text = "       Search \r\nProduct Name:";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearch.Location = new System.Drawing.Point(36, 95);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(151, 24);
            this.TxtSearch.TabIndex = 16;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(92)))), ((int)(((byte)(84)))));
            this.BtnUpdate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnUpdate.Location = new System.Drawing.Point(538, 204);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(107, 42);
            this.BtnUpdate.TabIndex = 15;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(92)))), ((int)(((byte)(84)))));
            this.BtnDelete.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDelete.Location = new System.Drawing.Point(695, 204);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(107, 42);
            this.BtnDelete.TabIndex = 14;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(92)))), ((int)(((byte)(84)))));
            this.BtnClear.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnClear.Location = new System.Drawing.Point(844, 204);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(107, 42);
            this.BtnClear.TabIndex = 13;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(92)))), ((int)(((byte)(84)))));
            this.BtnAdd.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAdd.Location = new System.Drawing.Point(381, 204);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(107, 42);
            this.BtnAdd.TabIndex = 12;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // CmbStatus
            // 
            this.CmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbStatus.FormattingEnabled = true;
            this.CmbStatus.Items.AddRange(new object[] {
            "---Select Status---",
            "Available",
            "Unavailable"});
            this.CmbStatus.Location = new System.Drawing.Point(800, 136);
            this.CmbStatus.Name = "CmbStatus";
            this.CmbStatus.Size = new System.Drawing.Size(151, 24);
            this.CmbStatus.TabIndex = 11;
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStatus.Location = new System.Drawing.Point(726, 142);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(68, 18);
            this.LblStatus.TabIndex = 10;
            this.LblStatus.Text = "Status:";
            // 
            // TxtPrice
            // 
            this.TxtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrice.Location = new System.Drawing.Point(800, 92);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(151, 24);
            this.TxtPrice.TabIndex = 9;
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrice.Location = new System.Drawing.Point(684, 95);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(110, 18);
            this.LblPrice.TabIndex = 8;
            this.LblPrice.Text = "Price (PKR):";
            // 
            // TxtStock
            // 
            this.TxtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStock.Location = new System.Drawing.Point(800, 45);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(151, 24);
            this.TxtStock.TabIndex = 7;
            // 
            // CmbType
            // 
            this.CmbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbType.FormattingEnabled = true;
            this.CmbType.Items.AddRange(new object[] {
            "---Select Type---",
            "Coffee",
            "Tea",
            "Shakes",
            "Desserts",
            "Snacks ",
            "Mini Bites"});
            this.CmbType.Location = new System.Drawing.Point(420, 115);
            this.CmbType.Name = "CmbType";
            this.CmbType.Size = new System.Drawing.Size(151, 24);
            this.CmbType.TabIndex = 6;
            // 
            // TxtProductName
            // 
            this.TxtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProductName.Location = new System.Drawing.Point(420, 68);
            this.TxtProductName.Name = "TxtProductName";
            this.TxtProductName.Size = new System.Drawing.Size(151, 24);
            this.TxtProductName.TabIndex = 5;
            // 
            // LblProductName
            // 
            this.LblProductName.AutoSize = true;
            this.LblProductName.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProductName.Location = new System.Drawing.Point(284, 71);
            this.LblProductName.Name = "LblProductName";
            this.LblProductName.Size = new System.Drawing.Size(130, 18);
            this.LblProductName.TabIndex = 3;
            this.LblProductName.Text = "Product Name:";
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblType.Location = new System.Drawing.Point(360, 116);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(54, 18);
            this.LblType.TabIndex = 2;
            this.LblType.Text = "Type:";
            // 
            // LblStock
            // 
            this.LblStock.AutoSize = true;
            this.LblStock.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStock.Location = new System.Drawing.Point(734, 48);
            this.LblStock.Name = "LblStock";
            this.LblStock.Size = new System.Drawing.Size(60, 18);
            this.LblStock.TabIndex = 1;
            this.LblStock.Text = "Stock:";
            // 
            // AddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1076, 750);
            this.Controls.Add(this.PnlAddProduct);
            this.Controls.Add(this.PnlDataOfProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(292, 0);
            this.Name = "AddProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AddProducts";
            this.Load += new System.EventHandler(this.AddProducts_Load);
            this.PnlDataOfProduct.ResumeLayout(false);
            this.PnlDataOfProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridAddProduct)).EndInit();
            this.PnlAddProduct.ResumeLayout(false);
            this.PnlAddProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlDataOfProduct;
        private System.Windows.Forms.DataGridView GridAddProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PnlAddProduct;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.ComboBox CmbStatus;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.TextBox TxtStock;
        private System.Windows.Forms.ComboBox CmbType;
        private System.Windows.Forms.TextBox TxtProductName;
        private System.Windows.Forms.Label LblProductName;
        private System.Windows.Forms.Label LblType;
        private System.Windows.Forms.Label LblStock;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label LblSearch;
        private System.Windows.Forms.TextBox TxtSearch;
    }
}