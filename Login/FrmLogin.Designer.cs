namespace UI
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.txtBox_Login_User = new System.Windows.Forms.TextBox();
            this.lbl_Login_User = new System.Windows.Forms.Label();
            this.lbl_Login_Password = new System.Windows.Forms.Label();
            this.txtBox_Login_Password = new System.Windows.Forms.TextBox();
            this.btn_Login_Login = new System.Windows.Forms.Button();
            this.lbl_Login_CreateAccount = new System.Windows.Forms.Label();
            this.lnkLbl_CreateAccount = new System.Windows.Forms.LinkLabel();
            this.Btn_LoginExit = new System.Windows.Forms.Button();
            this.Lbl_LoginError = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtBox_Login_User
            // 
            this.txtBox_Login_User.Location = new System.Drawing.Point(300, 70);
            this.txtBox_Login_User.Name = "txtBox_Login_User";
            this.txtBox_Login_User.PlaceholderText = "Enter the user name";
            this.txtBox_Login_User.Size = new System.Drawing.Size(277, 23);
            this.txtBox_Login_User.TabIndex = 0;
            this.txtBox_Login_User.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_Login_User.TextChanged += new System.EventHandler(this.txtBox_Login_User_TextChanged);
            this.txtBox_Login_User.MouseHover += new System.EventHandler(this.txtBox_Login_User_MouseHover);
            // 
            // lbl_Login_User
            // 
            this.lbl_Login_User.AutoSize = true;
            this.lbl_Login_User.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Login_User.Location = new System.Drawing.Point(210, 72);
            this.lbl_Login_User.Name = "lbl_Login_User";
            this.lbl_Login_User.Size = new System.Drawing.Size(42, 21);
            this.lbl_Login_User.TabIndex = 1;
            this.lbl_Login_User.Text = "User";
            // 
            // lbl_Login_Password
            // 
            this.lbl_Login_Password.AutoSize = true;
            this.lbl_Login_Password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Login_Password.Location = new System.Drawing.Point(210, 115);
            this.lbl_Login_Password.Name = "lbl_Login_Password";
            this.lbl_Login_Password.Size = new System.Drawing.Size(82, 21);
            this.lbl_Login_Password.TabIndex = 3;
            this.lbl_Login_Password.Text = "Password";
            // 
            // txtBox_Login_Password
            // 
            this.txtBox_Login_Password.Location = new System.Drawing.Point(300, 113);
            this.txtBox_Login_Password.Name = "txtBox_Login_Password";
            this.txtBox_Login_Password.PasswordChar = '*';
            this.txtBox_Login_Password.PlaceholderText = "Password";
            this.txtBox_Login_Password.Size = new System.Drawing.Size(277, 23);
            this.txtBox_Login_Password.TabIndex = 2;
            this.txtBox_Login_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_Login_Password.UseSystemPasswordChar = true;
            this.txtBox_Login_Password.TextChanged += new System.EventHandler(this.txtBox_Login_Password_TextChanged);
            this.txtBox_Login_Password.MouseHover += new System.EventHandler(this.txtBox_Login_Password_MouseHover);
            // 
            // btn_Login_Login
            // 
            this.btn_Login_Login.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Login_Login.Location = new System.Drawing.Point(389, 155);
            this.btn_Login_Login.Name = "btn_Login_Login";
            this.btn_Login_Login.Size = new System.Drawing.Size(75, 25);
            this.btn_Login_Login.TabIndex = 4;
            this.btn_Login_Login.Text = "Log in";
            this.btn_Login_Login.UseVisualStyleBackColor = true;
            this.btn_Login_Login.Click += new System.EventHandler(this.Btn_Login_Login_Click);
            this.btn_Login_Login.MouseHover += new System.EventHandler(this.btn_Login_Login_MouseHover);
            // 
            // lbl_Login_CreateAccount
            // 
            this.lbl_Login_CreateAccount.AutoSize = true;
            this.lbl_Login_CreateAccount.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Login_CreateAccount.Location = new System.Drawing.Point(6, 346);
            this.lbl_Login_CreateAccount.Name = "lbl_Login_CreateAccount";
            this.lbl_Login_CreateAccount.Size = new System.Drawing.Size(176, 17);
            this.lbl_Login_CreateAccount.TabIndex = 5;
            this.lbl_Login_CreateAccount.Text = "Don\'t you have an account?";
            // 
            // lnkLbl_CreateAccount
            // 
            this.lnkLbl_CreateAccount.AutoSize = true;
            this.lnkLbl_CreateAccount.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lnkLbl_CreateAccount.Location = new System.Drawing.Point(188, 346);
            this.lnkLbl_CreateAccount.Name = "lnkLbl_CreateAccount";
            this.lnkLbl_CreateAccount.Size = new System.Drawing.Size(163, 17);
            this.lnkLbl_CreateAccount.TabIndex = 6;
            this.lnkLbl_CreateAccount.TabStop = true;
            this.lnkLbl_CreateAccount.Text = "Create an account today!";
            this.lnkLbl_CreateAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLbl_CreateAccount_LinkClicked);
            this.lnkLbl_CreateAccount.MouseHover += new System.EventHandler(this.lnkLbl_CreateAccount_MouseHover);
            // 
            // Btn_LoginExit
            // 
            this.Btn_LoginExit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_LoginExit.Location = new System.Drawing.Point(389, 186);
            this.Btn_LoginExit.Name = "Btn_LoginExit";
            this.Btn_LoginExit.Size = new System.Drawing.Size(75, 23);
            this.Btn_LoginExit.TabIndex = 7;
            this.Btn_LoginExit.Text = "Exit";
            this.Btn_LoginExit.UseVisualStyleBackColor = true;
            this.Btn_LoginExit.Click += new System.EventHandler(this.Btn_LoginExit_Click);
            this.Btn_LoginExit.MouseHover += new System.EventHandler(this.Btn_LoginExit_MouseHover);
            // 
            // Lbl_LoginError
            // 
            this.Lbl_LoginError.AutoSize = true;
            this.Lbl_LoginError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_LoginError.ForeColor = System.Drawing.Color.IndianRed;
            this.Lbl_LoginError.Location = new System.Drawing.Point(300, 33);
            this.Lbl_LoginError.Name = "Lbl_LoginError";
            this.Lbl_LoginError.Size = new System.Drawing.Size(286, 15);
            this.Lbl_LoginError.TabIndex = 8;
            this.Lbl_LoginError.Text = "This combination of User / Password doesn\'t exist.";
            this.Lbl_LoginError.Visible = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 368);
            this.Controls.Add(this.Lbl_LoginError);
            this.Controls.Add(this.Btn_LoginExit);
            this.Controls.Add(this.lnkLbl_CreateAccount);
            this.Controls.Add(this.lbl_Login_CreateAccount);
            this.Controls.Add(this.btn_Login_Login);
            this.Controls.Add(this.lbl_Login_Password);
            this.Controls.Add(this.txtBox_Login_Password);
            this.Controls.Add(this.lbl_Login_User);
            this.Controls.Add(this.txtBox_Login_User);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_Login_User;
        private System.Windows.Forms.Label lbl_Login_User;
        private System.Windows.Forms.Label lbl_Login_Password;
        private System.Windows.Forms.TextBox txtBox_Login_Password;
        private System.Windows.Forms.Button btn_Login_Login;
        private System.Windows.Forms.Label lbl_Login_CreateAccount;
        private System.Windows.Forms.LinkLabel lnkLbl_CreateAccount;
        private System.Windows.Forms.Button Btn_LoginExit;
        private System.Windows.Forms.Label Lbl_LoginError;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
