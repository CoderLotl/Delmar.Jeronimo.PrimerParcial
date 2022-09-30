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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GrpBox_PlaneTag = new System.Windows.Forms.GroupBox();
            this.GrpBox_PlaneSeats = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.GrpBox_PlaneWcs = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.GrpBox_Requirements = new System.Windows.Forms.GroupBox();
            this.ChckBox_Food = new System.Windows.Forms.CheckBox();
            this.ChckBox_Wifi = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.GrpBox_Controls.SuspendLayout();
            this.GrpBox_PlaneTag.SuspendLayout();
            this.GrpBox_PlaneSeats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.GrpBox_PlaneWcs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.GrpBox_Requirements.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpBox_Controls
            // 
            this.GrpBox_Controls.Controls.Add(this.Btn_FrmAddFlightCancel);
            this.GrpBox_Controls.Controls.Add(this.Btn_FrmAddFlightAccept);
            this.GrpBox_Controls.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GrpBox_Controls.Location = new System.Drawing.Point(244, 463);
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
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 23);
            this.textBox1.TabIndex = 5;
            // 
            // GrpBox_PlaneTag
            // 
            this.GrpBox_PlaneTag.Controls.Add(this.textBox1);
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
            this.GrpBox_PlaneSeats.Controls.Add(this.numericUpDown1);
            this.GrpBox_PlaneSeats.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GrpBox_PlaneSeats.Location = new System.Drawing.Point(14, 93);
            this.GrpBox_PlaneSeats.Name = "GrpBox_PlaneSeats";
            this.GrpBox_PlaneSeats.Size = new System.Drawing.Size(347, 73);
            this.GrpBox_PlaneSeats.TabIndex = 7;
            this.GrpBox_PlaneSeats.TabStop = false;
            this.GrpBox_PlaneSeats.Text = "Number of seats";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(7, 25);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(137, 23);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GrpBox_PlaneWcs
            // 
            this.GrpBox_PlaneWcs.Controls.Add(this.numericUpDown2);
            this.GrpBox_PlaneWcs.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GrpBox_PlaneWcs.Location = new System.Drawing.Point(14, 172);
            this.GrpBox_PlaneWcs.Name = "GrpBox_PlaneWcs";
            this.GrpBox_PlaneWcs.Size = new System.Drawing.Size(347, 73);
            this.GrpBox_PlaneWcs.TabIndex = 8;
            this.GrpBox_PlaneWcs.TabStop = false;
            this.GrpBox_PlaneWcs.Text = "Number of bathrooms";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(7, 25);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(137, 23);
            this.numericUpDown2.TabIndex = 0;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown3);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(14, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 73);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Number of bathrooms";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(7, 25);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(137, 23);
            this.numericUpDown3.TabIndex = 0;
            this.numericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FrmAddPlane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 593);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.GrpBox_PlaneWcs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.GrpBox_Requirements.ResumeLayout(false);
            this.GrpBox_Requirements.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpBox_Controls;
        private System.Windows.Forms.Button Btn_FrmAddFlightCancel;
        private System.Windows.Forms.Button Btn_FrmAddFlightAccept;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox GrpBox_PlaneTag;
        private System.Windows.Forms.GroupBox GrpBox_PlaneSeats;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox GrpBox_PlaneWcs;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.GroupBox GrpBox_Requirements;
        private System.Windows.Forms.CheckBox ChckBox_Food;
        private System.Windows.Forms.CheckBox ChckBox_Wifi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
    }
}