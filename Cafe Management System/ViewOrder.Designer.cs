namespace Cafe_Management_System
{
    partial class ViewOrder
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
            this.PnlViewOrder = new System.Windows.Forms.Panel();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.GridViewOrder = new System.Windows.Forms.DataGridView();
            this.LblSearch = new System.Windows.Forms.Label();
            this.LblViewOrder = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.PnlViewOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlViewOrder
            // 
            this.PnlViewOrder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PnlViewOrder.Controls.Add(this.BtnSearch);
            this.PnlViewOrder.Controls.Add(this.GridViewOrder);
            this.PnlViewOrder.Controls.Add(this.LblSearch);
            this.PnlViewOrder.Controls.Add(this.LblViewOrder);
            this.PnlViewOrder.Controls.Add(this.TxtSearch);
            this.PnlViewOrder.Location = new System.Drawing.Point(12, 12);
            this.PnlViewOrder.Name = "PnlViewOrder";
            this.PnlViewOrder.Size = new System.Drawing.Size(1052, 672);
            this.PnlViewOrder.TabIndex = 1;
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(92)))), ((int)(((byte)(84)))));
            this.BtnSearch.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSearch.Location = new System.Drawing.Point(712, 34);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(151, 38);
            this.BtnSearch.TabIndex = 18;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // GridViewOrder
            // 
            this.GridViewOrder.AllowUserToAddRows = false;
            this.GridViewOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(92)))), ((int)(((byte)(84)))));
            this.GridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewOrder.Location = new System.Drawing.Point(15, 99);
            this.GridViewOrder.Name = "GridViewOrder";
            this.GridViewOrder.Size = new System.Drawing.Size(1022, 554);
            this.GridViewOrder.TabIndex = 1;
            // 
            // LblSearch
            // 
            this.LblSearch.AutoSize = true;
            this.LblSearch.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSearch.Location = new System.Drawing.Point(314, 44);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(75, 18);
            this.LblSearch.TabIndex = 17;
            this.LblSearch.Text = "Search:";
            // 
            // LblViewOrder
            // 
            this.LblViewOrder.AutoSize = true;
            this.LblViewOrder.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblViewOrder.Location = new System.Drawing.Point(57, 44);
            this.LblViewOrder.Name = "LblViewOrder";
            this.LblViewOrder.Size = new System.Drawing.Size(99, 18);
            this.LblViewOrder.TabIndex = 0;
            this.LblViewOrder.Text = "View Order";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearch.Location = new System.Drawing.Point(395, 41);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(273, 24);
            this.TxtSearch.TabIndex = 16;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // ViewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 750);
            this.Controls.Add(this.PnlViewOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(292, 0);
            this.Name = "ViewOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ViewOrder";
            this.Load += new System.EventHandler(this.ViewOrder_Load);
            this.PnlViewOrder.ResumeLayout(false);
            this.PnlViewOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlViewOrder;
        private System.Windows.Forms.DataGridView GridViewOrder;
        private System.Windows.Forms.Label LblViewOrder;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label LblSearch;
        private System.Windows.Forms.TextBox TxtSearch;
    }
}