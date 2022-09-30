namespace UI
{
    partial class FrmAddClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddClient));
            this.TxtBox_Name = new System.Windows.Forms.TextBox();
            this.TxtBox_LastName = new System.Windows.Forms.TextBox();
            this.RdBttn_NonBinary = new System.Windows.Forms.RadioButton();
            this.RdBttn_Male = new System.Windows.Forms.RadioButton();
            this.RdBttn_Female = new System.Windows.Forms.RadioButton();
            this.grpBox_Gender = new System.Windows.Forms.GroupBox();
            this.NUD_Age = new System.Windows.Forms.NumericUpDown();
            this.lbl_age = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.Btn_PassengerCancel = new System.Windows.Forms.Button();
            this.Btn_PassengerAccept = new System.Windows.Forms.Button();
            this.lbl_DNI = new System.Windows.Forms.Label();
            this.TxtBox_DNI = new System.Windows.Forms.TextBox();
            this.GrpBox_Name = new System.Windows.Forms.GroupBox();
            this.Btn_RandomData = new System.Windows.Forms.Button();
            this.grpBox_Gender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Age)).BeginInit();
            this.GrpBox_Name.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtBox_Name
            // 
            this.TxtBox_Name.Location = new System.Drawing.Point(136, 26);
            this.TxtBox_Name.Name = "TxtBox_Name";
            this.TxtBox_Name.PlaceholderText = "Name";
            this.TxtBox_Name.Size = new System.Drawing.Size(294, 23);
            this.TxtBox_Name.TabIndex = 0;
            this.TxtBox_Name.TextChanged += new System.EventHandler(this.TxtBox_Name_TextChanged);
            // 
            // TxtBox_LastName
            // 
            this.TxtBox_LastName.Location = new System.Drawing.Point(136, 55);
            this.TxtBox_LastName.Name = "TxtBox_LastName";
            this.TxtBox_LastName.PlaceholderText = "Last Name";
            this.TxtBox_LastName.Size = new System.Drawing.Size(294, 23);
            this.TxtBox_LastName.TabIndex = 1;
            this.TxtBox_LastName.TextChanged += new System.EventHandler(this.TxtBox_LastName_TextChanged);
            // 
            // RdBttn_NonBinary
            // 
            this.RdBttn_NonBinary.AutoSize = true;
            this.RdBttn_NonBinary.Location = new System.Drawing.Point(35, 22);
            this.RdBttn_NonBinary.Name = "RdBttn_NonBinary";
            this.RdBttn_NonBinary.Size = new System.Drawing.Size(88, 21);
            this.RdBttn_NonBinary.TabIndex = 4;
            this.RdBttn_NonBinary.TabStop = true;
            this.RdBttn_NonBinary.Text = "Non Binary";
            this.RdBttn_NonBinary.UseVisualStyleBackColor = true;
            this.RdBttn_NonBinary.CheckedChanged += new System.EventHandler(this.RdBttn_NonBinary_CheckedChanged);
            // 
            // RdBttn_Male
            // 
            this.RdBttn_Male.AutoSize = true;
            this.RdBttn_Male.Location = new System.Drawing.Point(172, 22);
            this.RdBttn_Male.Name = "RdBttn_Male";
            this.RdBttn_Male.Size = new System.Drawing.Size(56, 21);
            this.RdBttn_Male.TabIndex = 5;
            this.RdBttn_Male.TabStop = true;
            this.RdBttn_Male.Text = "Male";
            this.RdBttn_Male.UseVisualStyleBackColor = true;
            this.RdBttn_Male.CheckedChanged += new System.EventHandler(this.RdBttn_Male_CheckedChanged);
            // 
            // RdBttn_Female
            // 
            this.RdBttn_Female.AutoSize = true;
            this.RdBttn_Female.Location = new System.Drawing.Point(290, 22);
            this.RdBttn_Female.Name = "RdBttn_Female";
            this.RdBttn_Female.Size = new System.Drawing.Size(70, 21);
            this.RdBttn_Female.TabIndex = 6;
            this.RdBttn_Female.TabStop = true;
            this.RdBttn_Female.Text = "Female";
            this.RdBttn_Female.UseVisualStyleBackColor = true;
            this.RdBttn_Female.CheckedChanged += new System.EventHandler(this.RdBttn_Female_CheckedChanged);
            // 
            // grpBox_Gender
            // 
            this.grpBox_Gender.Controls.Add(this.RdBttn_NonBinary);
            this.grpBox_Gender.Controls.Add(this.RdBttn_Female);
            this.grpBox_Gender.Controls.Add(this.RdBttn_Male);
            this.grpBox_Gender.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpBox_Gender.Location = new System.Drawing.Point(12, 200);
            this.grpBox_Gender.Name = "grpBox_Gender";
            this.grpBox_Gender.Size = new System.Drawing.Size(405, 60);
            this.grpBox_Gender.TabIndex = 5;
            this.grpBox_Gender.TabStop = false;
            this.grpBox_Gender.Text = "Gender";
            // 
            // NUD_Age
            // 
            this.NUD_Age.Location = new System.Drawing.Point(140, 157);
            this.NUD_Age.Name = "NUD_Age";
            this.NUD_Age.Size = new System.Drawing.Size(70, 23);
            this.NUD_Age.TabIndex = 3;
            this.NUD_Age.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_age.Location = new System.Drawing.Point(64, 163);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(40, 20);
            this.lbl_age.TabIndex = 7;
            this.lbl_age.Text = "Age";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Name.Location = new System.Drawing.Point(11, 25);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(75, 24);
            this.lbl_Name.TabIndex = 8;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_LastName.Location = new System.Drawing.Point(11, 54);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(120, 24);
            this.lbl_LastName.TabIndex = 9;
            this.lbl_LastName.Text = "Last Name";
            // 
            // Btn_PassengerCancel
            // 
            this.Btn_PassengerCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_PassengerCancel.Location = new System.Drawing.Point(12, 509);
            this.Btn_PassengerCancel.Name = "Btn_PassengerCancel";
            this.Btn_PassengerCancel.Size = new System.Drawing.Size(190, 71);
            this.Btn_PassengerCancel.TabIndex = 8;
            this.Btn_PassengerCancel.Text = "Cancel";
            this.Btn_PassengerCancel.UseVisualStyleBackColor = true;
            this.Btn_PassengerCancel.Click += new System.EventHandler(this.Btn_PassengerCancel_Click);
            // 
            // Btn_PassengerAccept
            // 
            this.Btn_PassengerAccept.Enabled = false;
            this.Btn_PassengerAccept.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_PassengerAccept.Location = new System.Drawing.Point(328, 509);
            this.Btn_PassengerAccept.Name = "Btn_PassengerAccept";
            this.Btn_PassengerAccept.Size = new System.Drawing.Size(190, 71);
            this.Btn_PassengerAccept.TabIndex = 9;
            this.Btn_PassengerAccept.Text = "Accept";
            this.Btn_PassengerAccept.UseVisualStyleBackColor = true;
            this.Btn_PassengerAccept.Click += new System.EventHandler(this.Btn_PassengerAccept_Click);
            // 
            // lbl_DNI
            // 
            this.lbl_DNI.AutoSize = true;
            this.lbl_DNI.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_DNI.Location = new System.Drawing.Point(64, 134);
            this.lbl_DNI.Name = "lbl_DNI";
            this.lbl_DNI.Size = new System.Drawing.Size(36, 20);
            this.lbl_DNI.TabIndex = 17;
            this.lbl_DNI.Text = "DNI";
            // 
            // TxtBox_DNI
            // 
            this.TxtBox_DNI.Location = new System.Drawing.Point(140, 128);
            this.TxtBox_DNI.Name = "TxtBox_DNI";
            this.TxtBox_DNI.PlaceholderText = "DNI";
            this.TxtBox_DNI.Size = new System.Drawing.Size(302, 23);
            this.TxtBox_DNI.TabIndex = 2;
            this.TxtBox_DNI.TextChanged += new System.EventHandler(this.TxtBox_DNI_TextChanged);
            // 
            // GrpBox_Name
            // 
            this.GrpBox_Name.Controls.Add(this.TxtBox_Name);
            this.GrpBox_Name.Controls.Add(this.TxtBox_LastName);
            this.GrpBox_Name.Controls.Add(this.lbl_Name);
            this.GrpBox_Name.Controls.Add(this.lbl_LastName);
            this.GrpBox_Name.Location = new System.Drawing.Point(12, 12);
            this.GrpBox_Name.Name = "GrpBox_Name";
            this.GrpBox_Name.Size = new System.Drawing.Size(458, 96);
            this.GrpBox_Name.TabIndex = 19;
            this.GrpBox_Name.TabStop = false;
            // 
            // Btn_RandomData
            // 
            this.Btn_RandomData.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_RandomData.BackgroundImage")));
            this.Btn_RandomData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_RandomData.Location = new System.Drawing.Point(488, 12);
            this.Btn_RandomData.Name = "Btn_RandomData";
            this.Btn_RandomData.Size = new System.Drawing.Size(29, 29);
            this.Btn_RandomData.TabIndex = 7;
            this.Btn_RandomData.UseVisualStyleBackColor = true;
            this.Btn_RandomData.Click += new System.EventHandler(this.Btn_RandomData_Click);
            // 
            // FrmAddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(517, 582);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_RandomData);
            this.Controls.Add(this.GrpBox_Name);
            this.Controls.Add(this.TxtBox_DNI);
            this.Controls.Add(this.lbl_DNI);
            this.Controls.Add(this.Btn_PassengerAccept);
            this.Controls.Add(this.Btn_PassengerCancel);
            this.Controls.Add(this.lbl_age);
            this.Controls.Add(this.NUD_Age);
            this.Controls.Add(this.grpBox_Gender);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "FrmAddClient";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.grpBox_Gender.ResumeLayout(false);
            this.grpBox_Gender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Age)).EndInit();
            this.GrpBox_Name.ResumeLayout(false);
            this.GrpBox_Name.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBox_Name;
        private System.Windows.Forms.TextBox TxtBox_LastName;
        private System.Windows.Forms.RadioButton RdBttn_NonBinary;
        private System.Windows.Forms.RadioButton RdBttn_Male;
        private System.Windows.Forms.RadioButton RdBttn_Female;
        private System.Windows.Forms.GroupBox grpBox_Gender;
        private System.Windows.Forms.NumericUpDown NUD_Age;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.Button Btn_PassengerCancel;
        private System.Windows.Forms.Button Btn_PassengerAccept;
        private System.Windows.Forms.Label lbl_DNI;
        private System.Windows.Forms.TextBox TxtBox_DNI;
        private System.Windows.Forms.GroupBox GrpBox_Name;
        private System.Windows.Forms.Button Btn_RandomData;
    }
}
