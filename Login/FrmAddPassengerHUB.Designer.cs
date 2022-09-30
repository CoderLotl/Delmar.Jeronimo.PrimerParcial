namespace UI
{
    partial class FrmAddPassengerHUB
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
            this.Btn_AddHubManual = new System.Windows.Forms.Button();
            this.Btn_AddHubRandom = new System.Windows.Forms.Button();
            this.Btn_AddHubCancel = new System.Windows.Forms.Button();
            this.GrpBox_PassHubOpt = new System.Windows.Forms.GroupBox();
            this.GrpBox_PassHubOpt.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_AddHubManual
            // 
            this.Btn_AddHubManual.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_AddHubManual.Location = new System.Drawing.Point(31, 32);
            this.Btn_AddHubManual.Name = "Btn_AddHubManual";
            this.Btn_AddHubManual.Size = new System.Drawing.Size(123, 35);
            this.Btn_AddHubManual.TabIndex = 0;
            this.Btn_AddHubManual.Text = "Manual";
            this.Btn_AddHubManual.UseVisualStyleBackColor = true;
            this.Btn_AddHubManual.Click += new System.EventHandler(this.Btn_AddHubManual_Click);
            // 
            // Btn_AddHubRandom
            // 
            this.Btn_AddHubRandom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_AddHubRandom.Location = new System.Drawing.Point(31, 100);
            this.Btn_AddHubRandom.Name = "Btn_AddHubRandom";
            this.Btn_AddHubRandom.Size = new System.Drawing.Size(123, 35);
            this.Btn_AddHubRandom.TabIndex = 1;
            this.Btn_AddHubRandom.Text = "Random";
            this.Btn_AddHubRandom.UseVisualStyleBackColor = true;
            this.Btn_AddHubRandom.Click += new System.EventHandler(this.Btn_AddHubRandom_Click);
            // 
            // Btn_AddHubCancel
            // 
            this.Btn_AddHubCancel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_AddHubCancel.Location = new System.Drawing.Point(252, 154);
            this.Btn_AddHubCancel.Name = "Btn_AddHubCancel";
            this.Btn_AddHubCancel.Size = new System.Drawing.Size(120, 50);
            this.Btn_AddHubCancel.TabIndex = 2;
            this.Btn_AddHubCancel.Text = "Go back";
            this.Btn_AddHubCancel.UseVisualStyleBackColor = true;
            this.Btn_AddHubCancel.Click += new System.EventHandler(this.Btn_AddHubCancel_Click);
            // 
            // GrpBox_PassHubOpt
            // 
            this.GrpBox_PassHubOpt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GrpBox_PassHubOpt.Controls.Add(this.Btn_AddHubManual);
            this.GrpBox_PassHubOpt.Controls.Add(this.Btn_AddHubRandom);
            this.GrpBox_PassHubOpt.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GrpBox_PassHubOpt.ForeColor = System.Drawing.SystemColors.Control;
            this.GrpBox_PassHubOpt.Location = new System.Drawing.Point(12, 12);
            this.GrpBox_PassHubOpt.Name = "GrpBox_PassHubOpt";
            this.GrpBox_PassHubOpt.Size = new System.Drawing.Size(200, 172);
            this.GrpBox_PassHubOpt.TabIndex = 3;
            this.GrpBox_PassHubOpt.TabStop = false;
            this.GrpBox_PassHubOpt.Text = "Options";
            // 
            // FrmAddPassengerHUB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 227);
            this.ControlBox = false;
            this.Controls.Add(this.GrpBox_PassHubOpt);
            this.Controls.Add(this.Btn_AddHubCancel);
            this.Name = "FrmAddPassengerHUB";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.GrpBox_PassHubOpt.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_AddHubManual;
        private System.Windows.Forms.Button Btn_AddHubRandom;
        private System.Windows.Forms.Button Btn_AddHubCancel;
        private System.Windows.Forms.GroupBox GrpBox_PassHubOpt;
    }
}