namespace UI
{
    partial class FrmSellTicket
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Dgv_Clients = new System.Windows.Forms.DataGridView();
            this.PassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectThis = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Dgv_Passengers = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Btn_SellTicketAddPass = new System.Windows.Forms.Button();
            this.Btn_SellTicketRmvPass = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lbl_CrntPassAmount = new System.Windows.Forms.Label();
            this.Lbl_CrntPassengers = new System.Windows.Forms.Label();
            this.Lbl_TourSeatsAmount = new System.Windows.Forms.Label();
            this.Lbl_PremSeatsAmount = new System.Windows.Forms.Label();
            this.Lbl_TouristSeats = new System.Windows.Forms.Label();
            this.Lbl_PremiumSeats = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RdoBttn_Tourist = new System.Windows.Forms.RadioButton();
            this.RdoBttn_Premium = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Lbl_PassengersToEmbark = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Btn_SellTicketAccept = new System.Windows.Forms.Button();
            this.Btn_SellTicketCancel = new System.Windows.Forms.Button();
            this.RchTxtBox_Total = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Clients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Passengers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgv_Clients
            // 
            this.Dgv_Clients.AllowUserToAddRows = false;
            this.Dgv_Clients.AllowUserToDeleteRows = false;
            this.Dgv_Clients.AllowUserToOrderColumns = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Clients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Clients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PassName,
            this.PassLastName,
            this.DNI,
            this.SelectThis});
            this.Dgv_Clients.Location = new System.Drawing.Point(6, 25);
            this.Dgv_Clients.Name = "Dgv_Clients";
            this.Dgv_Clients.RowTemplate.Height = 25;
            this.Dgv_Clients.ShowEditingIcon = false;
            this.Dgv_Clients.Size = new System.Drawing.Size(445, 269);
            this.Dgv_Clients.TabIndex = 0;
            // 
            // PassName
            // 
            this.PassName.DataPropertyName = "name";
            this.PassName.HeaderText = "Name";
            this.PassName.Name = "PassName";
            this.PassName.ReadOnly = true;
            // 
            // PassLastName
            // 
            this.PassLastName.DataPropertyName = "lastName";
            this.PassLastName.HeaderText = "Last Name";
            this.PassLastName.Name = "PassLastName";
            this.PassLastName.ReadOnly = true;
            // 
            // DNI
            // 
            this.DNI.DataPropertyName = "dni";
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // SelectThis
            // 
            this.SelectThis.FalseValue = "false";
            this.SelectThis.HeaderText = "SelectThis";
            this.SelectThis.Name = "SelectThis";
            this.SelectThis.TrueValue = "true";
            // 
            // Dgv_Passengers
            // 
            this.Dgv_Passengers.AllowUserToAddRows = false;
            this.Dgv_Passengers.AllowUserToDeleteRows = false;
            this.Dgv_Passengers.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Passengers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv_Passengers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Passengers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1});
            this.Dgv_Passengers.Location = new System.Drawing.Point(6, 26);
            this.Dgv_Passengers.Name = "Dgv_Passengers";
            this.Dgv_Passengers.RowTemplate.Height = 25;
            this.Dgv_Passengers.ShowEditingIcon = false;
            this.Dgv_Passengers.Size = new System.Drawing.Size(445, 269);
            this.Dgv_Passengers.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "lastName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dni";
            this.dataGridViewTextBoxColumn3.HeaderText = "DNI";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "SelectThis";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // Btn_SellTicketAddPass
            // 
            this.Btn_SellTicketAddPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_SellTicketAddPass.Location = new System.Drawing.Point(476, 28);
            this.Btn_SellTicketAddPass.Name = "Btn_SellTicketAddPass";
            this.Btn_SellTicketAddPass.Size = new System.Drawing.Size(105, 247);
            this.Btn_SellTicketAddPass.TabIndex = 2;
            this.Btn_SellTicketAddPass.Text = "Add as Passenger";
            this.Btn_SellTicketAddPass.UseVisualStyleBackColor = true;
            this.Btn_SellTicketAddPass.Click += new System.EventHandler(this.Btn_SellTicketAddPass_Click);
            // 
            // Btn_SellTicketRmvPass
            // 
            this.Btn_SellTicketRmvPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_SellTicketRmvPass.Location = new System.Drawing.Point(476, 340);
            this.Btn_SellTicketRmvPass.Name = "Btn_SellTicketRmvPass";
            this.Btn_SellTicketRmvPass.Size = new System.Drawing.Size(105, 247);
            this.Btn_SellTicketRmvPass.TabIndex = 6;
            this.Btn_SellTicketRmvPass.Text = "Remove from Passengers";
            this.Btn_SellTicketRmvPass.UseVisualStyleBackColor = true;
            this.Btn_SellTicketRmvPass.Click += new System.EventHandler(this.Btn_SellTicketRmvPass_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lbl_CrntPassAmount);
            this.groupBox1.Controls.Add(this.Lbl_CrntPassengers);
            this.groupBox1.Controls.Add(this.Lbl_TourSeatsAmount);
            this.groupBox1.Controls.Add(this.Lbl_PremSeatsAmount);
            this.groupBox1.Controls.Add(this.Lbl_TouristSeats);
            this.groupBox1.Controls.Add(this.Lbl_PremiumSeats);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(613, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 247);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Flight";
            // 
            // Lbl_CrntPassAmount
            // 
            this.Lbl_CrntPassAmount.AutoSize = true;
            this.Lbl_CrntPassAmount.Location = new System.Drawing.Point(221, 72);
            this.Lbl_CrntPassAmount.Name = "Lbl_CrntPassAmount";
            this.Lbl_CrntPassAmount.Size = new System.Drawing.Size(22, 24);
            this.Lbl_CrntPassAmount.TabIndex = 5;
            this.Lbl_CrntPassAmount.Text = "0";
            this.Lbl_CrntPassAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lbl_CrntPassengers
            // 
            this.Lbl_CrntPassengers.AutoSize = true;
            this.Lbl_CrntPassengers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_CrntPassengers.Location = new System.Drawing.Point(8, 75);
            this.Lbl_CrntPassengers.Name = "Lbl_CrntPassengers";
            this.Lbl_CrntPassengers.Size = new System.Drawing.Size(162, 21);
            this.Lbl_CrntPassengers.TabIndex = 4;
            this.Lbl_CrntPassengers.Text = "Current Passengers:";
            // 
            // Lbl_TourSeatsAmount
            // 
            this.Lbl_TourSeatsAmount.AutoSize = true;
            this.Lbl_TourSeatsAmount.Location = new System.Drawing.Point(221, 51);
            this.Lbl_TourSeatsAmount.Name = "Lbl_TourSeatsAmount";
            this.Lbl_TourSeatsAmount.Size = new System.Drawing.Size(22, 24);
            this.Lbl_TourSeatsAmount.TabIndex = 3;
            this.Lbl_TourSeatsAmount.Text = "0";
            this.Lbl_TourSeatsAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lbl_PremSeatsAmount
            // 
            this.Lbl_PremSeatsAmount.AutoSize = true;
            this.Lbl_PremSeatsAmount.Location = new System.Drawing.Point(221, 29);
            this.Lbl_PremSeatsAmount.Name = "Lbl_PremSeatsAmount";
            this.Lbl_PremSeatsAmount.Size = new System.Drawing.Size(22, 24);
            this.Lbl_PremSeatsAmount.TabIndex = 2;
            this.Lbl_PremSeatsAmount.Text = "0";
            this.Lbl_PremSeatsAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lbl_TouristSeats
            // 
            this.Lbl_TouristSeats.AutoSize = true;
            this.Lbl_TouristSeats.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_TouristSeats.Location = new System.Drawing.Point(8, 54);
            this.Lbl_TouristSeats.Name = "Lbl_TouristSeats";
            this.Lbl_TouristSeats.Size = new System.Drawing.Size(107, 21);
            this.Lbl_TouristSeats.TabIndex = 1;
            this.Lbl_TouristSeats.Text = "Tourist seats:";
            // 
            // Lbl_PremiumSeats
            // 
            this.Lbl_PremiumSeats.AutoSize = true;
            this.Lbl_PremiumSeats.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_PremiumSeats.Location = new System.Drawing.Point(8, 33);
            this.Lbl_PremiumSeats.Name = "Lbl_PremiumSeats";
            this.Lbl_PremiumSeats.Size = new System.Drawing.Size(125, 21);
            this.Lbl_PremiumSeats.TabIndex = 0;
            this.Lbl_PremiumSeats.Text = "Premium seats:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RdoBttn_Tourist);
            this.groupBox2.Controls.Add(this.RdoBttn_Premium);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(613, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 117);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seats";
            // 
            // RdoBttn_Tourist
            // 
            this.RdoBttn_Tourist.AutoSize = true;
            this.RdoBttn_Tourist.Location = new System.Drawing.Point(11, 66);
            this.RdoBttn_Tourist.Name = "RdoBttn_Tourist";
            this.RdoBttn_Tourist.Size = new System.Drawing.Size(87, 28);
            this.RdoBttn_Tourist.TabIndex = 1;
            this.RdoBttn_Tourist.TabStop = true;
            this.RdoBttn_Tourist.Text = "Tourist";
            this.RdoBttn_Tourist.UseVisualStyleBackColor = true;
            this.RdoBttn_Tourist.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // RdoBttn_Premium
            // 
            this.RdoBttn_Premium.AutoSize = true;
            this.RdoBttn_Premium.Location = new System.Drawing.Point(11, 32);
            this.RdoBttn_Premium.Name = "RdoBttn_Premium";
            this.RdoBttn_Premium.Size = new System.Drawing.Size(118, 28);
            this.RdoBttn_Premium.TabIndex = 0;
            this.RdoBttn_Premium.TabStop = true;
            this.RdoBttn_Premium.Text = "Premium";
            this.RdoBttn_Premium.UseVisualStyleBackColor = true;
            this.RdoBttn_Premium.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Lbl_PassengersToEmbark);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(613, 398);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 69);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Passengers to embark";
            // 
            // Lbl_PassengersToEmbark
            // 
            this.Lbl_PassengersToEmbark.AutoSize = true;
            this.Lbl_PassengersToEmbark.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_PassengersToEmbark.Location = new System.Drawing.Point(63, 29);
            this.Lbl_PassengersToEmbark.Name = "Lbl_PassengersToEmbark";
            this.Lbl_PassengersToEmbark.Size = new System.Drawing.Size(74, 24);
            this.Lbl_PassengersToEmbark.TabIndex = 0;
            this.Lbl_PassengersToEmbark.Text = "label5";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Btn_SellTicketAccept);
            this.groupBox4.Controls.Add(this.Btn_SellTicketCancel);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(913, 476);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(287, 133);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            // 
            // Btn_SellTicketAccept
            // 
            this.Btn_SellTicketAccept.Enabled = false;
            this.Btn_SellTicketAccept.Location = new System.Drawing.Point(164, 30);
            this.Btn_SellTicketAccept.Name = "Btn_SellTicketAccept";
            this.Btn_SellTicketAccept.Size = new System.Drawing.Size(117, 69);
            this.Btn_SellTicketAccept.TabIndex = 2;
            this.Btn_SellTicketAccept.Text = "Accept";
            this.Btn_SellTicketAccept.UseVisualStyleBackColor = true;
            this.Btn_SellTicketAccept.Click += new System.EventHandler(this.Btn_SellTicketAccept_Click);
            // 
            // Btn_SellTicketCancel
            // 
            this.Btn_SellTicketCancel.Location = new System.Drawing.Point(6, 30);
            this.Btn_SellTicketCancel.Name = "Btn_SellTicketCancel";
            this.Btn_SellTicketCancel.Size = new System.Drawing.Size(117, 69);
            this.Btn_SellTicketCancel.TabIndex = 1;
            this.Btn_SellTicketCancel.Text = "Cancel";
            this.Btn_SellTicketCancel.UseVisualStyleBackColor = true;
            this.Btn_SellTicketCancel.Click += new System.EventHandler(this.Btn_SellTicketCancel_Click);
            // 
            // RchTxtBox_Total
            // 
            this.RchTxtBox_Total.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RchTxtBox_Total.Location = new System.Drawing.Point(913, 28);
            this.RchTxtBox_Total.Name = "RchTxtBox_Total";
            this.RchTxtBox_Total.ReadOnly = true;
            this.RchTxtBox_Total.Size = new System.Drawing.Size(274, 370);
            this.RchTxtBox_Total.TabIndex = 11;
            this.RchTxtBox_Total.Text = "";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Dgv_Clients);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox5.Location = new System.Drawing.Point(12, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(458, 305);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Clients";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.Dgv_Passengers);
            this.groupBox6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox6.Location = new System.Drawing.Point(12, 314);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(458, 301);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Passengers";
            // 
            // FrmSellTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 626);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.RchTxtBox_Total);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_SellTicketRmvPass);
            this.Controls.Add(this.Btn_SellTicketAddPass);
            this.Name = "FrmSellTicket";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSellTicket";
            this.Load += new System.EventHandler(this.FrmSellTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Clients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Passengers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Clients;
        private System.Windows.Forms.DataGridView Dgv_Passengers;
        private System.Windows.Forms.Button Btn_SellTicketAddPass;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectThis;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button Btn_SellTicketRmvPass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Lbl_TouristSeats;
        private System.Windows.Forms.Label Lbl_PremiumSeats;
        private System.Windows.Forms.Label Lbl_TourSeatsAmount;
        private System.Windows.Forms.Label Lbl_PremSeatsAmount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RdoBttn_Tourist;
        private System.Windows.Forms.RadioButton RdoBttn_Premium;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label Lbl_PassengersToEmbark;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Btn_SellTicketAccept;
        private System.Windows.Forms.Button Btn_SellTicketCancel;
        private System.Windows.Forms.Label Lbl_CrntPassengers;
        private System.Windows.Forms.Label Lbl_CrntPassAmount;
        private System.Windows.Forms.RichTextBox RchTxtBox_Total;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}