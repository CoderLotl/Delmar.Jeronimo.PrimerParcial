namespace UI
{
    partial class FrmSellTicketMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CmboBox_Destination = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CmboBox_Origin = new System.Windows.Forms.ComboBox();
            this.GrpBox_Destination = new System.Windows.Forms.GroupBox();
            this.RdoBttn_International = new System.Windows.Forms.RadioButton();
            this.RdoBttn_National = new System.Windows.Forms.RadioButton();
            this.GrpBox_Controls = new System.Windows.Forms.GroupBox();
            this.Btn_SellTicketCancel = new System.Windows.Forms.Button();
            this.Btn_SellTicketAccept = new System.Windows.Forms.Button();
            this.GrpBox_Requirements = new System.Windows.Forms.GroupBox();
            this.ChckBox_Food = new System.Windows.Forms.CheckBox();
            this.ChckBox_Wifi = new System.Windows.Forms.CheckBox();
            this.RchTxtBox_FlightInfo = new System.Windows.Forms.RichTextBox();
            this.Dgv_TicketFlights = new System.Windows.Forms.DataGridView();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.GrpBox_Destination.SuspendLayout();
            this.GrpBox_Controls.SuspendLayout();
            this.GrpBox_Requirements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_TicketFlights)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CmboBox_Destination);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(441, 30);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 62);
            this.groupBox4.TabIndex = 10;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CmboBox_Origin);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(235, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 62);
            this.groupBox3.TabIndex = 9;
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
            // GrpBox_Destination
            // 
            this.GrpBox_Destination.Controls.Add(this.RdoBttn_International);
            this.GrpBox_Destination.Controls.Add(this.RdoBttn_National);
            this.GrpBox_Destination.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GrpBox_Destination.Location = new System.Drawing.Point(31, 30);
            this.GrpBox_Destination.Name = "GrpBox_Destination";
            this.GrpBox_Destination.Size = new System.Drawing.Size(198, 96);
            this.GrpBox_Destination.TabIndex = 8;
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
            this.RdoBttn_International.CheckedChanged += new System.EventHandler(this.RdoBttn_International_CheckedChanged);
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
            this.RdoBttn_National.CheckedChanged += new System.EventHandler(this.RdoBttn_National_CheckedChanged);
            // 
            // GrpBox_Controls
            // 
            this.GrpBox_Controls.Controls.Add(this.Btn_SellTicketCancel);
            this.GrpBox_Controls.Controls.Add(this.Btn_SellTicketAccept);
            this.GrpBox_Controls.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GrpBox_Controls.Location = new System.Drawing.Point(896, 491);
            this.GrpBox_Controls.Name = "GrpBox_Controls";
            this.GrpBox_Controls.Size = new System.Drawing.Size(265, 104);
            this.GrpBox_Controls.TabIndex = 12;
            this.GrpBox_Controls.TabStop = false;
            // 
            // Btn_SellTicketCancel
            // 
            this.Btn_SellTicketCancel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_SellTicketCancel.Location = new System.Drawing.Point(6, 49);
            this.Btn_SellTicketCancel.Name = "Btn_SellTicketCancel";
            this.Btn_SellTicketCancel.Size = new System.Drawing.Size(120, 40);
            this.Btn_SellTicketCancel.TabIndex = 3;
            this.Btn_SellTicketCancel.Text = "Go Back";
            this.Btn_SellTicketCancel.UseVisualStyleBackColor = true;
            this.Btn_SellTicketCancel.Click += new System.EventHandler(this.Btn_SellTicketCancel_Click);
            // 
            // Btn_SellTicketAccept
            // 
            this.Btn_SellTicketAccept.Enabled = false;
            this.Btn_SellTicketAccept.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_SellTicketAccept.Location = new System.Drawing.Point(139, 49);
            this.Btn_SellTicketAccept.Name = "Btn_SellTicketAccept";
            this.Btn_SellTicketAccept.Size = new System.Drawing.Size(120, 40);
            this.Btn_SellTicketAccept.TabIndex = 2;
            this.Btn_SellTicketAccept.Text = "Accept";
            this.Btn_SellTicketAccept.UseVisualStyleBackColor = true;
            this.Btn_SellTicketAccept.Click += new System.EventHandler(this.Btn_SellTicketAccept_Click);
            // 
            // GrpBox_Requirements
            // 
            this.GrpBox_Requirements.Controls.Add(this.ChckBox_Food);
            this.GrpBox_Requirements.Controls.Add(this.ChckBox_Wifi);
            this.GrpBox_Requirements.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GrpBox_Requirements.Location = new System.Drawing.Point(684, 30);
            this.GrpBox_Requirements.Name = "GrpBox_Requirements";
            this.GrpBox_Requirements.Size = new System.Drawing.Size(251, 80);
            this.GrpBox_Requirements.TabIndex = 13;
            this.GrpBox_Requirements.TabStop = false;
            this.GrpBox_Requirements.Text = "Requirements";
            // 
            // ChckBox_Food
            // 
            this.ChckBox_Food.AutoSize = true;
            this.ChckBox_Food.Location = new System.Drawing.Point(121, 41);
            this.ChckBox_Food.Name = "ChckBox_Food";
            this.ChckBox_Food.Size = new System.Drawing.Size(93, 21);
            this.ChckBox_Food.TabIndex = 1;
            this.ChckBox_Food.Text = "Offers food";
            this.ChckBox_Food.UseVisualStyleBackColor = true;
            this.ChckBox_Food.CheckedChanged += new System.EventHandler(this.ChckBox_Food_CheckedChanged);
            // 
            // ChckBox_Wifi
            // 
            this.ChckBox_Wifi.AutoSize = true;
            this.ChckBox_Wifi.Location = new System.Drawing.Point(29, 41);
            this.ChckBox_Wifi.Name = "ChckBox_Wifi";
            this.ChckBox_Wifi.Size = new System.Drawing.Size(50, 21);
            this.ChckBox_Wifi.TabIndex = 0;
            this.ChckBox_Wifi.Text = "Wifi";
            this.ChckBox_Wifi.UseVisualStyleBackColor = true;
            this.ChckBox_Wifi.CheckedChanged += new System.EventHandler(this.ChckBox_Wifi_CheckedChanged);
            // 
            // RchTxtBox_FlightInfo
            // 
            this.RchTxtBox_FlightInfo.BackColor = System.Drawing.Color.DimGray;
            this.RchTxtBox_FlightInfo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RchTxtBox_FlightInfo.ForeColor = System.Drawing.Color.Black;
            this.RchTxtBox_FlightInfo.Location = new System.Drawing.Point(12, 491);
            this.RchTxtBox_FlightInfo.Name = "RchTxtBox_FlightInfo";
            this.RchTxtBox_FlightInfo.ReadOnly = true;
            this.RchTxtBox_FlightInfo.Size = new System.Drawing.Size(702, 104);
            this.RchTxtBox_FlightInfo.TabIndex = 14;
            this.RchTxtBox_FlightInfo.Text = "";
            // 
            // Dgv_TicketFlights
            // 
            this.Dgv_TicketFlights.AllowUserToAddRows = false;
            this.Dgv_TicketFlights.AllowUserToDeleteRows = false;
            this.Dgv_TicketFlights.AllowUserToOrderColumns = true;
            this.Dgv_TicketFlights.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Dgv_TicketFlights.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dgv_TicketFlights.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.Dgv_TicketFlights.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dgv_TicketFlights.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.Dgv_TicketFlights.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_TicketFlights.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_TicketFlights.ColumnHeadersHeight = 60;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_TicketFlights.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_TicketFlights.EnableHeadersVisualStyles = false;
            this.Dgv_TicketFlights.GridColor = System.Drawing.Color.SteelBlue;
            this.Dgv_TicketFlights.Location = new System.Drawing.Point(12, 132);
            this.Dgv_TicketFlights.Name = "Dgv_TicketFlights";
            this.Dgv_TicketFlights.ReadOnly = true;
            this.Dgv_TicketFlights.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_TicketFlights.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.Dgv_TicketFlights.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv_TicketFlights.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dgv_TicketFlights.RowTemplate.Height = 50;
            this.Dgv_TicketFlights.RowTemplate.ReadOnly = true;
            this.Dgv_TicketFlights.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_TicketFlights.ShowEditingIcon = false;
            this.Dgv_TicketFlights.Size = new System.Drawing.Size(1149, 352);
            this.Dgv_TicketFlights.TabIndex = 11;
            this.Dgv_TicketFlights.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_TicketFlights_CellContentClick);
            // 
            // FrmSellTicketMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 607);
            this.ControlBox = false;
            this.Controls.Add(this.RchTxtBox_FlightInfo);
            this.Controls.Add(this.GrpBox_Requirements);
            this.Controls.Add(this.GrpBox_Controls);
            this.Controls.Add(this.Dgv_TicketFlights);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.GrpBox_Destination);
            this.Name = "FrmSellTicketMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmSellTicketMain_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.GrpBox_Destination.ResumeLayout(false);
            this.GrpBox_Destination.PerformLayout();
            this.GrpBox_Controls.ResumeLayout(false);
            this.GrpBox_Requirements.ResumeLayout(false);
            this.GrpBox_Requirements.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_TicketFlights)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox CmboBox_Destination;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox CmboBox_Origin;
        private System.Windows.Forms.GroupBox GrpBox_Destination;
        private System.Windows.Forms.RadioButton RdoBttn_International;
        private System.Windows.Forms.RadioButton RdoBttn_National;
        private System.Windows.Forms.GroupBox GrpBox_Controls;
        private System.Windows.Forms.Button Btn_SellTicketCancel;
        private System.Windows.Forms.Button Btn_SellTicketAccept;
        private System.Windows.Forms.GroupBox GrpBox_Requirements;
        private System.Windows.Forms.CheckBox ChckBox_Wifi;
        private System.Windows.Forms.CheckBox ChckBox_Food;
        private System.Windows.Forms.RichTextBox RchTxtBox_FlightInfo;
        private System.Windows.Forms.DataGridView Dgv_TicketFlights;
    }
}