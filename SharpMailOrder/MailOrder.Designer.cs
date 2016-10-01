namespace SharpMailOrder
{
    partial class MailOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailOrder));
            this.LogopictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.FrenchLanguageRadioButton = new System.Windows.Forms.RadioButton();
            this.EnglishLanguageRadioButton = new System.Windows.Forms.RadioButton();
            this.EmployeeNametextBox = new System.Windows.Forms.TextBox();
            this.EmployeeIDtextBox = new System.Windows.Forms.TextBox();
            this.hoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.TotalSalesTextBox = new System.Windows.Forms.TextBox();
            this.SalesBonusTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.PrintMessageButton = new System.Windows.Forms.Button();
            this.ClearFormButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogopictureBox)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogopictureBox
            // 
            this.LogopictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogopictureBox.Image")));
            this.LogopictureBox.Location = new System.Drawing.Point(12, 12);
            this.LogopictureBox.Name = "LogopictureBox";
            this.LogopictureBox.Size = new System.Drawing.Size(194, 115);
            this.LogopictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogopictureBox.TabIndex = 0;
            this.LogopictureBox.TabStop = false;
            this.LogopictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.FrenchLanguageRadioButton);
            this.groupBox.Controls.Add(this.EnglishLanguageRadioButton);
            this.groupBox.Location = new System.Drawing.Point(251, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(212, 115);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Languages";
            this.groupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // FrenchLanguageRadioButton
            // 
            this.FrenchLanguageRadioButton.AutoSize = true;
            this.FrenchLanguageRadioButton.Location = new System.Drawing.Point(43, 63);
            this.FrenchLanguageRadioButton.Name = "FrenchLanguageRadioButton";
            this.FrenchLanguageRadioButton.Size = new System.Drawing.Size(65, 17);
            this.FrenchLanguageRadioButton.TabIndex = 0;
            this.FrenchLanguageRadioButton.Text = "Français";
            this.FrenchLanguageRadioButton.UseVisualStyleBackColor = true;
            // 
            // EnglishLanguageRadioButton
            // 
            this.EnglishLanguageRadioButton.AutoSize = true;
            this.EnglishLanguageRadioButton.Checked = true;
            this.EnglishLanguageRadioButton.Location = new System.Drawing.Point(43, 40);
            this.EnglishLanguageRadioButton.Name = "EnglishLanguageRadioButton";
            this.EnglishLanguageRadioButton.Size = new System.Drawing.Size(59, 17);
            this.EnglishLanguageRadioButton.TabIndex = 0;
            this.EnglishLanguageRadioButton.TabStop = true;
            this.EnglishLanguageRadioButton.Text = "English";
            this.EnglishLanguageRadioButton.UseVisualStyleBackColor = true;
            // 
            // EmployeeNametextBox
            // 
            this.EmployeeNametextBox.Location = new System.Drawing.Point(251, 158);
            this.EmployeeNametextBox.Name = "EmployeeNametextBox";
            this.EmployeeNametextBox.Size = new System.Drawing.Size(100, 20);
            this.EmployeeNametextBox.TabIndex = 2;
            // 
            // EmployeeIDtextBox
            // 
            this.EmployeeIDtextBox.Location = new System.Drawing.Point(253, 199);
            this.EmployeeIDtextBox.Name = "EmployeeIDtextBox";
            this.EmployeeIDtextBox.Size = new System.Drawing.Size(100, 20);
            this.EmployeeIDtextBox.TabIndex = 3;
            this.EmployeeIDtextBox.TextChanged += new System.EventHandler(this.EmployeeIDtextBox_TextChanged);
            // 
            // hoursWorkedTextBox
            // 
            this.hoursWorkedTextBox.Location = new System.Drawing.Point(252, 244);
            this.hoursWorkedTextBox.Name = "hoursWorkedTextBox";
            this.hoursWorkedTextBox.Size = new System.Drawing.Size(100, 20);
            this.hoursWorkedTextBox.TabIndex = 4;
            this.hoursWorkedTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // TotalSalesTextBox
            // 
            this.TotalSalesTextBox.Location = new System.Drawing.Point(253, 283);
            this.TotalSalesTextBox.Name = "TotalSalesTextBox";
            this.TotalSalesTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalSalesTextBox.TabIndex = 5;
            this.TotalSalesTextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // SalesBonusTextBox
            // 
            this.SalesBonusTextBox.Location = new System.Drawing.Point(253, 324);
            this.SalesBonusTextBox.Name = "SalesBonusTextBox";
            this.SalesBonusTextBox.ReadOnly = true;
            this.SalesBonusTextBox.Size = new System.Drawing.Size(100, 20);
            this.SalesBonusTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Employee\'s Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Employee ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hours Worked";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total Sales";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sales Bonus";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.Location = new System.Drawing.Point(29, 364);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(92, 32);
            this.CalculateBMIButton.TabIndex = 12;
            this.CalculateBMIButton.Text = "Calculate";
            this.CalculateBMIButton.UseVisualStyleBackColor = true;
            // 
            // PrintMessageButton
            // 
            this.PrintMessageButton.Location = new System.Drawing.Point(174, 364);
            this.PrintMessageButton.Name = "PrintMessageButton";
            this.PrintMessageButton.Size = new System.Drawing.Size(87, 32);
            this.PrintMessageButton.TabIndex = 13;
            this.PrintMessageButton.Text = "Print";
            this.PrintMessageButton.UseVisualStyleBackColor = true;
            // 
            // ClearFormButton
            // 
            this.ClearFormButton.Location = new System.Drawing.Point(310, 364);
            this.ClearFormButton.Name = "ClearFormButton";
            this.ClearFormButton.Size = new System.Drawing.Size(88, 32);
            this.ClearFormButton.TabIndex = 14;
            this.ClearFormButton.Text = "Clear";
            this.ClearFormButton.UseVisualStyleBackColor = true;
            // 
            // MailOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 413);
            this.Controls.Add(this.ClearFormButton);
            this.Controls.Add(this.PrintMessageButton);
            this.Controls.Add(this.CalculateBMIButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SalesBonusTextBox);
            this.Controls.Add(this.TotalSalesTextBox);
            this.Controls.Add(this.hoursWorkedTextBox);
            this.Controls.Add(this.EmployeeIDtextBox);
            this.Controls.Add(this.EmployeeNametextBox);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.LogopictureBox);
            this.Name = "MailOrder";
            this.Text = "Sales Bonus";
            ((System.ComponentModel.ISupportInitialize)(this.LogopictureBox)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogopictureBox;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton FrenchLanguageRadioButton;
        private System.Windows.Forms.RadioButton EnglishLanguageRadioButton;
        private System.Windows.Forms.TextBox EmployeeNametextBox;
        private System.Windows.Forms.TextBox EmployeeIDtextBox;
        private System.Windows.Forms.TextBox hoursWorkedTextBox;
        private System.Windows.Forms.TextBox TotalSalesTextBox;
        private System.Windows.Forms.TextBox SalesBonusTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.Button PrintMessageButton;
        private System.Windows.Forms.Button ClearFormButton;
    }
}

