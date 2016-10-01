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
            // it checks if input integer value is not greater then 150
            if (Convert.ToInt32(hoursWorkedTextBox.Text) > 150)
            {
                MessageBox.Show("Please provide valid number only smaller then 150");
                
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
    }
}
