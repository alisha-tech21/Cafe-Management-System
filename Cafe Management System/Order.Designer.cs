namespace Cafe_Management_System
{
    partial class Order
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
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.GridMenu = new System.Windows.Forms.DataGridView();
            this.LblMenu = new System.Windows.Forms.Label();
            this.PnlPay = new System.Windows.Forms.Panel();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnOrder = new System.Windows.Forms.Button();
            this.TxtTotalAmount = new System.Windows.Forms.TextBox();
            this.LblTotalAmount = new System.Windows.Forms.Label();
            this.GridPay = new System.Windows.Forms.DataGridView();
            this.PnlOrder = new System.Windows.Forms.Panel();
            this.TxtProductID = new System.Windows.Forms.TextBox();
            this.LblProductID = new System.Windows.Forms.Label();
            this.NUDQuantity = new System.Windows.Forms.NumericUpDown();
            this.LblQuantity = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnAddToCart = new System.Windows.Forms.Button();
            this.LblSearch = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.LblPrice = new System.Windows.Forms.Label();
            this.CmbType = new System.Windows.Forms.ComboBox();
            this.TxtProductName = new System.Windows.Forms.TextBox();
            this.LblProductName = new System.Windows.Forms.Label();
            this.LblType = new System.Windows.Forms.Label();
            this.PnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridMenu)).BeginInit();
            this.PnlPay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPay)).BeginInit();
            this.PnlOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlMenu
            // 
            this.PnlMenu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PnlMenu.Controls.Add(this.GridMenu);
            this.PnlMenu.Controls.Add(this.LblMenu);
            this.PnlMenu.Location = new System.Drawing.Point(7, 12);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(633, 377);
            this.PnlMenu.TabIndex = 1;
            // 
            // GridMenu
            // 
            this.GridMenu.AllowUserToAddRows = false;
            this.GridMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridMenu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(92)))), ((int)(((byte)(84)))));
            this.GridMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMenu.Location = new System.Drawing.Point(10, 40);
            this.GridMenu.Name = "GridMenu";
            this.GridMenu.Size = new System.Drawing.Size(612, 323);
            this.GridMenu.TabIndex = 1;
            this.GridMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridMenu_CellClick);
            // 
            // LblMenu
            // 
            this.LblMenu.AutoSize = true;
            this.LblMenu.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMenu.Location = new System.Drawing.Point(13, 9);
            this.LblMenu.Name = "LblMenu";
            this.LblMenu.Size = new System.Drawing.Size(52, 18);
            this.LblMenu.TabIndex = 0;
            this.LblMenu.Text = "Menu";
            // 
            // PnlPay
            // 
            this.PnlPay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PnlPay.Controls.Add(this.BtnRemove);
            this.PnlPay.Controls.Add(this.BtnOrder);
            this.PnlPay.Controls.Add(this.TxtTotalAmount);
            this.PnlPay.Controls.Add(this.LblTotalAmount);
            this.PnlPay.Controls.Add(this.GridPay);
            this.PnlPay.Location = new System.Drawing.Point(656, 12);
            this.PnlPay.Name = "PnlPay";
            this.PnlPay.Size = new System.Drawing.Size(408, 687);
            this.PnlPay.TabIndex = 2;
            // 
            // BtnRemove
            // 
            this.BtnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(92)))), ((int)(((byte)(84)))));
            this.BtnRemove.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnRemove.Location = new System.Drawing.Point(139, 513);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(155, 42);
            this.BtnRemove.TabIndex = 15;
            this.BtnRemove.Text = "Remove";
            this.BtnRemove.UseVisualStyleBackColor = false;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnOrder
            // 
            this.BtnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(92)))), ((int)(((byte)(84)))));
            this.BtnOrder.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnOrder.Location = new System.Drawing.Point(139, 564);
            this.BtnOrder.Name = "BtnOrder";
            this.BtnOrder.Size = new System.Drawing.Size(155, 42);
            this.BtnOrder.TabIndex = 13;
            this.BtnOrder.Text = "Order";
            this.BtnOrder.UseVisualStyleBackColor = false;
            this.BtnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // TxtTotalAmount
            // 
            this.TxtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalAmount.Location = new System.Drawing.Point(196, 445);
            this.TxtTotalAmount.Name = "TxtTotalAmount";
            this.TxtTotalAmount.Size = new System.Drawing.Size(141, 24);
            this.TxtTotalAmount.TabIndex = 8;
            this.TxtTotalAmount.TextChanged += new System.EventHandler(this.TxtTotalAmount_TextChanged);
            // 
            // LblTotalAmount
            // 
            this.LblTotalAmount.AutoSize = true;
            this.LblTotalAmount.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalAmount.Location = new System.Drawing.Point(65, 448);
            this.LblTotalAmount.Name = "LblTotalAmount";
            this.LblTotalAmount.Size = new System.Drawing.Size(125, 18);
            this.LblTotalAmount.TabIndex = 1;
            this.LblTotalAmount.Text = "Total Amount:";
            // 
            // GridPay
            // 
            this.GridPay.AllowUserToAddRows = false;
            this.GridPay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridPay.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(92)))), ((int)(((byte)(84)))));
            this.GridPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPay.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(92)))), ((int)(((byte)(84)))));
            this.GridPay.Location = new System.Drawing.Point(11, 21);
            this.GridPay.Name = "GridPay";
            this.GridPay.Size = new System.Drawing.Size(385, 380);
            this.GridPay.TabIndex = 0;
            // 
            // PnlOrder
            // 
            this.PnlOrder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PnlOrder.Controls.Add(this.TxtProductID);
            this.PnlOrder.Controls.Add(this.LblProductID);
            this.PnlOrder.Controls.Add(this.NUDQuantity);
            this.PnlOrder.Controls.Add(this.LblQuantity);
            this.PnlOrder.Controls.Add(this.BtnSearch);
            this.PnlOrder.Controls.Add(this.BtnClear);
            this.PnlOrder.Controls.Add(this.BtnAddToCart);
            this.PnlOrder.Controls.Add(this.LblSearch);
            this.PnlOrder.Controls.Add(this.TxtSearch);
            this.PnlOrder.Controls.Add(this.TxtPrice);
            this.PnlOrder.Controls.Add(this.LblPrice);
            this.PnlOrder.Controls.Add(this.CmbType);
            this.PnlOrder.Controls.Add(this.TxtProductName);
            this.PnlOrder.Controls.Add(this.LblProductName);
            this.PnlOrder.Controls.Add(this.LblType);
            this.PnlOrder.Location = new System.Drawing.Point(7, 406);
            this.PnlOrder.Name = "PnlOrder";
            this.PnlOrder.Size = new System.Drawing.Size(633, 293);
            this.PnlOrder.TabIndex = 3;
            // 
            // TxtProductID
            // 
            this.TxtProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProductID.Location = new System.Drawing.Point(146, 24);
            this.TxtProductID.Name = "TxtProductID";
            this.TxtProductID.Size = new System.Drawing.Size(141, 24);
            this.TxtProductID.TabIndex = 22;
            // 
            // LblProductID
            // 
            this.LblProductID.AutoSize = true;
            this.LblProductID.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProductID.Location = new System.Drawing.Point(38, 30);
            this.LblProductID.Name = "LblProductID";
            this.LblProductID.Size = new System.Drawing.Size(102, 18);
            this.LblProductID.TabIndex = 21;
            this.LblProductID.Text = "Product ID:";
            // 
            // NUDQuantity
            // 
            this.NUDQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDQuantity.Location = new System.Drawing.Point(146, 194);
            this.NUDQuantity.Name = "NUDQuantity";
            this.NUDQuantity.Size = new System.Drawing.Size(141, 22);
            this.NUDQuantity.TabIndex = 20;
            // 
            // LblQuantity
            // 
            this.LblQuantity.AutoSize = true;
            this.LblQuantity.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuantity.Location = new System.Drawing.Point(55, 194);
            this.LblQuantity.Name = "LblQuantity";
            this.LblQuantity.Size = new System.Drawing.Size(85, 18);
            this.LblQuantity.TabIndex = 19;
            this.LblQuantity.Text = "Quantity:";
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(92)))), ((int)(((byte)(84)))));
            this.BtnSearch.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSearch.Location = new System.Drawing.Point(441, 160);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(151, 38);
            this.BtnSearch.TabIndex = 18;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(92)))), ((int)(((byte)(84)))));
            this.BtnClear.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnClear.Location = new System.Drawing.Point(240, 231);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(155, 42);
            this.BtnClear.TabIndex = 13;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnAddToCart
            // 
            this.BtnAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(92)))), ((int)(((byte)(84)))));
            this.BtnAddToCart.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddToCart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAddToCart.Location = new System.Drawing.Point(33, 231);
            this.BtnAddToCart.Name = "BtnAddToCart";
            this.BtnAddToCart.Size = new System.Drawing.Size(155, 42);
            this.BtnAddToCart.TabIndex = 12;
            this.BtnAddToCart.Text = "Add to Cart";
            this.BtnAddToCart.UseVisualStyleBackColor = false;
            this.BtnAddToCart.Click += new System.EventHandler(this.BtnAddToCart_Click);
            // 
            // LblSearch
            // 
            this.LblSearch.AutoSize = true;
            this.LblSearch.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSearch.Location = new System.Drawing.Point(453, 69);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(130, 36);
            this.LblSearch.TabIndex = 17;
            this.LblSearch.Text = "       Search \r\nProduct Name:";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearch.Location = new System.Drawing.Point(441, 119);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(151, 24);
            this.TxtSearch.TabIndex = 16;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // TxtPrice
            // 
            this.TxtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrice.Location = new System.Drawing.Point(146, 151);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(141, 24);
            this.TxtPrice.TabIndex = 9;
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrice.Location = new System.Drawing.Point(30, 154);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(110, 18);
            this.LblPrice.TabIndex = 8;
            this.LblPrice.Text = "Price (PKR):";
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
            this.CmbType.Location = new System.Drawing.Point(146, 108);
            this.CmbType.Name = "CmbType";
            this.CmbType.Size = new System.Drawing.Size(141, 24);
            this.CmbType.TabIndex = 6;
            // 
            // TxtProductName
            // 
            this.TxtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProductName.Location = new System.Drawing.Point(146, 66);
            this.TxtProductName.Name = "TxtProductName";
            this.TxtProductName.Size = new System.Drawing.Size(141, 24);
            this.TxtProductName.TabIndex = 5;
            // 
            // LblProductName
            // 
            this.LblProductName.AutoSize = true;
            this.LblProductName.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProductName.Location = new System.Drawing.Point(10, 69);
            this.LblProductName.Name = "LblProductName";
            this.LblProductName.Size = new System.Drawing.Size(130, 18);
            this.LblProductName.TabIndex = 3;
            this.LblProductName.Text = "Product Name:";
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblType.Location = new System.Drawing.Point(86, 111);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(54, 18);
            this.LblType.TabIndex = 2;
            this.LblType.Text = "Type:";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 750);
            this.Controls.Add(this.PnlOrder);
            this.Controls.Add(this.PnlPay);
            this.Controls.Add(this.PnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(292, 0);
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.PnlMenu.ResumeLayout(false);
            this.PnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridMenu)).EndInit();
            this.PnlPay.ResumeLayout(false);
            this.PnlPay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPay)).EndInit();
            this.PnlOrder.ResumeLayout(false);
            this.PnlOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.DataGridView GridMenu;
        private System.Windows.Forms.Label LblMenu;
        private System.Windows.Forms.Panel PnlPay;
        private System.Windows.Forms.DataGridView GridPay;
        private System.Windows.Forms.Panel PnlOrder;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label LblSearch;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnAddToCart;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.ComboBox CmbType;
        private System.Windows.Forms.TextBox TxtProductName;
        private System.Windows.Forms.Label LblProductName;
        private System.Windows.Forms.Label LblType;
        private System.Windows.Forms.Label LblTotalAmount;
        private System.Windows.Forms.NumericUpDown NUDQuantity;
        private System.Windows.Forms.Label LblQuantity;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnOrder;
        private System.Windows.Forms.TextBox TxtTotalAmount;
        private System.Windows.Forms.TextBox TxtProductID;
        private System.Windows.Forms.Label LblProductID;
    }
}