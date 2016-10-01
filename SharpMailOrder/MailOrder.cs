using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * 	App name = Sharp Mail Order
    Author's name = Dilpreet Singh
    App	Creation Date = 30/09/16
    App description = The	Company has	instituted	a bonus	program	to give its	
    employees an incentive to sell more. For every dollar the store	makes	in	a	
    four-week	period,	the	employees receive 2	percent	of	sales.	The	
    amount	of	bonus each	employee receives is based	upon the percentage
    of	hours he or	she	worked	during	the bonus	period
 */

namespace SharpMailOrder
{
    public partial class MailOrder : Form
    {
        public MailOrder()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // it checks if input integer value is not greater then 160
            if (Convert.ToInt32(hoursWorkedTextBox.Text) > 160)
            {
                MessageBox.Show("Please provide valid number only smaller then 160");
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void EmployeeIDtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        //  calculate total sales bonus
        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            if (EmployeeNametextBox.Text.Length > 0 && EmployeeIDtextBox.Text.Length > 0 &&
                hoursWorkedTextBox.Text.Length > 0 )
            {
                // get hours worked and divide by 160
                var hoursWorkedPercentage = Convert.ToInt32(hoursWorkedTextBox.Text) / 160;
                // get total bonus and multiple by 0.02
                var totalBonusAmount = Convert.ToInt32(TotalSalesTextBox.Text) * 0.02;
                // finally for sales bonus multiply both fields
                var salesBonus = hoursWorkedPercentage * totalBonusAmount;
                // write the sale bonus to sales bonus text field
                SalesBonusTextBox.Text = Convert.ToString(salesBonus);
            }
            else
            {
                MessageBox.Show("please fill all text values");
            }
        }

        // clear the form

        private void ClearFormButton_Click(object sender, EventArgs e)
        {
            // empty the emplayee name field
            EmployeeNametextBox.Text = String.Empty;
            // empty the emplayee id field
            EmployeeIDtextBox.Text = String.Empty;
           // hoursWorkedTextBox.Text = String.Empty;
           // empty the sales bonus field
            SalesBonusTextBox.Text = String.Empty;
        }

        // print the message to screen

        private void PrintMessageButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("form is being sent to the printer");
        }

        // radio button to convert the form to english language
        private void EnglishLanguageRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (EnglishLanguageRadioButton.Checked)
            {
                // changes the label values to english
                EmployeeNameLabel.Text = "Employee Name";
                EmployeeIDLabel.Text = "Employee ID";
                hoursWorkedLabel.Text = "Hours Worked";
                TotalSalesLabel.Text = "Total Sales";
                SalesBonusLabel.Text = "Sales Bonus";
                CalculateBMIButton.Text = "Calculate";
                PrintMessageButton.Text = "Print";
                ClearFormButton.Text = "Clear";
            }
        }

        // radio button to convert the form to french language
        private void FrenchLanguageRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // change the label values to french
            EmployeeNameLabel.Text = "Nom de l'employé";
            EmployeeIDLabel.Text = "employé ID";
            hoursWorkedLabel.Text = "Heures travaillées";
            TotalSalesLabel.Text = "Ventes totales";
            SalesBonusLabel.Text = "Bonus de vente";
            CalculateBMIButton.Text = "Calculer";
            PrintMessageButton.Text = "Impression";
            ClearFormButton.Text = "Clair";
        }

        private void hoursWorkedLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
