namespace Cafe_Management_System
{
    partial class Splash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.Piclogo = new System.Windows.Forms.PictureBox();
            this.Lblcafe = new System.Windows.Forms.Label();
            this.PnlSplash = new System.Windows.Forms.Panel();
            this.LblLoading = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Piclogo)).BeginInit();
            this.PnlSplash.SuspendLayout();
            this.SuspendLayout();
            // 
            // Piclogo
            // 
            this.Piclogo.BackColor = System.Drawing.Color.Honeydew;
            this.Piclogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Piclogo.BackgroundImage")));
            this.Piclogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Piclogo.Location = new System.Drawing.Point(162, 99);
            this.Piclogo.Name = "Piclogo";
            this.Piclogo.Size = new System.Drawing.Size(280, 232);
            this.Piclogo.TabIndex = 0;
            this.Piclogo.TabStop = false;
            // 
            // Lblcafe
            // 
            this.Lblcafe.AutoSize = true;
            this.Lblcafe.BackColor = System.Drawing.Color.Honeydew;
            this.Lblcafe.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblcafe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(82)))), ((int)(((byte)(68)))));
            this.Lblcafe.Location = new System.Drawing.Point(164, 334);
            this.Lblcafe.Name = "Lblcafe";
            this.Lblcafe.Size = new System.Drawing.Size(288, 25);
            this.Lblcafe.TabIndex = 1;
            this.Lblcafe.Text = "Welcome To Magnor Cafe";
            // 
            // PnlSplash
            // 
            this.PnlSplash.BackColor = System.Drawing.Color.Honeydew;
            this.PnlSplash.Controls.Add(this.LblLoading);
            this.PnlSplash.Controls.Add(this.progressBar1);
            this.PnlSplash.Location = new System.Drawing.Point(25, 25);
            this.PnlSplash.Name = "PnlSplash";
            this.PnlSplash.Size = new System.Drawing.Size(548, 416);
            this.PnlSplash.TabIndex = 2;
            // 
            // LblLoading
            // 
            this.LblLoading.AutoSize = true;
            this.LblLoading.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLoading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(82)))), ((int)(((byte)(68)))));
            this.LblLoading.Location = new System.Drawing.Point(240, 347);
            this.LblLoading.Name = "LblLoading";
            this.LblLoading.Size = new System.Drawing.Size(71, 23);
            this.LblLoading.TabIndex = 1;
            this.LblLoading.Text = "Loading...";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.progressBar1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.progressBar1.Location = new System.Drawing.Point(141, 373);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(280, 5);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(82)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(598, 466);
            this.Controls.Add(this.Lblcafe);
            this.Controls.Add(this.Piclogo);
            this.Controls.Add(this.PnlSplash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            ((System.ComponentModel.ISupportInitialize)(this.Piclogo)).EndInit();
            this.PnlSplash.ResumeLayout(false);
            this.PnlSplash.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Piclogo;
        private System.Windows.Forms.Label Lblcafe;
        private System.Windows.Forms.Panel PnlSplash;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label LblLoading;
    }
}