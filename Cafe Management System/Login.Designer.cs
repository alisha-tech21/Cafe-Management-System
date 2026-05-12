namespace Cafe_Management_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.PnlCLogin = new System.Windows.Forms.Panel();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.LblCAccount = new System.Windows.Forms.Label();
            this.LblCName = new System.Windows.Forms.Label();
            this.PicBoxClogin = new System.Windows.Forms.PictureBox();
            this.LblSignIn = new System.Windows.Forms.Label();
            this.LblUserName = new System.Windows.Forms.Label();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.ChkShowPassword = new System.Windows.Forms.CheckBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.PnlCLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxClogin)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlCLogin
            // 
            this.PnlCLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(92)))), ((int)(((byte)(84)))));
            this.PnlCLogin.Controls.Add(this.BtnRegister);
            this.PnlCLogin.Controls.Add(this.LblCAccount);
            this.PnlCLogin.Controls.Add(this.LblCName);
            this.PnlCLogin.Controls.Add(this.PicBoxClogin);
            this.PnlCLogin.Location = new System.Drawing.Point(0, 0);
            this.PnlCLogin.Name = "PnlCLogin";
            this.PnlCLogin.Size = new System.Drawing.Size(293, 466);
            this.PnlCLogin.TabIndex = 0;
            // 
            // BtnRegister
            // 
            this.BtnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(92)))), ((int)(((byte)(84)))));
            this.BtnRegister.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnRegister.Location = new System.Drawing.Point(25, 407);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(241, 40);
            this.BtnRegister.TabIndex = 3;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = false;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // LblCAccount
            // 
            this.LblCAccount.AutoSize = true;
            this.LblCAccount.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCAccount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblCAccount.Location = new System.Drawing.Point(74, 386);
            this.LblCAccount.Name = "LblCAccount";
            this.LblCAccount.Size = new System.Drawing.Size(147, 18);
            this.LblCAccount.TabIndex = 2;
            this.LblCAccount.Text = "Create an Account";
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
            // LblSignIn
            // 
            this.LblSignIn.AutoSize = true;
            this.LblSignIn.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSignIn.Location = new System.Drawing.Point(332, 60);
            this.LblSignIn.Name = "LblSignIn";
            this.LblSignIn.Size = new System.Drawing.Size(90, 23);
            this.LblSignIn.TabIndex = 1;
            this.LblSignIn.Text = "SIGN IN";
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblUserName.Location = new System.Drawing.Point(333, 127);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(99, 18);
            this.LblUserName.TabIndex = 3;
            this.LblUserName.Text = "User Name:";
            // 
            // TxtUserName
            // 
            this.TxtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserName.Location = new System.Drawing.Point(336, 148);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(224, 26);
            this.TxtUserName.TabIndex = 4;
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblPassword.Location = new System.Drawing.Point(333, 192);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(88, 18);
            this.LblPassword.TabIndex = 5;
            this.LblPassword.Text = "Password:";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(336, 213);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(224, 26);
            this.TxtPassword.TabIndex = 6;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // ChkShowPassword
            // 
            this.ChkShowPassword.AutoSize = true;
            this.ChkShowPassword.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkShowPassword.Location = new System.Drawing.Point(336, 245);
            this.ChkShowPassword.Name = "ChkShowPassword";
            this.ChkShowPassword.Size = new System.Drawing.Size(123, 19);
            this.ChkShowPassword.TabIndex = 7;
            this.ChkShowPassword.Text = "Show Password";
            this.ChkShowPassword.UseVisualStyleBackColor = true;
            this.ChkShowPassword.CheckedChanged += new System.EventHandler(this.ChkShowPassword_CheckedChanged);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(92)))), ((int)(((byte)(84)))));
            this.BtnLogin.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnLogin.Location = new System.Drawing.Point(336, 285);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(224, 40);
            this.BtnLogin.TabIndex = 8;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(598, 466);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.ChkShowPassword);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.LblUserName);
            this.Controls.Add(this.LblSignIn);
            this.Controls.Add(this.PnlCLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.PnlCLogin.ResumeLayout(false);
            this.PnlCLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxClogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlCLogin;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Label LblCAccount;
        private System.Windows.Forms.Label LblCName;
        private System.Windows.Forms.PictureBox PicBoxClogin;
        private System.Windows.Forms.Label LblSignIn;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.CheckBox ChkShowPassword;
        private System.Windows.Forms.Button BtnLogin;
    }
}

