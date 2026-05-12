namespace Cafe_Management_System
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.PnlCLogin = new System.Windows.Forms.Panel();
            this.BtnSignIn = new System.Windows.Forms.Button();
            this.LblAccount = new System.Windows.Forms.Label();
            this.LblCName = new System.Windows.Forms.Label();
            this.PicBoxClogin = new System.Windows.Forms.PictureBox();
            this.LblRegister = new System.Windows.Forms.Label();
            this.LblUserName = new System.Windows.Forms.Label();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.ChkShowPassword = new System.Windows.Forms.CheckBox();
            this.BtnSignUp = new System.Windows.Forms.Button();
            this.TxtConfirmPassword = new System.Windows.Forms.TextBox();
            this.LblConfirmPassword = new System.Windows.Forms.Label();
            this.PnlCLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxClogin)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlCLogin
            // 
            this.PnlCLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(92)))), ((int)(((byte)(84)))));
            this.PnlCLogin.Controls.Add(this.BtnSignIn);
            this.PnlCLogin.Controls.Add(this.LblAccount);
            this.PnlCLogin.Controls.Add(this.LblCName);
            this.PnlCLogin.Controls.Add(this.PicBoxClogin);
            this.PnlCLogin.Location = new System.Drawing.Point(0, 0);
            this.PnlCLogin.Name = "PnlCLogin";
            this.PnlCLogin.Size = new System.Drawing.Size(293, 466);
            this.PnlCLogin.TabIndex = 1;
            // 
            // BtnSignIn
            // 
            this.BtnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(92)))), ((int)(((byte)(84)))));
            this.BtnSignIn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSignIn.Location = new System.Drawing.Point(25, 407);
            this.BtnSignIn.Name = "BtnSignIn";
            this.BtnSignIn.Size = new System.Drawing.Size(241, 40);
            this.BtnSignIn.TabIndex = 3;
            this.BtnSignIn.Text = "Sign In";
            this.BtnSignIn.UseVisualStyleBackColor = false;
            this.BtnSignIn.Click += new System.EventHandler(this.BtnSignIn_Click);
            // 
            // LblAccount
            // 
            this.LblAccount.AutoSize = true;
            this.LblAccount.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAccount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblAccount.Location = new System.Drawing.Point(47, 386);
            this.LblAccount.Name = "LblAccount";
            this.LblAccount.Size = new System.Drawing.Size(205, 18);
            this.LblAccount.TabIndex = 2;
            this.LblAccount.Text = "Already have an Account?";
            // 
            // LblCName
            // 
            this.LblCName.AutoSize = true;
            this.LblCName.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblCName.Location = new System.Drawing.Point(49, 145);
            this.LblCName.Name = "LblCName";
            this.LblCName.Size = new System.Drawing.Size(192, 31);
            this.LblCName.TabIndex = 1;
            this.LblCName.Text = "Magnor Cafe";
            // 
            // PicBoxClogin
            // 
            this.PicBoxClogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PicBoxClogin.BackgroundImage")));
            this.PicBoxClogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBoxClogin.Location = new System.Drawing.Point(98, 60);
            this.PicBoxClogin.Name = "PicBoxClogin";
            this.PicBoxClogin.Size = new System.Drawing.Size(95, 82);
            this.PicBoxClogin.TabIndex = 0;
            this.PicBoxClogin.TabStop = false;
            // 
            // LblRegister
            // 
            this.LblRegister.AutoSize = true;
            this.LblRegister.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegister.Location = new System.Drawing.Point(332, 60);
            this.LblRegister.Name = "LblRegister";
            this.LblRegister.Size = new System.Drawing.Size(116, 23);
            this.LblRegister.TabIndex = 2;
            this.LblRegister.Text = "REGISTER";
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblUserName.Location = new System.Drawing.Point(333, 127);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(99, 18);
            this.LblUserName.TabIndex = 4;
            this.LblUserName.Text = "User Name:";
            // 
            // TxtUserName
            // 
            this.TxtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserName.Location = new System.Drawing.Point(336, 148);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(224, 26);
            this.TxtUserName.TabIndex = 5;
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblPassword.Location = new System.Drawing.Point(333, 192);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(88, 18);
            this.LblPassword.TabIndex = 6;
            this.LblPassword.Text = "Password:";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(336, 213);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(224, 26);
            this.TxtPassword.TabIndex = 7;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // ChkShowPassword
            // 
            this.ChkShowPassword.AutoSize = true;
            this.ChkShowPassword.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkShowPassword.Location = new System.Drawing.Point(336, 309);
            this.ChkShowPassword.Name = "ChkShowPassword";
            this.ChkShowPassword.Size = new System.Drawing.Size(123, 19);
            this.ChkShowPassword.TabIndex = 8;
            this.ChkShowPassword.Text = "Show Password";
            this.ChkShowPassword.UseVisualStyleBackColor = true;
            this.ChkShowPassword.CheckedChanged += new System.EventHandler(this.ChkShowPassword_CheckedChanged);
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(92)))), ((int)(((byte)(84)))));
            this.BtnSignUp.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignUp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSignUp.Location = new System.Drawing.Point(336, 343);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.Size = new System.Drawing.Size(224, 40);
            this.BtnSignUp.TabIndex = 9;
            this.BtnSignUp.Text = "Sign Up";
            this.BtnSignUp.UseVisualStyleBackColor = false;
            this.BtnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
            // 
            // TxtConfirmPassword
            // 
            this.TxtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConfirmPassword.Location = new System.Drawing.Point(336, 277);
            this.TxtConfirmPassword.Name = "TxtConfirmPassword";
            this.TxtConfirmPassword.Size = new System.Drawing.Size(224, 26);
            this.TxtConfirmPassword.TabIndex = 11;
            this.TxtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // LblConfirmPassword
            // 
            this.LblConfirmPassword.AutoSize = true;
            this.LblConfirmPassword.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConfirmPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblConfirmPassword.Location = new System.Drawing.Point(333, 256);
            this.LblConfirmPassword.Name = "LblConfirmPassword";
            this.LblConfirmPassword.Size = new System.Drawing.Size(156, 18);
            this.LblConfirmPassword.TabIndex = 10;
            this.LblConfirmPassword.Text = "Confirm Password:";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(599, 466);
            this.Controls.Add(this.TxtConfirmPassword);
            this.Controls.Add(this.LblConfirmPassword);
            this.Controls.Add(this.BtnSignUp);
            this.Controls.Add(this.ChkShowPassword);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.LblUserName);
            this.Controls.Add(this.LblRegister);
            this.Controls.Add(this.PnlCLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.PnlCLogin.ResumeLayout(false);
            this.PnlCLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxClogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlCLogin;
        private System.Windows.Forms.Button BtnSignIn;
        private System.Windows.Forms.Label LblAccount;
        private System.Windows.Forms.Label LblCName;
        private System.Windows.Forms.PictureBox PicBoxClogin;
        private System.Windows.Forms.Label LblRegister;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.CheckBox ChkShowPassword;
        private System.Windows.Forms.Button BtnSignUp;
        private System.Windows.Forms.TextBox TxtConfirmPassword;
        private System.Windows.Forms.Label LblConfirmPassword;
    }
}