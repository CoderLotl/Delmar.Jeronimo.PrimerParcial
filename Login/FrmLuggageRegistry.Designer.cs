namespace UI
{
    partial class FrmLuggageRegistry
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Btn_RmvLuggage = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.Btn_AddLuggage = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Btn_LuggageAccept = new System.Windows.Forms.Button();
            this.Btn_LuggageCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lbl_PassLuggWeight = new System.Windows.Forms.Label();
            this.Lbl_PassLuggWeightAmount = new System.Windows.Forms.Label();
            this.Lbl_HLuggageAmount = new System.Windows.Forms.Label();
            this.Lbl_BaggageAmount = new System.Windows.Forms.Label();
            this.Lbl_HLuggage = new System.Windows.Forms.Label();
            this.Lbl_Baggage = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Lbl_MaxWeight = new System.Windows.Forms.Label();
            this.RdoBtn_LuggageType = new System.Windows.Forms.RadioButton();
            this.Lbl_LuggageWeight = new System.Windows.Forms.Label();
            this.RdoBtn_BaggageType = new System.Windows.Forms.RadioButton();
            this.NUD_LuggageWeight = new System.Windows.Forms.NumericUpDown();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_LuggageWeight)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Btn_RmvLuggage);
            this.groupBox5.Controls.Add(this.treeView1);
            this.groupBox5.Controls.Add(this.Btn_AddLuggage);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(407, 526);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Luggage";
            // 
            // Btn_RmvLuggage
            // 
            this.Btn_RmvLuggage.Enabled = false;
            this.Btn_RmvLuggage.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_RmvLuggage.Location = new System.Drawing.Point(6, 249);
            this.Btn_RmvLuggage.Name = "Btn_RmvLuggage";
            this.Btn_RmvLuggage.Size = new System.Drawing.Size(80, 69);
            this.Btn_RmvLuggage.TabIndex = 14;
            this.Btn_RmvLuggage.Text = "Remove Luggage";
            this.Btn_RmvLuggage.UseVisualStyleBackColor = true;
            this.Btn_RmvLuggage.Click += new System.EventHandler(this.Btn_RmvLuggage_Click);
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.treeView1.Location = new System.Drawing.Point(92, 22);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(309, 486);
            this.treeView1.TabIndex = 12;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // Btn_AddLuggage
            // 
            this.Btn_AddLuggage.Enabled = false;
            this.Btn_AddLuggage.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_AddLuggage.Location = new System.Drawing.Point(6, 53);
            this.Btn_AddLuggage.Name = "Btn_AddLuggage";
            this.Btn_AddLuggage.Size = new System.Drawing.Size(80, 69);
            this.Btn_AddLuggage.TabIndex = 13;
            this.Btn_AddLuggage.Text = "Add Luggage";
            this.Btn_AddLuggage.UseVisualStyleBackColor = true;
            this.Btn_AddLuggage.Click += new System.EventHandler(this.Btn_AddLuggage_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Btn_LuggageAccept);
            this.groupBox4.Controls.Add(this.Btn_LuggageCancel);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(727, 459);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(287, 133);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            // 
            // Btn_LuggageAccept
            // 
            this.Btn_LuggageAccept.Location = new System.Drawing.Point(164, 30);
            this.Btn_LuggageAccept.Name = "Btn_LuggageAccept";
            this.Btn_LuggageAccept.Size = new System.Drawing.Size(117, 69);
            this.Btn_LuggageAccept.TabIndex = 2;
            this.Btn_LuggageAccept.Text = "Accept";
            this.Btn_LuggageAccept.UseVisualStyleBackColor = true;
            this.Btn_LuggageAccept.Click += new System.EventHandler(this.Btn_LuggageAccept_Click);
            // 
            // Btn_LuggageCancel
            // 
            this.Btn_LuggageCancel.Location = new System.Drawing.Point(6, 30);
            this.Btn_LuggageCancel.Name = "Btn_LuggageCancel";
            this.Btn_LuggageCancel.Size = new System.Drawing.Size(117, 69);
            this.Btn_LuggageCancel.TabIndex = 1;
            this.Btn_LuggageCancel.Text = "Cancel";
            this.Btn_LuggageCancel.UseVisualStyleBackColor = true;
            this.Btn_LuggageCancel.Click += new System.EventHandler(this.Btn_LuggageCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lbl_PassLuggWeight);
            this.groupBox1.Controls.Add(this.Lbl_PassLuggWeightAmount);
            this.groupBox1.Controls.Add(this.Lbl_HLuggageAmount);
            this.groupBox1.Controls.Add(this.Lbl_BaggageAmount);
            this.groupBox1.Controls.Add(this.Lbl_HLuggage);
            this.groupBox1.Controls.Add(this.Lbl_Baggage);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(425, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 230);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // Lbl_PassLuggWeight
            // 
            this.Lbl_PassLuggWeight.AutoSize = true;
            this.Lbl_PassLuggWeight.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_PassLuggWeight.Location = new System.Drawing.Point(6, 87);
            this.Lbl_PassLuggWeight.Name = "Lbl_PassLuggWeight";
            this.Lbl_PassLuggWeight.Size = new System.Drawing.Size(172, 22);
            this.Lbl_PassLuggWeight.TabIndex = 5;
            this.Lbl_PassLuggWeight.Text = "Passenger Weight";
            // 
            // Lbl_PassLuggWeightAmount
            // 
            this.Lbl_PassLuggWeightAmount.AutoSize = true;
            this.Lbl_PassLuggWeightAmount.Location = new System.Drawing.Point(259, 85);
            this.Lbl_PassLuggWeightAmount.Name = "Lbl_PassLuggWeightAmount";
            this.Lbl_PassLuggWeightAmount.Size = new System.Drawing.Size(31, 24);
            this.Lbl_PassLuggWeightAmount.TabIndex = 4;
            this.Lbl_PassLuggWeightAmount.Text = "---";
            // 
            // Lbl_HLuggageAmount
            // 
            this.Lbl_HLuggageAmount.AutoSize = true;
            this.Lbl_HLuggageAmount.Location = new System.Drawing.Point(259, 63);
            this.Lbl_HLuggageAmount.Name = "Lbl_HLuggageAmount";
            this.Lbl_HLuggageAmount.Size = new System.Drawing.Size(31, 24);
            this.Lbl_HLuggageAmount.TabIndex = 3;
            this.Lbl_HLuggageAmount.Text = "---";
            // 
            // Lbl_BaggageAmount
            // 
            this.Lbl_BaggageAmount.AutoSize = true;
            this.Lbl_BaggageAmount.Location = new System.Drawing.Point(259, 39);
            this.Lbl_BaggageAmount.Name = "Lbl_BaggageAmount";
            this.Lbl_BaggageAmount.Size = new System.Drawing.Size(31, 24);
            this.Lbl_BaggageAmount.TabIndex = 2;
            this.Lbl_BaggageAmount.Text = "---";
            // 
            // Lbl_HLuggage
            // 
            this.Lbl_HLuggage.AutoSize = true;
            this.Lbl_HLuggage.Location = new System.Drawing.Point(6, 63);
            this.Lbl_HLuggage.Name = "Lbl_HLuggage";
            this.Lbl_HLuggage.Size = new System.Drawing.Size(164, 24);
            this.Lbl_HLuggage.TabIndex = 1;
            this.Lbl_HLuggage.Text = "Hand Luggage";
            // 
            // Lbl_Baggage
            // 
            this.Lbl_Baggage.AutoSize = true;
            this.Lbl_Baggage.Location = new System.Drawing.Point(6, 39);
            this.Lbl_Baggage.Name = "Lbl_Baggage";
            this.Lbl_Baggage.Size = new System.Drawing.Size(106, 24);
            this.Lbl_Baggage.TabIndex = 0;
            this.Lbl_Baggage.Text = "Baggage";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Lbl_MaxWeight);
            this.groupBox2.Controls.Add(this.RdoBtn_LuggageType);
            this.groupBox2.Controls.Add(this.Lbl_LuggageWeight);
            this.groupBox2.Controls.Add(this.RdoBtn_BaggageType);
            this.groupBox2.Controls.Add(this.NUD_LuggageWeight);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(425, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 290);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add luggage";
            // 
            // Lbl_MaxWeight
            // 
            this.Lbl_MaxWeight.AutoSize = true;
            this.Lbl_MaxWeight.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_MaxWeight.Location = new System.Drawing.Point(179, 255);
            this.Lbl_MaxWeight.Name = "Lbl_MaxWeight";
            this.Lbl_MaxWeight.Size = new System.Drawing.Size(91, 17);
            this.Lbl_MaxWeight.TabIndex = 4;
            this.Lbl_MaxWeight.Text = "Max weight: ";
            // 
            // RdoBtn_LuggageType
            // 
            this.RdoBtn_LuggageType.AutoSize = true;
            this.RdoBtn_LuggageType.Location = new System.Drawing.Point(15, 113);
            this.RdoBtn_LuggageType.Name = "RdoBtn_LuggageType";
            this.RdoBtn_LuggageType.Size = new System.Drawing.Size(182, 28);
            this.RdoBtn_LuggageType.TabIndex = 3;
            this.RdoBtn_LuggageType.Text = "Hand Luggage";
            this.RdoBtn_LuggageType.UseVisualStyleBackColor = true;
            this.RdoBtn_LuggageType.CheckedChanged += new System.EventHandler(this.RdoBtn_LuggageType_CheckedChanged);
            // 
            // Lbl_LuggageWeight
            // 
            this.Lbl_LuggageWeight.AutoSize = true;
            this.Lbl_LuggageWeight.Location = new System.Drawing.Point(15, 213);
            this.Lbl_LuggageWeight.Name = "Lbl_LuggageWeight";
            this.Lbl_LuggageWeight.Size = new System.Drawing.Size(132, 24);
            this.Lbl_LuggageWeight.TabIndex = 2;
            this.Lbl_LuggageWeight.Text = "Weight (Kg.)";
            // 
            // RdoBtn_BaggageType
            // 
            this.RdoBtn_BaggageType.AutoSize = true;
            this.RdoBtn_BaggageType.Location = new System.Drawing.Point(15, 64);
            this.RdoBtn_BaggageType.Name = "RdoBtn_BaggageType";
            this.RdoBtn_BaggageType.Size = new System.Drawing.Size(124, 28);
            this.RdoBtn_BaggageType.TabIndex = 1;
            this.RdoBtn_BaggageType.Text = "Baggage";
            this.RdoBtn_BaggageType.UseVisualStyleBackColor = true;
            this.RdoBtn_BaggageType.CheckedChanged += new System.EventHandler(this.RdoBtn_BaggageType_CheckedChanged);
            // 
            // NUD_LuggageWeight
            // 
            this.NUD_LuggageWeight.Location = new System.Drawing.Point(170, 211);
            this.NUD_LuggageWeight.Name = "NUD_LuggageWeight";
            this.NUD_LuggageWeight.Size = new System.Drawing.Size(120, 33);
            this.NUD_LuggageWeight.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBox1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.ForeColor = System.Drawing.Color.GreenYellow;
            this.richTextBox1.Location = new System.Drawing.Point(13, 40);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(217, 293);
            this.richTextBox1.TabIndex = 20;
            this.richTextBox1.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richTextBox1);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(765, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(243, 377);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "X - rays";
            // 
            // FrmLuggageRegistry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 604);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Name = "FrmLuggageRegistry";
            this.ShowInTaskbar = false;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmLuggageRegistry_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_LuggageWeight)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button Btn_RmvLuggage;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button Btn_AddLuggage;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Btn_LuggageAccept;
        private System.Windows.Forms.Button Btn_LuggageCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Lbl_HLuggage;
        private System.Windows.Forms.Label Lbl_Baggage;
        private System.Windows.Forms.Label Lbl_HLuggageAmount;
        private System.Windows.Forms.Label Lbl_BaggageAmount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Lbl_LuggageWeight;
        private System.Windows.Forms.RadioButton RdoBtn_BaggageType;
        private System.Windows.Forms.NumericUpDown NUD_LuggageWeight;
        private System.Windows.Forms.RadioButton RdoBtn_LuggageType;
        private System.Windows.Forms.Label Lbl_MaxWeight;
        private System.Windows.Forms.Label Lbl_PassLuggWeightAmount;
        private System.Windows.Forms.Label Lbl_PassLuggWeight;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}