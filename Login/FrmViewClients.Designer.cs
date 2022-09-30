namespace UI
{
    partial class FrmViewClients
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
            this.Dgv_PassView = new System.Windows.Forms.DataGridView();
            this.Btn_ViewClientsExit = new System.Windows.Forms.Button();
            this.GrpBox_PassViewFilter = new System.Windows.Forms.GroupBox();
            this.TxtBox_PassViewFilter = new System.Windows.Forms.TextBox();
            this.GrpBox_PassViewControls = new System.Windows.Forms.GroupBox();
            this.RdoBttn_PassViewFilterAge = new System.Windows.Forms.RadioButton();
            this.RdoBttn_PassViewFilterDNI = new System.Windows.Forms.RadioButton();
            this.RdoBttn_PassViewFilterGender = new System.Windows.Forms.RadioButton();
            this.RdoBttn_PassViewFilterLastName = new System.Windows.Forms.RadioButton();
            this.RdoBttn_PassViewFilterName = new System.Windows.Forms.RadioButton();
            this.RdoBttn_PassViewFilterFlights = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_PassView)).BeginInit();
            this.GrpBox_PassViewFilter.SuspendLayout();
            this.GrpBox_PassViewControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgv_PassView
            // 
            this.Dgv_PassView.AllowUserToAddRows = false;
            this.Dgv_PassView.AllowUserToDeleteRows = false;
            this.Dgv_PassView.AllowUserToOrderColumns = true;
            this.Dgv_PassView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Dgv_PassView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dgv_PassView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.Dgv_PassView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dgv_PassView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.Dgv_PassView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_PassView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_PassView.ColumnHeadersHeight = 60;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_PassView.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_PassView.EnableHeadersVisualStyles = false;
            this.Dgv_PassView.GridColor = System.Drawing.Color.SteelBlue;
            this.Dgv_PassView.Location = new System.Drawing.Point(20, 134);
            this.Dgv_PassView.Name = "Dgv_PassView";
            this.Dgv_PassView.ReadOnly = true;
            this.Dgv_PassView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_PassView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.Dgv_PassView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv_PassView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dgv_PassView.RowTemplate.Height = 50;
            this.Dgv_PassView.RowTemplate.ReadOnly = true;
            this.Dgv_PassView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_PassView.ShowEditingIcon = false;
            this.Dgv_PassView.Size = new System.Drawing.Size(1149, 528);
            this.Dgv_PassView.TabIndex = 12;
            // 
            // Btn_ViewClientsExit
            // 
            this.Btn_ViewClientsExit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_ViewClientsExit.Location = new System.Drawing.Point(1026, 12);
            this.Btn_ViewClientsExit.Name = "Btn_ViewClientsExit";
            this.Btn_ViewClientsExit.Size = new System.Drawing.Size(143, 42);
            this.Btn_ViewClientsExit.TabIndex = 13;
            this.Btn_ViewClientsExit.Text = "Exit";
            this.Btn_ViewClientsExit.UseVisualStyleBackColor = true;
            this.Btn_ViewClientsExit.Click += new System.EventHandler(this.Btn_ViewClientsExit_Click);
            // 
            // GrpBox_PassViewFilter
            // 
            this.GrpBox_PassViewFilter.Controls.Add(this.TxtBox_PassViewFilter);
            this.GrpBox_PassViewFilter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GrpBox_PassViewFilter.Location = new System.Drawing.Point(20, 54);
            this.GrpBox_PassViewFilter.Name = "GrpBox_PassViewFilter";
            this.GrpBox_PassViewFilter.Size = new System.Drawing.Size(560, 74);
            this.GrpBox_PassViewFilter.TabIndex = 14;
            this.GrpBox_PassViewFilter.TabStop = false;
            this.GrpBox_PassViewFilter.Text = "Filter";
            // 
            // TxtBox_PassViewFilter
            // 
            this.TxtBox_PassViewFilter.Location = new System.Drawing.Point(6, 25);
            this.TxtBox_PassViewFilter.Name = "TxtBox_PassViewFilter";
            this.TxtBox_PassViewFilter.PlaceholderText = "Write your search here";
            this.TxtBox_PassViewFilter.Size = new System.Drawing.Size(548, 27);
            this.TxtBox_PassViewFilter.TabIndex = 0;
            this.TxtBox_PassViewFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // GrpBox_PassViewControls
            // 
            this.GrpBox_PassViewControls.Controls.Add(this.RdoBttn_PassViewFilterFlights);
            this.GrpBox_PassViewControls.Controls.Add(this.RdoBttn_PassViewFilterAge);
            this.GrpBox_PassViewControls.Controls.Add(this.RdoBttn_PassViewFilterDNI);
            this.GrpBox_PassViewControls.Controls.Add(this.RdoBttn_PassViewFilterGender);
            this.GrpBox_PassViewControls.Controls.Add(this.RdoBttn_PassViewFilterLastName);
            this.GrpBox_PassViewControls.Controls.Add(this.RdoBttn_PassViewFilterName);
            this.GrpBox_PassViewControls.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GrpBox_PassViewControls.Location = new System.Drawing.Point(586, 8);
            this.GrpBox_PassViewControls.Name = "GrpBox_PassViewControls";
            this.GrpBox_PassViewControls.Size = new System.Drawing.Size(434, 120);
            this.GrpBox_PassViewControls.TabIndex = 15;
            this.GrpBox_PassViewControls.TabStop = false;
            this.GrpBox_PassViewControls.Text = "Filter Options";
            // 
            // RdoBttn_PassViewFilterAge
            // 
            this.RdoBttn_PassViewFilterAge.AutoSize = true;
            this.RdoBttn_PassViewFilterAge.Location = new System.Drawing.Point(148, 46);
            this.RdoBttn_PassViewFilterAge.Name = "RdoBttn_PassViewFilterAge";
            this.RdoBttn_PassViewFilterAge.Size = new System.Drawing.Size(62, 25);
            this.RdoBttn_PassViewFilterAge.TabIndex = 4;
            this.RdoBttn_PassViewFilterAge.TabStop = true;
            this.RdoBttn_PassViewFilterAge.Text = "Age";
            this.RdoBttn_PassViewFilterAge.UseVisualStyleBackColor = true;
            // 
            // RdoBttn_PassViewFilterDNI
            // 
            this.RdoBttn_PassViewFilterDNI.AutoSize = true;
            this.RdoBttn_PassViewFilterDNI.Location = new System.Drawing.Point(148, 22);
            this.RdoBttn_PassViewFilterDNI.Name = "RdoBttn_PassViewFilterDNI";
            this.RdoBttn_PassViewFilterDNI.Size = new System.Drawing.Size(57, 25);
            this.RdoBttn_PassViewFilterDNI.TabIndex = 3;
            this.RdoBttn_PassViewFilterDNI.TabStop = true;
            this.RdoBttn_PassViewFilterDNI.Text = "DNI";
            this.RdoBttn_PassViewFilterDNI.UseVisualStyleBackColor = true;
            // 
            // RdoBttn_PassViewFilterGender
            // 
            this.RdoBttn_PassViewFilterGender.AutoSize = true;
            this.RdoBttn_PassViewFilterGender.Location = new System.Drawing.Point(6, 71);
            this.RdoBttn_PassViewFilterGender.Name = "RdoBttn_PassViewFilterGender";
            this.RdoBttn_PassViewFilterGender.Size = new System.Drawing.Size(88, 25);
            this.RdoBttn_PassViewFilterGender.TabIndex = 2;
            this.RdoBttn_PassViewFilterGender.TabStop = true;
            this.RdoBttn_PassViewFilterGender.Text = "Gender";
            this.RdoBttn_PassViewFilterGender.UseVisualStyleBackColor = true;
            // 
            // RdoBttn_PassViewFilterLastName
            // 
            this.RdoBttn_PassViewFilterLastName.AutoSize = true;
            this.RdoBttn_PassViewFilterLastName.Location = new System.Drawing.Point(6, 46);
            this.RdoBttn_PassViewFilterLastName.Name = "RdoBttn_PassViewFilterLastName";
            this.RdoBttn_PassViewFilterLastName.Size = new System.Drawing.Size(111, 25);
            this.RdoBttn_PassViewFilterLastName.TabIndex = 1;
            this.RdoBttn_PassViewFilterLastName.TabStop = true;
            this.RdoBttn_PassViewFilterLastName.Text = "Last Name";
            this.RdoBttn_PassViewFilterLastName.UseVisualStyleBackColor = true;
            // 
            // RdoBttn_PassViewFilterName
            // 
            this.RdoBttn_PassViewFilterName.AutoSize = true;
            this.RdoBttn_PassViewFilterName.Location = new System.Drawing.Point(6, 22);
            this.RdoBttn_PassViewFilterName.Name = "RdoBttn_PassViewFilterName";
            this.RdoBttn_PassViewFilterName.Size = new System.Drawing.Size(76, 25);
            this.RdoBttn_PassViewFilterName.TabIndex = 0;
            this.RdoBttn_PassViewFilterName.TabStop = true;
            this.RdoBttn_PassViewFilterName.Text = "Name";
            this.RdoBttn_PassViewFilterName.UseVisualStyleBackColor = true;
            // 
            // RdoBttn_PassViewFilterFlights
            // 
            this.RdoBttn_PassViewFilterFlights.AutoSize = true;
            this.RdoBttn_PassViewFilterFlights.Location = new System.Drawing.Point(148, 71);
            this.RdoBttn_PassViewFilterFlights.Name = "RdoBttn_PassViewFilterFlights";
            this.RdoBttn_PassViewFilterFlights.Size = new System.Drawing.Size(76, 25);
            this.RdoBttn_PassViewFilterFlights.TabIndex = 5;
            this.RdoBttn_PassViewFilterFlights.TabStop = true;
            this.RdoBttn_PassViewFilterFlights.Text = "Flights";
            this.RdoBttn_PassViewFilterFlights.UseVisualStyleBackColor = true;
            // 
            // FrmViewClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 733);
            this.ControlBox = false;
            this.Controls.Add(this.GrpBox_PassViewControls);
            this.Controls.Add(this.GrpBox_PassViewFilter);
            this.Controls.Add(this.Btn_ViewClientsExit);
            this.Controls.Add(this.Dgv_PassView);
            this.Name = "FrmViewClients";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmViewClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_PassView)).EndInit();
            this.GrpBox_PassViewFilter.ResumeLayout(false);
            this.GrpBox_PassViewFilter.PerformLayout();
            this.GrpBox_PassViewControls.ResumeLayout(false);
            this.GrpBox_PassViewControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_PassView;
        private System.Windows.Forms.Button Btn_ViewClientsExit;
        private System.Windows.Forms.GroupBox GrpBox_PassViewFilter;
        private System.Windows.Forms.TextBox TxtBox_PassViewFilter;
        private System.Windows.Forms.GroupBox GrpBox_PassViewControls;
        private System.Windows.Forms.RadioButton RdoBttn_PassViewFilterName;
        private System.Windows.Forms.RadioButton RdoBttn_PassViewFilterLastName;
        private System.Windows.Forms.RadioButton RdoBttn_PassViewFilterGender;
        private System.Windows.Forms.RadioButton RdoBttn_PassViewFilterDNI;
        private System.Windows.Forms.RadioButton RdoBttn_PassViewFilterAge;
        private System.Windows.Forms.RadioButton RdoBttn_PassViewFilterFlights;
    }
}