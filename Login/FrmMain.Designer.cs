namespace UI
{
    partial class FrmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.grpBox_User = new System.Windows.Forms.GroupBox();
            this.btn_ExitProgram = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.lbl_User = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_AddPlane = new System.Windows.Forms.Button();
            this.GrpBox_Earned = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Lbl_International = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Lbl_National = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Lbl_Earned = new System.Windows.Forms.Label();
            this.Btn_ViewClient = new System.Windows.Forms.Button();
            this.Btn_AddClient = new System.Windows.Forms.Button();
            this.Btn_SellTicket = new System.Windows.Forms.Button();
            this.Btn_AddFlight = new System.Windows.Forms.Button();
            this.DgvMainGrid = new System.Windows.Forms.DataGridView();
            this.grpBox_Flights = new System.Windows.Forms.GroupBox();
            this.cmbBox_Flights = new System.Windows.Forms.ComboBox();
            this.grpBox_Passengers = new System.Windows.Forms.GroupBox();
            this.cmbBox_Passengers = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tStrpStatus_Date = new System.Windows.Forms.ToolStripStatusLabel();
            this.tStrpStatus_User = new System.Windows.Forms.ToolStripStatusLabel();
            this.Lbl_FlightsAmount = new System.Windows.Forms.Label();
            this.Lbl_PlanesAmount = new System.Windows.Forms.Label();
            this.Lbl_ClientsAmount = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdoBttn_SourceHistory = new System.Windows.Forms.RadioButton();
            this.RdoBttn_SourceCurrent = new System.Windows.Forms.RadioButton();
            this.Btn_MainCheckDestinations = new System.Windows.Forms.Button();
            this.grpBox_User.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.GrpBox_Earned.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMainGrid)).BeginInit();
            this.grpBox_Flights.SuspendLayout();
            this.grpBox_Passengers.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBox_User
            // 
            this.grpBox_User.Controls.Add(this.btn_ExitProgram);
            this.grpBox_User.Controls.Add(this.btn_LogOut);
            this.grpBox_User.Controls.Add(this.lbl_UserName);
            this.grpBox_User.Controls.Add(this.lbl_User);
            this.grpBox_User.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpBox_User.Location = new System.Drawing.Point(1247, 12);
            this.grpBox_User.Name = "grpBox_User";
            this.grpBox_User.Size = new System.Drawing.Size(202, 70);
            this.grpBox_User.TabIndex = 0;
            this.grpBox_User.TabStop = false;
            this.grpBox_User.Text = "Logged user:";
            // 
            // btn_ExitProgram
            // 
            this.btn_ExitProgram.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ExitProgram.Location = new System.Drawing.Point(18, 41);
            this.btn_ExitProgram.Name = "btn_ExitProgram";
            this.btn_ExitProgram.Size = new System.Drawing.Size(75, 23);
            this.btn_ExitProgram.TabIndex = 3;
            this.btn_ExitProgram.Text = "Exit";
            this.btn_ExitProgram.UseVisualStyleBackColor = true;
            this.btn_ExitProgram.Click += new System.EventHandler(this.Btn_ExitProgram_Click);
            this.btn_ExitProgram.MouseHover += new System.EventHandler(this.btn_ExitProgram_MouseHover);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_LogOut.Location = new System.Drawing.Point(103, 41);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(75, 23);
            this.btn_LogOut.TabIndex = 2;
            this.btn_LogOut.Text = "Logout";
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.Btn_LogOut_Click);
            this.btn_LogOut.MouseHover += new System.EventHandler(this.btn_LogOut_MouseHover);
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Location = new System.Drawing.Point(103, 19);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(83, 17);
            this.lbl_UserName.TabIndex = 1;
            this.lbl_UserName.Text = "GenericUser";
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Location = new System.Drawing.Point(18, 19);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(37, 17);
            this.lbl_User.TabIndex = 0;
            this.lbl_User.Text = "User:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Controls.Add(this.Btn_AddPlane);
            this.groupBox2.Controls.Add(this.GrpBox_Earned);
            this.groupBox2.Controls.Add(this.Btn_ViewClient);
            this.groupBox2.Controls.Add(this.Btn_AddClient);
            this.groupBox2.Controls.Add(this.Btn_SellTicket);
            this.groupBox2.Controls.Add(this.Btn_AddFlight);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 663);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controls";
            // 
            // Btn_AddPlane
            // 
            this.Btn_AddPlane.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_AddPlane.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_AddPlane.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_AddPlane.Location = new System.Drawing.Point(6, 47);
            this.Btn_AddPlane.Name = "Btn_AddPlane";
            this.Btn_AddPlane.Size = new System.Drawing.Size(188, 42);
            this.Btn_AddPlane.TabIndex = 11;
            this.Btn_AddPlane.Text = "Add Plane";
            this.Btn_AddPlane.UseVisualStyleBackColor = false;
            // 
            // GrpBox_Earned
            // 
            this.GrpBox_Earned.Controls.Add(this.groupBox5);
            this.GrpBox_Earned.Controls.Add(this.groupBox4);
            this.GrpBox_Earned.Controls.Add(this.groupBox3);
            this.GrpBox_Earned.Location = new System.Drawing.Point(6, 350);
            this.GrpBox_Earned.Name = "GrpBox_Earned";
            this.GrpBox_Earned.Size = new System.Drawing.Size(188, 307);
            this.GrpBox_Earned.TabIndex = 10;
            this.GrpBox_Earned.TabStop = false;
            this.GrpBox_Earned.Text = "Earned";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Lbl_International);
            this.groupBox5.Location = new System.Drawing.Point(6, 198);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(176, 77);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "International";
            // 
            // Lbl_International
            // 
            this.Lbl_International.AutoSize = true;
            this.Lbl_International.Location = new System.Drawing.Point(6, 29);
            this.Lbl_International.Name = "Lbl_International";
            this.Lbl_International.Size = new System.Drawing.Size(74, 24);
            this.Lbl_International.TabIndex = 0;
            this.Lbl_International.Text = "label1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Lbl_National);
            this.groupBox4.Location = new System.Drawing.Point(6, 115);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(176, 77);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "National";
            // 
            // Lbl_National
            // 
            this.Lbl_National.AutoSize = true;
            this.Lbl_National.Location = new System.Drawing.Point(6, 29);
            this.Lbl_National.Name = "Lbl_National";
            this.Lbl_National.Size = new System.Drawing.Size(74, 24);
            this.Lbl_National.TabIndex = 0;
            this.Lbl_National.Text = "label1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Lbl_Earned);
            this.groupBox3.Location = new System.Drawing.Point(6, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(176, 77);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Total";
            // 
            // Lbl_Earned
            // 
            this.Lbl_Earned.AutoSize = true;
            this.Lbl_Earned.Location = new System.Drawing.Point(6, 29);
            this.Lbl_Earned.Name = "Lbl_Earned";
            this.Lbl_Earned.Size = new System.Drawing.Size(74, 24);
            this.Lbl_Earned.TabIndex = 0;
            this.Lbl_Earned.Text = "label1";
            // 
            // Btn_ViewClient
            // 
            this.Btn_ViewClient.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_ViewClient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_ViewClient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_ViewClient.Location = new System.Drawing.Point(6, 272);
            this.Btn_ViewClient.Name = "Btn_ViewClient";
            this.Btn_ViewClient.Size = new System.Drawing.Size(188, 42);
            this.Btn_ViewClient.TabIndex = 5;
            this.Btn_ViewClient.Text = "View Clients";
            this.Btn_ViewClient.UseVisualStyleBackColor = false;
            this.Btn_ViewClient.Click += new System.EventHandler(this.button3_Click);
            this.Btn_ViewClient.MouseHover += new System.EventHandler(this.Btn_ViewClient_MouseHover);
            // 
            // Btn_AddClient
            // 
            this.Btn_AddClient.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_AddClient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_AddClient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_AddClient.Location = new System.Drawing.Point(6, 215);
            this.Btn_AddClient.Name = "Btn_AddClient";
            this.Btn_AddClient.Size = new System.Drawing.Size(188, 42);
            this.Btn_AddClient.TabIndex = 4;
            this.Btn_AddClient.Text = "Add Client";
            this.Btn_AddClient.UseVisualStyleBackColor = false;
            this.Btn_AddClient.Click += new System.EventHandler(this.Btn_AddClient_Click);
            this.Btn_AddClient.MouseHover += new System.EventHandler(this.Btn_AddClient_MouseHover);
            // 
            // Btn_SellTicket
            // 
            this.Btn_SellTicket.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_SellTicket.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_SellTicket.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_SellTicket.Location = new System.Drawing.Point(6, 158);
            this.Btn_SellTicket.Name = "Btn_SellTicket";
            this.Btn_SellTicket.Size = new System.Drawing.Size(188, 42);
            this.Btn_SellTicket.TabIndex = 3;
            this.Btn_SellTicket.Text = "Sell Ticket";
            this.Btn_SellTicket.UseVisualStyleBackColor = false;
            this.Btn_SellTicket.Click += new System.EventHandler(this.Btn_SellTicket_Click);
            this.Btn_SellTicket.MouseHover += new System.EventHandler(this.Btn_SellTicket_MouseHover);
            // 
            // Btn_AddFlight
            // 
            this.Btn_AddFlight.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_AddFlight.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_AddFlight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_AddFlight.Location = new System.Drawing.Point(6, 106);
            this.Btn_AddFlight.Name = "Btn_AddFlight";
            this.Btn_AddFlight.Size = new System.Drawing.Size(188, 42);
            this.Btn_AddFlight.TabIndex = 2;
            this.Btn_AddFlight.Text = "Add Flight";
            this.Btn_AddFlight.UseVisualStyleBackColor = false;
            this.Btn_AddFlight.Click += new System.EventHandler(this.Btn_AddFlight_Click);
            this.Btn_AddFlight.MouseHover += new System.EventHandler(this.Btn_AddFlight_MouseHover);
            // 
            // DgvMainGrid
            // 
            this.DgvMainGrid.AllowUserToAddRows = false;
            this.DgvMainGrid.AllowUserToDeleteRows = false;
            this.DgvMainGrid.AllowUserToOrderColumns = true;
            this.DgvMainGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvMainGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvMainGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvMainGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.DgvMainGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvMainGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.DgvMainGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvMainGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvMainGrid.ColumnHeadersHeight = 45;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvMainGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvMainGrid.EnableHeadersVisualStyles = false;
            this.DgvMainGrid.GridColor = System.Drawing.Color.SteelBlue;
            this.DgvMainGrid.Location = new System.Drawing.Point(253, 143);
            this.DgvMainGrid.Name = "DgvMainGrid";
            this.DgvMainGrid.ReadOnly = true;
            this.DgvMainGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvMainGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.DgvMainGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvMainGrid.RowTemplate.Height = 50;
            this.DgvMainGrid.RowTemplate.ReadOnly = true;
            this.DgvMainGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvMainGrid.ShowEditingIcon = false;
            this.DgvMainGrid.Size = new System.Drawing.Size(1172, 532);
            this.DgvMainGrid.TabIndex = 2;
            this.DgvMainGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMainGrid_CellContentClick);
            // 
            // grpBox_Flights
            // 
            this.grpBox_Flights.Controls.Add(this.cmbBox_Flights);
            this.grpBox_Flights.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpBox_Flights.Location = new System.Drawing.Point(253, 78);
            this.grpBox_Flights.Name = "grpBox_Flights";
            this.grpBox_Flights.Size = new System.Drawing.Size(200, 56);
            this.grpBox_Flights.TabIndex = 3;
            this.grpBox_Flights.TabStop = false;
            this.grpBox_Flights.Text = "Flights";
            // 
            // cmbBox_Flights
            // 
            this.cmbBox_Flights.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_Flights.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbBox_Flights.FormattingEnabled = true;
            this.cmbBox_Flights.Location = new System.Drawing.Point(6, 22);
            this.cmbBox_Flights.Name = "cmbBox_Flights";
            this.cmbBox_Flights.Size = new System.Drawing.Size(188, 25);
            this.cmbBox_Flights.TabIndex = 0;
            this.cmbBox_Flights.SelectedIndexChanged += new System.EventHandler(this.CmbBox_Flights_SelectedIndexChanged);
            this.cmbBox_Flights.MouseHover += new System.EventHandler(this.cmbBox_Flights_MouseHover);
            // 
            // grpBox_Passengers
            // 
            this.grpBox_Passengers.Controls.Add(this.cmbBox_Passengers);
            this.grpBox_Passengers.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpBox_Passengers.Location = new System.Drawing.Point(480, 78);
            this.grpBox_Passengers.Name = "grpBox_Passengers";
            this.grpBox_Passengers.Size = new System.Drawing.Size(225, 56);
            this.grpBox_Passengers.TabIndex = 4;
            this.grpBox_Passengers.TabStop = false;
            this.grpBox_Passengers.Text = "Passengers";
            // 
            // cmbBox_Passengers
            // 
            this.cmbBox_Passengers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_Passengers.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbBox_Passengers.FormattingEnabled = true;
            this.cmbBox_Passengers.Location = new System.Drawing.Point(6, 22);
            this.cmbBox_Passengers.Name = "cmbBox_Passengers";
            this.cmbBox_Passengers.Size = new System.Drawing.Size(188, 25);
            this.cmbBox_Passengers.TabIndex = 0;
            this.cmbBox_Passengers.SelectedIndexChanged += new System.EventHandler(this.CmbBox_Passengers_SelectedIndexChanged);
            this.cmbBox_Passengers.MouseHover += new System.EventHandler(this.cmbBox_Passengers_MouseHover);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStrpStatus_Date,
            this.tStrpStatus_User});
            this.statusStrip1.Location = new System.Drawing.Point(0, 697);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1461, 25);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tStrpStatus_Date
            // 
            this.tStrpStatus_Date.BackColor = System.Drawing.Color.Transparent;
            this.tStrpStatus_Date.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tStrpStatus_Date.Margin = new System.Windows.Forms.Padding(20, 3, 0, 2);
            this.tStrpStatus_Date.Name = "tStrpStatus_Date";
            this.tStrpStatus_Date.Size = new System.Drawing.Size(79, 20);
            this.tStrpStatus_Date.Text = "Date ( ... )";
            // 
            // tStrpStatus_User
            // 
            this.tStrpStatus_User.BackColor = System.Drawing.Color.Transparent;
            this.tStrpStatus_User.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tStrpStatus_User.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tStrpStatus_User.Margin = new System.Windows.Forms.Padding(100, 3, 0, 2);
            this.tStrpStatus_User.Name = "tStrpStatus_User";
            this.tStrpStatus_User.Size = new System.Drawing.Size(99, 20);
            this.tStrpStatus_User.Text = "|| User ( ... )";
            // 
            // Lbl_FlightsAmount
            // 
            this.Lbl_FlightsAmount.AutoSize = true;
            this.Lbl_FlightsAmount.BackColor = System.Drawing.Color.DarkGray;
            this.Lbl_FlightsAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_FlightsAmount.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_FlightsAmount.Location = new System.Drawing.Point(259, 54);
            this.Lbl_FlightsAmount.Name = "Lbl_FlightsAmount";
            this.Lbl_FlightsAmount.Size = new System.Drawing.Size(46, 18);
            this.Lbl_FlightsAmount.TabIndex = 7;
            this.Lbl_FlightsAmount.Text = "label1";
            this.Lbl_FlightsAmount.MouseHover += new System.EventHandler(this.Lbl_FlightsAmount_MouseHover);
            // 
            // Lbl_PlanesAmount
            // 
            this.Lbl_PlanesAmount.AutoSize = true;
            this.Lbl_PlanesAmount.BackColor = System.Drawing.Color.DarkGray;
            this.Lbl_PlanesAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_PlanesAmount.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_PlanesAmount.Location = new System.Drawing.Point(259, 30);
            this.Lbl_PlanesAmount.Name = "Lbl_PlanesAmount";
            this.Lbl_PlanesAmount.Size = new System.Drawing.Size(46, 18);
            this.Lbl_PlanesAmount.TabIndex = 8;
            this.Lbl_PlanesAmount.Text = "label1";
            this.Lbl_PlanesAmount.MouseHover += new System.EventHandler(this.Lbl_PlanesAmount_MouseHover);
            // 
            // Lbl_ClientsAmount
            // 
            this.Lbl_ClientsAmount.AutoSize = true;
            this.Lbl_ClientsAmount.BackColor = System.Drawing.Color.DarkGray;
            this.Lbl_ClientsAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_ClientsAmount.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_ClientsAmount.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Lbl_ClientsAmount.Location = new System.Drawing.Point(486, 30);
            this.Lbl_ClientsAmount.Name = "Lbl_ClientsAmount";
            this.Lbl_ClientsAmount.Size = new System.Drawing.Size(46, 18);
            this.Lbl_ClientsAmount.TabIndex = 9;
            this.Lbl_ClientsAmount.Text = "label1";
            this.Lbl_ClientsAmount.MouseHover += new System.EventHandler(this.Lbl_ClientsAmount_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdoBttn_SourceHistory);
            this.groupBox1.Controls.Add(this.RdoBttn_SourceCurrent);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(711, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Source";
            // 
            // RdoBttn_SourceHistory
            // 
            this.RdoBttn_SourceHistory.AutoSize = true;
            this.RdoBttn_SourceHistory.Location = new System.Drawing.Point(16, 53);
            this.RdoBttn_SourceHistory.Name = "RdoBttn_SourceHistory";
            this.RdoBttn_SourceHistory.Size = new System.Drawing.Size(97, 25);
            this.RdoBttn_SourceHistory.TabIndex = 1;
            this.RdoBttn_SourceHistory.TabStop = true;
            this.RdoBttn_SourceHistory.Text = "Historical";
            this.RdoBttn_SourceHistory.UseVisualStyleBackColor = true;
            this.RdoBttn_SourceHistory.CheckedChanged += new System.EventHandler(this.RdoBttn_SourceHistory_CheckedChanged);
            // 
            // RdoBttn_SourceCurrent
            // 
            this.RdoBttn_SourceCurrent.AutoSize = true;
            this.RdoBttn_SourceCurrent.Location = new System.Drawing.Point(16, 25);
            this.RdoBttn_SourceCurrent.Name = "RdoBttn_SourceCurrent";
            this.RdoBttn_SourceCurrent.Size = new System.Drawing.Size(88, 25);
            this.RdoBttn_SourceCurrent.TabIndex = 0;
            this.RdoBttn_SourceCurrent.TabStop = true;
            this.RdoBttn_SourceCurrent.Text = "Current";
            this.RdoBttn_SourceCurrent.UseVisualStyleBackColor = true;
            this.RdoBttn_SourceCurrent.CheckedChanged += new System.EventHandler(this.RdoBttn_SourceCurrent_CheckedChanged);
            // 
            // Btn_MainCheckDestinations
            // 
            this.Btn_MainCheckDestinations.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_MainCheckDestinations.Location = new System.Drawing.Point(901, 53);
            this.Btn_MainCheckDestinations.Name = "Btn_MainCheckDestinations";
            this.Btn_MainCheckDestinations.Size = new System.Drawing.Size(119, 72);
            this.Btn_MainCheckDestinations.TabIndex = 11;
            this.Btn_MainCheckDestinations.Text = "Check Destinations";
            this.Btn_MainCheckDestinations.UseVisualStyleBackColor = true;
            this.Btn_MainCheckDestinations.Click += new System.EventHandler(this.Btn_MainCheckDestinations_Click);
            this.Btn_MainCheckDestinations.MouseHover += new System.EventHandler(this.Btn_MainCheckDestinations_MouseHover);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1461, 722);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_MainCheckDestinations);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Lbl_ClientsAmount);
            this.Controls.Add(this.Lbl_PlanesAmount);
            this.Controls.Add(this.Lbl_FlightsAmount);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grpBox_Passengers);
            this.Controls.Add(this.grpBox_Flights);
            this.Controls.Add(this.DgvMainGrid);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpBox_User);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.grpBox_User.ResumeLayout(false);
            this.grpBox_User.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.GrpBox_Earned.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMainGrid)).EndInit();
            this.grpBox_Flights.ResumeLayout(false);
            this.grpBox_Passengers.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox_User;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_ViewClient;
        private System.Windows.Forms.Button Btn_AddClient;
        private System.Windows.Forms.Button Btn_SellTicket;
        private System.Windows.Forms.Button Btn_AddFlight;
        private System.Windows.Forms.DataGridView DgvMainGrid;
        private System.Windows.Forms.GroupBox grpBox_Flights;
        private System.Windows.Forms.GroupBox grpBox_Passengers;
        private System.Windows.Forms.ComboBox cmbBox_Passengers;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tStrpStatus_Date;
        private System.Windows.Forms.ToolStripStatusLabel tStrpStatus_User;
        private System.Windows.Forms.Button btn_ExitProgram;
        public System.Windows.Forms.ComboBox cmbBox_Flights;
        private System.Windows.Forms.Label Lbl_FlightsAmount;
        private System.Windows.Forms.Label Lbl_PlanesAmount;
        private System.Windows.Forms.Label Lbl_ClientsAmount;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox GrpBox_Earned;
        private System.Windows.Forms.Label Lbl_Earned;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdoBttn_SourceHistory;
        private System.Windows.Forms.RadioButton RdoBttn_SourceCurrent;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label Lbl_International;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label Lbl_National;
        private System.Windows.Forms.Button Btn_MainCheckDestinations;
        private System.Windows.Forms.Button Btn_AddPlane;
    }
}
