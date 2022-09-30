namespace UI
{
    partial class FrmNewAgent
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
            this.GrpBox_NewAgent = new System.Windows.Forms.GroupBox();
            this.TxtBox_NewAgent_RealName = new System.Windows.Forms.TextBox();
            this.txtBox_NewAgent_Password = new System.Windows.Forms.TextBox();
            this.txtBox_NewAgent_Name = new System.Windows.Forms.TextBox();
            this.btn_NewAgent_Accept = new System.Windows.Forms.Button();
            this.btn_NewAgent_Cancel = new System.Windows.Forms.Button();
            this.GrpBox_NewAgent.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpBox_NewAgent
            // 
            this.GrpBox_NewAgent.Controls.Add(this.TxtBox_NewAgent_RealName);
            this.GrpBox_NewAgent.Controls.Add(this.txtBox_NewAgent_Password);
            this.GrpBox_NewAgent.Controls.Add(this.txtBox_NewAgent_Name);
            this.GrpBox_NewAgent.Location = new System.Drawing.Point(42, 28);
            this.GrpBox_NewAgent.Name = "GrpBox_NewAgent";
            this.GrpBox_NewAgent.Size = new System.Drawing.Size(408, 158);
            this.GrpBox_NewAgent.TabIndex = 0;
            this.GrpBox_NewAgent.TabStop = false;
            this.GrpBox_NewAgent.Text = "New Agent";
            // 
            // TxtBox_NewAgent_RealName
            // 
            this.TxtBox_NewAgent_RealName.Location = new System.Drawing.Point(102, 120);
            this.TxtBox_NewAgent_RealName.Name = "TxtBox_NewAgent_RealName";
            this.TxtBox_NewAgent_RealName.PlaceholderText = "Type new real name";
            this.TxtBox_NewAgent_RealName.Size = new System.Drawing.Size(232, 23);
            this.TxtBox_NewAgent_RealName.TabIndex = 4;
            this.TxtBox_NewAgent_RealName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBox_NewAgent_Password
            // 
            this.txtBox_NewAgent_Password.Location = new System.Drawing.Point(102, 80);
            this.txtBox_NewAgent_Password.Name = "txtBox_NewAgent_Password";
            this.txtBox_NewAgent_Password.PlaceholderText = "Type new password";
            this.txtBox_NewAgent_Password.Size = new System.Drawing.Size(232, 23);
            this.txtBox_NewAgent_Password.TabIndex = 3;
            this.txtBox_NewAgent_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBox_NewAgent_Name
            // 
            this.txtBox_NewAgent_Name.Location = new System.Drawing.Point(102, 33);
            this.txtBox_NewAgent_Name.Name = "txtBox_NewAgent_Name";
            this.txtBox_NewAgent_Name.PlaceholderText = "Type new user name";
            this.txtBox_NewAgent_Name.Size = new System.Drawing.Size(232, 23);
            this.txtBox_NewAgent_Name.TabIndex = 2;
            this.txtBox_NewAgent_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_NewAgent_Accept
            // 
            this.btn_NewAgent_Accept.Location = new System.Drawing.Point(257, 205);
            this.btn_NewAgent_Accept.Name = "btn_NewAgent_Accept";
            this.btn_NewAgent_Accept.Size = new System.Drawing.Size(242, 23);
            this.btn_NewAgent_Accept.TabIndex = 2;
            this.btn_NewAgent_Accept.Text = "Confirm";
            this.btn_NewAgent_Accept.UseVisualStyleBackColor = true;
            this.btn_NewAgent_Accept.Click += new System.EventHandler(this.Btn_NewAgent_Accept_Click);
            // 
            // btn_NewAgent_Cancel
            // 
            this.btn_NewAgent_Cancel.Location = new System.Drawing.Point(9, 205);
            this.btn_NewAgent_Cancel.Name = "btn_NewAgent_Cancel";
            this.btn_NewAgent_Cancel.Size = new System.Drawing.Size(242, 23);
            this.btn_NewAgent_Cancel.TabIndex = 3;
            this.btn_NewAgent_Cancel.Text = "Cancel";
            this.btn_NewAgent_Cancel.UseVisualStyleBackColor = true;
            this.btn_NewAgent_Cancel.Click += new System.EventHandler(this.Btn_NewAgent_Cancel_Click);
            // 
            // FrmNewAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(507, 236);
            this.ControlBox = false;
            this.Controls.Add(this.btn_NewAgent_Cancel);
            this.Controls.Add(this.btn_NewAgent_Accept);
            this.Controls.Add(this.GrpBox_NewAgent);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmNewAgent";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "New Agent";
            this.GrpBox_NewAgent.ResumeLayout(false);
            this.GrpBox_NewAgent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpBox_NewAgent;
        private System.Windows.Forms.TextBox txtBox_NewAgent_Password;
        private System.Windows.Forms.TextBox txtBox_NewAgent_Name;
        private System.Windows.Forms.Button btn_NewAgent_Accept;
        private System.Windows.Forms.Button btn_NewAgent_Cancel;
        private System.Windows.Forms.TextBox TxtBox_NewAgent_RealName;
    }
}