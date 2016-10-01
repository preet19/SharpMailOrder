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
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.EmployeeIDLabel = new System.Windows.Forms.Label();
            this.hoursWorkedLabel = new System.Windows.Forms.Label();
            this.TotalSalesLabel = new System.Windows.Forms.Label();
            this.SalesBonusLabel = new System.Windows.Forms.Label();
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
            this.FrenchLanguageRadioButton.CheckedChanged += new System.EventHandler(this.FrenchLanguageRadioButton_CheckedChanged);
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
            this.EnglishLanguageRadioButton.CheckedChanged += new System.EventHandler(this.EnglishLanguageRadioButton_CheckedChanged);
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
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeNameLabel.Location = new System.Drawing.Point(87, 158);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(135, 16);
            this.EmployeeNameLabel.TabIndex = 7;
            this.EmployeeNameLabel.Text = "Employee\'s Name";
            // 
            // EmployeeIDLabel
            // 
            this.EmployeeIDLabel.AutoSize = true;
            this.EmployeeIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeIDLabel.Location = new System.Drawing.Point(87, 199);
            this.EmployeeIDLabel.Name = "EmployeeIDLabel";
            this.EmployeeIDLabel.Size = new System.Drawing.Size(97, 16);
            this.EmployeeIDLabel.TabIndex = 8;
            this.EmployeeIDLabel.Text = "Employee ID";
            // 
            // hoursWorkedLabel
            // 
            this.hoursWorkedLabel.AutoSize = true;
            this.hoursWorkedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursWorkedLabel.Location = new System.Drawing.Point(87, 244);
            this.hoursWorkedLabel.Name = "hoursWorkedLabel";
            this.hoursWorkedLabel.Size = new System.Drawing.Size(107, 16);
            this.hoursWorkedLabel.TabIndex = 9;
            this.hoursWorkedLabel.Text = "Hours Worked";
            this.hoursWorkedLabel.Click += new System.EventHandler(this.hoursWorkedLabel_Click);
            // 
            // TotalSalesLabel
            // 
            this.TotalSalesLabel.AutoSize = true;
            this.TotalSalesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSalesLabel.Location = new System.Drawing.Point(87, 283);
            this.TotalSalesLabel.Name = "TotalSalesLabel";
            this.TotalSalesLabel.Size = new System.Drawing.Size(88, 16);
            this.TotalSalesLabel.TabIndex = 10;
            this.TotalSalesLabel.Text = "Total Sales";
            this.TotalSalesLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // SalesBonusLabel
            // 
            this.SalesBonusLabel.AutoSize = true;
            this.SalesBonusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesBonusLabel.Location = new System.Drawing.Point(87, 324);
            this.SalesBonusLabel.Name = "SalesBonusLabel";
            this.SalesBonusLabel.Size = new System.Drawing.Size(95, 16);
            this.SalesBonusLabel.TabIndex = 11;
            this.SalesBonusLabel.Text = "Sales Bonus";
            this.SalesBonusLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBMIButton.Location = new System.Drawing.Point(29, 364);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(92, 32);
            this.CalculateBMIButton.TabIndex = 12;
            this.CalculateBMIButton.Text = "Calculate";
            this.CalculateBMIButton.UseVisualStyleBackColor = true;
            this.CalculateBMIButton.Click += new System.EventHandler(this.CalculateBMIButton_Click);
            // 
            // PrintMessageButton
            // 
            this.PrintMessageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintMessageButton.Location = new System.Drawing.Point(174, 364);
            this.PrintMessageButton.Name = "PrintMessageButton";
            this.PrintMessageButton.Size = new System.Drawing.Size(87, 32);
            this.PrintMessageButton.TabIndex = 13;
            this.PrintMessageButton.Text = "Print";
            this.PrintMessageButton.UseVisualStyleBackColor = true;
            this.PrintMessageButton.Click += new System.EventHandler(this.PrintMessageButton_Click);
            // 
            // ClearFormButton
            // 
            this.ClearFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearFormButton.Location = new System.Drawing.Point(310, 364);
            this.ClearFormButton.Name = "ClearFormButton";
            this.ClearFormButton.Size = new System.Drawing.Size(88, 32);
            this.ClearFormButton.TabIndex = 14;
            this.ClearFormButton.Text = "Clear";
            this.ClearFormButton.UseVisualStyleBackColor = true;
            this.ClearFormButton.Click += new System.EventHandler(this.ClearFormButton_Click);
            // 
            // MailOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 413);
            this.Controls.Add(this.ClearFormButton);
            this.Controls.Add(this.PrintMessageButton);
            this.Controls.Add(this.CalculateBMIButton);
            this.Controls.Add(this.SalesBonusLabel);
            this.Controls.Add(this.TotalSalesLabel);
            this.Controls.Add(this.hoursWorkedLabel);
            this.Controls.Add(this.EmployeeIDLabel);
            this.Controls.Add(this.EmployeeNameLabel);
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
        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.Label EmployeeIDLabel;
        private System.Windows.Forms.Label hoursWorkedLabel;
        private System.Windows.Forms.Label TotalSalesLabel;
        private System.Windows.Forms.Label SalesBonusLabel;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.Button PrintMessageButton;
        private System.Windows.Forms.Button ClearFormButton;
    }
}

