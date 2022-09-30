namespace UI
{
    partial class FrmRandomClient
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
            this.NUD_RdmClients = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_RdmAccept = new System.Windows.Forms.Button();
            this.Btn_RdmCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_RdmClients)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NUD_RdmClients
            // 
            this.NUD_RdmClients.Location = new System.Drawing.Point(24, 33);
            this.NUD_RdmClients.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_RdmClients.Name = "NUD_RdmClients";
            this.NUD_RdmClients.Size = new System.Drawing.Size(93, 23);
            this.NUD_RdmClients.TabIndex = 0;
            this.NUD_RdmClients.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NUD_RdmClients.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_RdmAccept);
            this.groupBox1.Controls.Add(this.Btn_RdmCancel);
            this.groupBox1.Location = new System.Drawing.Point(196, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 148);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // Btn_RdmAccept
            // 
            this.Btn_RdmAccept.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_RdmAccept.Location = new System.Drawing.Point(151, 60);
            this.Btn_RdmAccept.Name = "Btn_RdmAccept";
            this.Btn_RdmAccept.Size = new System.Drawing.Size(119, 43);
            this.Btn_RdmAccept.TabIndex = 1;
            this.Btn_RdmAccept.Text = "Generate";
            this.Btn_RdmAccept.UseVisualStyleBackColor = true;
            this.Btn_RdmAccept.Click += new System.EventHandler(this.Btn_RdmAccept_Click);
            // 
            // Btn_RdmCancel
            // 
            this.Btn_RdmCancel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_RdmCancel.Location = new System.Drawing.Point(6, 60);
            this.Btn_RdmCancel.Name = "Btn_RdmCancel";
            this.Btn_RdmCancel.Size = new System.Drawing.Size(119, 43);
            this.Btn_RdmCancel.TabIndex = 0;
            this.Btn_RdmCancel.Text = "Cancel";
            this.Btn_RdmCancel.UseVisualStyleBackColor = true;
            this.Btn_RdmCancel.Click += new System.EventHandler(this.Btn_RdmCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NUD_RdmClients);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(27, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(138, 82);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Amount of Clients";
            // 
            // FrmRandomPassenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 215);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRandomPassenger";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.NUD_RdmClients)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NUD_RdmClients;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_RdmCancel;
        private System.Windows.Forms.Button Btn_RdmAccept;
    }
}