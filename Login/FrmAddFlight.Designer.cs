namespace UI
{
    partial class FrmAddFlight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddFlight));
            this.Lbl_AddFlight = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmbBox_Plane = new System.Windows.Forms.ComboBox();
            this.Btn_FrmAddFlightAccept = new System.Windows.Forms.Button();
            this.GrpBox_Controls = new System.Windows.Forms.GroupBox();
            this.Btn_FrmAddFlightCancel = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.GrpBox_Destination = new System.Windows.Forms.GroupBox();
            this.RdoBttn_International = new System.Windows.Forms.RadioButton();
            this.RdoBttn_National = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CmboBox_Origin = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CmboBox_Destination = new System.Windows.Forms.ComboBox();
            this.Lbl_NewFlightError = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DTP_FlightStart = new System.Windows.Forms.DateTimePicker();
            this.GrpBox_FlightDeparture = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.GrpBox_Controls.SuspendLayout();
            this.GrpBox_Destination.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GrpBox_FlightDeparture.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_AddFlight
            // 
            this.Lbl_AddFlight.AutoSize = true;
            this.Lbl_AddFlight.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Lbl_AddFlight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_AddFlight.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_AddFlight.Location = new System.Drawing.Point(34, 12);
            this.Lbl_AddFlight.Name = "Lbl_AddFlight";
            this.Lbl_AddFlight.Size = new System.Drawing.Size(194, 44);
            this.Lbl_AddFlight.TabIndex = 0;
            this.Lbl_AddFlight.Text = "New Flight";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CmbBox_Plane);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(34, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 70);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SelectThis the plane";
            // 
            // CmbBox_Plane
            // 
            this.CmbBox_Plane.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBox_Plane.FormattingEnabled = true;
            this.CmbBox_Plane.Location = new System.Drawing.Point(28, 22);
            this.CmbBox_Plane.Name = "CmbBox_Plane";
            this.CmbBox_Plane.Size = new System.Drawing.Size(168, 25);
            this.CmbBox_Plane.TabIndex = 2;
            this.CmbBox_Plane.SelectedIndexChanged += new System.EventHandler(this.CmbBox_Plane_SelectedIndexChanged);
            // 
            // Btn_FrmAddFlightAccept
            // 
            this.Btn_FrmAddFlightAccept.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_FrmAddFlightAccept.Location = new System.Drawing.Point(139, 49);
            this.Btn_FrmAddFlightAccept.Name = "Btn_FrmAddFlightAccept";
            this.Btn_FrmAddFlightAccept.Size = new System.Drawing.Size(120, 40);
            this.Btn_FrmAddFlightAccept.TabIndex = 2;
            this.Btn_FrmAddFlightAccept.Text = "Accept";
            this.Btn_FrmAddFlightAccept.UseVisualStyleBackColor = true;
            this.Btn_FrmAddFlightAccept.Click += new System.EventHandler(this.Btn_FrmAddFlightAccept_Click);
            // 
            // GrpBox_Controls
            // 
            this.GrpBox_Controls.Controls.Add(this.Btn_FrmAddFlightCancel);
            this.GrpBox_Controls.Controls.Add(this.Btn_FrmAddFlightAccept);
            this.GrpBox_Controls.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GrpBox_Controls.Location = new System.Drawing.Point(640, 392);
            this.GrpBox_Controls.Name = "GrpBox_Controls";
            this.GrpBox_Controls.Size = new System.Drawing.Size(265, 104);
            this.GrpBox_Controls.TabIndex = 3;
            this.GrpBox_Controls.TabStop = false;
            // 
            // Btn_FrmAddFlightCancel
            // 
            this.Btn_FrmAddFlightCancel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_FrmAddFlightCancel.Location = new System.Drawing.Point(6, 49);
            this.Btn_FrmAddFlightCancel.Name = "Btn_FrmAddFlightCancel";
            this.Btn_FrmAddFlightCancel.Size = new System.Drawing.Size(120, 40);
            this.Btn_FrmAddFlightCancel.TabIndex = 3;
            this.Btn_FrmAddFlightCancel.Text = "Cancel";
            this.Btn_FrmAddFlightCancel.UseVisualStyleBackColor = true;
            this.Btn_FrmAddFlightCancel.Click += new System.EventHandler(this.Btn_FrmAddFlightCancel_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.richTextBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.ForeColor = System.Drawing.Color.Olive;
            this.richTextBox1.Location = new System.Drawing.Point(34, 190);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(355, 306);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // GrpBox_Destination
            // 
            this.GrpBox_Destination.Controls.Add(this.RdoBttn_International);
            this.GrpBox_Destination.Controls.Add(this.RdoBttn_National);
            this.GrpBox_Destination.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GrpBox_Destination.Location = new System.Drawing.Point(395, 152);
            this.GrpBox_Destination.Name = "GrpBox_Destination";
            this.GrpBox_Destination.Size = new System.Drawing.Size(198, 96);
            this.GrpBox_Destination.TabIndex = 5;
            this.GrpBox_Destination.TabStop = false;
            this.GrpBox_Destination.Text = "Flight Type";
            // 
            // RdoBttn_International
            // 
            this.RdoBttn_International.AutoSize = true;
            this.RdoBttn_International.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RdoBttn_International.Location = new System.Drawing.Point(18, 59);
            this.RdoBttn_International.Name = "RdoBttn_International";
            this.RdoBttn_International.Size = new System.Drawing.Size(108, 21);
            this.RdoBttn_International.TabIndex = 1;
            this.RdoBttn_International.TabStop = true;
            this.RdoBttn_International.Text = "International";
            this.RdoBttn_International.UseVisualStyleBackColor = true;
            this.RdoBttn_International.CheckedChanged += new System.EventHandler(this.RdoBttnInternational_CheckedChanged);
            // 
            // RdoBttn_National
            // 
            this.RdoBttn_National.AutoSize = true;
            this.RdoBttn_National.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RdoBttn_National.Location = new System.Drawing.Point(18, 21);
            this.RdoBttn_National.Name = "RdoBttn_National";
            this.RdoBttn_National.Size = new System.Drawing.Size(82, 21);
            this.RdoBttn_National.TabIndex = 0;
            this.RdoBttn_National.TabStop = true;
            this.RdoBttn_National.Text = "National";
            this.RdoBttn_National.UseVisualStyleBackColor = true;
            this.RdoBttn_National.CheckedChanged += new System.EventHandler(this.RdoBttnNational_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CmboBox_Origin);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(395, 266);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 62);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Origin";
            // 
            // CmboBox_Origin
            // 
            this.CmboBox_Origin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmboBox_Origin.FormattingEnabled = true;
            this.CmboBox_Origin.Location = new System.Drawing.Point(6, 22);
            this.CmboBox_Origin.Name = "CmboBox_Origin";
            this.CmboBox_Origin.Size = new System.Drawing.Size(188, 25);
            this.CmboBox_Origin.TabIndex = 0;
            this.CmboBox_Origin.SelectedIndexChanged += new System.EventHandler(this.CmboBox_Origin_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CmboBox_Destination);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(395, 347);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 62);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Destination";
            // 
            // CmboBox_Destination
            // 
            this.CmboBox_Destination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmboBox_Destination.FormattingEnabled = true;
            this.CmboBox_Destination.Location = new System.Drawing.Point(6, 22);
            this.CmboBox_Destination.Name = "CmboBox_Destination";
            this.CmboBox_Destination.Size = new System.Drawing.Size(188, 25);
            this.CmboBox_Destination.TabIndex = 0;
            this.CmboBox_Destination.SelectedIndexChanged += new System.EventHandler(this.CmboBox_Destination_SelectedIndexChanged);
            // 
            // Lbl_NewFlightError
            // 
            this.Lbl_NewFlightError.AutoSize = true;
            this.Lbl_NewFlightError.BackColor = System.Drawing.Color.LightGray;
            this.Lbl_NewFlightError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl_NewFlightError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Lbl_NewFlightError.ForeColor = System.Drawing.Color.Red;
            this.Lbl_NewFlightError.Location = new System.Drawing.Point(395, 429);
            this.Lbl_NewFlightError.Name = "Lbl_NewFlightError";
            this.Lbl_NewFlightError.Size = new System.Drawing.Size(55, 23);
            this.Lbl_NewFlightError.TabIndex = 8;
            this.Lbl_NewFlightError.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(719, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // DTP_FlightStart
            // 
            this.DTP_FlightStart.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.DTP_FlightStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_FlightStart.Location = new System.Drawing.Point(6, 38);
            this.DTP_FlightStart.MinDate = new System.DateTime(2022, 9, 19, 0, 0, 0, 0);
            this.DTP_FlightStart.Name = "DTP_FlightStart";
            this.DTP_FlightStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DTP_FlightStart.Size = new System.Drawing.Size(253, 22);
            this.DTP_FlightStart.TabIndex = 10;
            // 
            // GrpBox_FlightDeparture
            // 
            this.GrpBox_FlightDeparture.Controls.Add(this.DTP_FlightStart);
            this.GrpBox_FlightDeparture.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GrpBox_FlightDeparture.Location = new System.Drawing.Point(624, 199);
            this.GrpBox_FlightDeparture.Name = "GrpBox_FlightDeparture";
            this.GrpBox_FlightDeparture.Size = new System.Drawing.Size(265, 100);
            this.GrpBox_FlightDeparture.TabIndex = 11;
            this.GrpBox_FlightDeparture.TabStop = false;
            this.GrpBox_FlightDeparture.Text = "Flight Departure";
            // 
            // FrmAddFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 504);
            this.ControlBox = false;
            this.Controls.Add(this.GrpBox_FlightDeparture);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GrpBox_Controls);
            this.Controls.Add(this.Lbl_NewFlightError);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.GrpBox_Destination);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Lbl_AddFlight);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAddFlight";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmAddFlight_Load);
            this.groupBox1.ResumeLayout(false);
            this.GrpBox_Controls.ResumeLayout(false);
            this.GrpBox_Destination.ResumeLayout(false);
            this.GrpBox_Destination.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GrpBox_FlightDeparture.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_AddFlight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CmbBox_Plane;
        private System.Windows.Forms.Button Btn_FrmAddFlightAccept;
        private System.Windows.Forms.GroupBox GrpBox_Controls;
        private System.Windows.Forms.Button Btn_FrmAddFlightCancel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox GrpBox_Destination;
        private System.Windows.Forms.RadioButton RdoBttn_International;
        private System.Windows.Forms.RadioButton RdoBttn_National;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox CmboBox_Origin;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox CmboBox_Destination;
        private System.Windows.Forms.Label Lbl_NewFlightError;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker DTP_FlightStart;
        private System.Windows.Forms.GroupBox GrpBox_FlightDeparture;
    }
}