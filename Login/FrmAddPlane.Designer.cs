namespace UI
{
    partial class FrmAddPlane
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
            this.GrpBox_Controls = new System.Windows.Forms.GroupBox();
            this.Btn_FrmAddFlightCancel = new System.Windows.Forms.Button();
            this.Btn_FrmAddFlightAccept = new System.Windows.Forms.Button();
            this.TxtBox_PlaneTag = new System.Windows.Forms.TextBox();
            this.GrpBox_PlaneTag = new System.Windows.Forms.GroupBox();
            this.GrpBox_PlaneSeats = new System.Windows.Forms.GroupBox();
            this.NUD_PlaneSeats = new System.Windows.Forms.NumericUpDown();
            this.GrpBox_PlaneWcs = new System.Windows.Forms.GroupBox();
            this.NUD_PlaneWCS = new System.Windows.Forms.NumericUpDown();
            this.GrpBox_Requirements = new System.Windows.Forms.GroupBox();
            this.ChckBox_Food = new System.Windows.Forms.CheckBox();
            this.ChckBox_Wifi = new System.Windows.Forms.CheckBox();
            this.GrpBox_PlaneCargo = new System.Windows.Forms.GroupBox();
            this.NUD_PlaneCargo = new System.Windows.Forms.NumericUpDown();
            this.GrpBox_Controls.SuspendLayout();
            this.GrpBox_PlaneTag.SuspendLayout();
            this.GrpBox_PlaneSeats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_PlaneSeats)).BeginInit();
            this.GrpBox_PlaneWcs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_PlaneWCS)).BeginInit();
            this.GrpBox_Requirements.SuspendLayout();
            this.GrpBox_PlaneCargo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_PlaneCargo)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpBox_Controls
            // 
            this.GrpBox_Controls.Controls.Add(this.Btn_FrmAddFlightCancel);
            this.GrpBox_Controls.Controls.Add(this.Btn_FrmAddFlightAccept);
            this.GrpBox_Controls.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GrpBox_Controls.Location = new System.Drawing.Point(232, 451);
            this.GrpBox_Controls.Name = "GrpBox_Controls";
            this.GrpBox_Controls.Size = new System.Drawing.Size(303, 118);
            this.GrpBox_Controls.TabIndex = 4;
            this.GrpBox_Controls.TabStop = false;
            // 
            // Btn_FrmAddFlightCancel
            // 
            this.Btn_FrmAddFlightCancel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_FrmAddFlightCancel.Location = new System.Drawing.Point(7, 56);
            this.Btn_FrmAddFlightCancel.Name = "Btn_FrmAddFlightCancel";
            this.Btn_FrmAddFlightCancel.Size = new System.Drawing.Size(137, 45);
            this.Btn_FrmAddFlightCancel.TabIndex = 3;
            this.Btn_FrmAddFlightCancel.Text = "Cancel";
            this.Btn_FrmAddFlightCancel.UseVisualStyleBackColor = true;
            this.Btn_FrmAddFlightCancel.Click += new System.EventHandler(this.Btn_FrmAddFlightCancel_Click);
            // 
            // Btn_FrmAddFlightAccept
            // 
            this.Btn_FrmAddFlightAccept.Enabled = false;
            this.Btn_FrmAddFlightAccept.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_FrmAddFlightAccept.Location = new System.Drawing.Point(159, 56);
            this.Btn_FrmAddFlightAccept.Name = "Btn_FrmAddFlightAccept";
            this.Btn_FrmAddFlightAccept.Size = new System.Drawing.Size(137, 45);
            this.Btn_FrmAddFlightAccept.TabIndex = 2;
            this.Btn_FrmAddFlightAccept.Text = "Accept";
            this.Btn_FrmAddFlightAccept.UseVisualStyleBackColor = true;
            this.Btn_FrmAddFlightAccept.Click += new System.EventHandler(this.Btn_FrmAddFlightAccept_Click);
            // 
            // TxtBox_PlaneTag
            // 
            this.TxtBox_PlaneTag.Location = new System.Drawing.Point(7, 25);
            this.TxtBox_PlaneTag.Name = "TxtBox_PlaneTag";
            this.TxtBox_PlaneTag.Size = new System.Drawing.Size(333, 23);
            this.TxtBox_PlaneTag.TabIndex = 5;
            this.TxtBox_PlaneTag.TextChanged += new System.EventHandler(this.TxtBox_PlaneTag_TextChanged);
            // 
            // GrpBox_PlaneTag
            // 
            this.GrpBox_PlaneTag.Controls.Add(this.TxtBox_PlaneTag);
            this.GrpBox_PlaneTag.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GrpBox_PlaneTag.Location = new System.Drawing.Point(14, 14);
            this.GrpBox_PlaneTag.Name = "GrpBox_PlaneTag";
            this.GrpBox_PlaneTag.Size = new System.Drawing.Size(347, 73);
            this.GrpBox_PlaneTag.TabIndex = 6;
            this.GrpBox_PlaneTag.TabStop = false;
            this.GrpBox_PlaneTag.Text = "Tag";
            // 
            // GrpBox_PlaneSeats
            // 
            this.GrpBox_PlaneSeats.Controls.Add(this.NUD_PlaneSeats);
            this.GrpBox_PlaneSeats.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GrpBox_PlaneSeats.Location = new System.Drawing.Point(14, 93);
            this.GrpBox_PlaneSeats.Name = "GrpBox_PlaneSeats";
            this.GrpBox_PlaneSeats.Size = new System.Drawing.Size(347, 73);
            this.GrpBox_PlaneSeats.TabIndex = 7;
            this.GrpBox_PlaneSeats.TabStop = false;
            this.GrpBox_PlaneSeats.Text = "Number of seats";
            // 
            // NUD_PlaneSeats
            // 
            this.NUD_PlaneSeats.Location = new System.Drawing.Point(7, 25);
            this.NUD_PlaneSeats.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUD_PlaneSeats.Name = "NUD_PlaneSeats";
            this.NUD_PlaneSeats.Size = new System.Drawing.Size(137, 23);
            this.NUD_PlaneSeats.TabIndex = 0;
            this.NUD_PlaneSeats.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NUD_PlaneSeats.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // GrpBox_PlaneWcs
            // 
            this.GrpBox_PlaneWcs.Controls.Add(this.NUD_PlaneWCS);
            this.GrpBox_PlaneWcs.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GrpBox_PlaneWcs.Location = new System.Drawing.Point(14, 172);
            this.GrpBox_PlaneWcs.Name = "GrpBox_PlaneWcs";
            this.GrpBox_PlaneWcs.Size = new System.Drawing.Size(347, 73);
            this.GrpBox_PlaneWcs.TabIndex = 8;
            this.GrpBox_PlaneWcs.TabStop = false;
            this.GrpBox_PlaneWcs.Text = "Number of bathrooms";
            // 
            // NUD_PlaneWCS
            // 
            this.NUD_PlaneWCS.Location = new System.Drawing.Point(7, 25);
            this.NUD_PlaneWCS.Name = "NUD_PlaneWCS";
            this.NUD_PlaneWCS.Size = new System.Drawing.Size(137, 23);
            this.NUD_PlaneWCS.TabIndex = 0;
            this.NUD_PlaneWCS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GrpBox_Requirements
            // 
            this.GrpBox_Requirements.Controls.Add(this.ChckBox_Food);
            this.GrpBox_Requirements.Controls.Add(this.ChckBox_Wifi);
            this.GrpBox_Requirements.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GrpBox_Requirements.Location = new System.Drawing.Point(14, 330);
            this.GrpBox_Requirements.Name = "GrpBox_Requirements";
            this.GrpBox_Requirements.Size = new System.Drawing.Size(287, 91);
            this.GrpBox_Requirements.TabIndex = 14;
            this.GrpBox_Requirements.TabStop = false;
            this.GrpBox_Requirements.Text = "Features";
            // 
            // ChckBox_Food
            // 
            this.ChckBox_Food.AutoSize = true;
            this.ChckBox_Food.Location = new System.Drawing.Point(138, 46);
            this.ChckBox_Food.Name = "ChckBox_Food";
            this.ChckBox_Food.Size = new System.Drawing.Size(98, 21);
            this.ChckBox_Food.TabIndex = 1;
            this.ChckBox_Food.Text = "Offers food";
            this.ChckBox_Food.UseVisualStyleBackColor = true;
            // 
            // ChckBox_Wifi
            // 
            this.ChckBox_Wifi.AutoSize = true;
            this.ChckBox_Wifi.Location = new System.Drawing.Point(33, 46);
            this.ChckBox_Wifi.Name = "ChckBox_Wifi";
            this.ChckBox_Wifi.Size = new System.Drawing.Size(50, 21);
            this.ChckBox_Wifi.TabIndex = 0;
            this.ChckBox_Wifi.Text = "Wifi";
            this.ChckBox_Wifi.UseVisualStyleBackColor = true;
            // 
            // GrpBox_PlaneCargo
            // 
            this.GrpBox_PlaneCargo.Controls.Add(this.NUD_PlaneCargo);
            this.GrpBox_PlaneCargo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GrpBox_PlaneCargo.Location = new System.Drawing.Point(14, 251);
            this.GrpBox_PlaneCargo.Name = "GrpBox_PlaneCargo";
            this.GrpBox_PlaneCargo.Size = new System.Drawing.Size(347, 73);
            this.GrpBox_PlaneCargo.TabIndex = 9;
            this.GrpBox_PlaneCargo.TabStop = false;
            this.GrpBox_PlaneCargo.Text = "Max Cargo";
            // 
            // NUD_PlaneCargo
            // 
            this.NUD_PlaneCargo.Location = new System.Drawing.Point(7, 25);
            this.NUD_PlaneCargo.Name = "NUD_PlaneCargo";
            this.NUD_PlaneCargo.Size = new System.Drawing.Size(137, 23);
            this.NUD_PlaneCargo.TabIndex = 0;
            this.NUD_PlaneCargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NUD_PlaneCargo.ValueChanged += new System.EventHandler(this.NUD_PlaneCargo_ValueChanged);
            // 
            // FrmAddPlane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 577);
            this.ControlBox = false;
            this.Controls.Add(this.GrpBox_PlaneCargo);
            this.Controls.Add(this.GrpBox_Requirements);
            this.Controls.Add(this.GrpBox_PlaneWcs);
            this.Controls.Add(this.GrpBox_PlaneSeats);
            this.Controls.Add(this.GrpBox_PlaneTag);
            this.Controls.Add(this.GrpBox_Controls);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmAddPlane";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add a Plane";
            this.GrpBox_Controls.ResumeLayout(false);
            this.GrpBox_PlaneTag.ResumeLayout(false);
            this.GrpBox_PlaneTag.PerformLayout();
            this.GrpBox_PlaneSeats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_PlaneSeats)).EndInit();
            this.GrpBox_PlaneWcs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_PlaneWCS)).EndInit();
            this.GrpBox_Requirements.ResumeLayout(false);
            this.GrpBox_Requirements.PerformLayout();
            this.GrpBox_PlaneCargo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_PlaneCargo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpBox_Controls;
        private System.Windows.Forms.Button Btn_FrmAddFlightCancel;
        private System.Windows.Forms.Button Btn_FrmAddFlightAccept;
        private System.Windows.Forms.TextBox TxtBox_PlaneTag;
        private System.Windows.Forms.GroupBox GrpBox_PlaneTag;
        private System.Windows.Forms.GroupBox GrpBox_PlaneSeats;
        private System.Windows.Forms.NumericUpDown NUD_PlaneSeats;
        private System.Windows.Forms.GroupBox GrpBox_PlaneWcs;
        private System.Windows.Forms.NumericUpDown NUD_PlaneWCS;
        private System.Windows.Forms.GroupBox GrpBox_Requirements;
        private System.Windows.Forms.CheckBox ChckBox_Food;
        private System.Windows.Forms.CheckBox ChckBox_Wifi;
        private System.Windows.Forms.GroupBox GrpBox_PlaneCargo;
        private System.Windows.Forms.NumericUpDown NUD_PlaneCargo;
    }
}