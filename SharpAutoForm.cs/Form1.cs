using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpAutoForm.cs
{
    public partial class SharpAutoForm : Form
    {
        String lastChecked = "";

        public SharpAutoForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            double newSubtotal = double.Parse(txtAdditionalOptions.Text) + double.Parse(txtBasePrice.Text);


            txtSubTotal.Text = Convert.ToString(newSubtotal);

            txtSalesTax.Text = Convert.ToString(newSubtotal * 0.13);

            txtTotal.Text = Convert.ToString(newSubtotal * 1.13);

            double tradeInAllowance = double.Parse(txtTradeInAllowance.Text);

            double total = newSubtotal * 1.13;

            txtAmountDue.Text = Convert.ToString(total - tradeInAllowance);
        }

        private void checkboxStereoSystem_CheckedChanged(object sender, EventArgs e)
        {


            if(checkboxStereoSystem.Checked == true)
            {
                double currentValue = double.Parse(txtAdditionalOptions.Text);
                txtAdditionalOptions.Text = Convert.ToString(currentValue + 425.76);
            }
            else
            {
                double currentValue = double.Parse(txtAdditionalOptions.Text);
                txtAdditionalOptions.Text = Convert.ToString(currentValue - 425.76);
            }


        }

        private void checkboxLeatherInterior_CheckedChanged(object sender, EventArgs e)
        {
            

            if (checkboxLeatherInterior.Checked == true)
            {
                double currentValue = double.Parse(txtAdditionalOptions.Text);
                txtAdditionalOptions.Text = Convert.ToString(currentValue + 987.41);
            }
            else
            {
                double currentValue = double.Parse(txtAdditionalOptions.Text);
                txtAdditionalOptions.Text = Convert.ToString(currentValue - 987.41);
            }
        }

        private void checkboxComputerNavigation_CheckedChanged(object sender, EventArgs e)
        {

            if (checkboxComputerNavigation.Checked == true)
            {
                double currentValue = double.Parse(txtAdditionalOptions.Text);
                txtAdditionalOptions.Text = Convert.ToString(currentValue + 1741.23);
            }
            else
            {
                double currentValue = double.Parse(txtAdditionalOptions.Text);
                txtAdditionalOptions.Text = Convert.ToString(currentValue - 1741.23);
            }
        }

        private void rdoStandard_CheckedChanged(object sender, EventArgs e)
        {
            
            if (rdoStandard.Checked == true)
            {
                double currentValue = double.Parse(txtAdditionalOptions.Text);
                if (lastChecked == "Pearlized")
                {
                    currentValue = currentValue - 345.72;
                }
                if (lastChecked == "Customized")
                {
                    currentValue = currentValue - 599.99;
                }

                txtAdditionalOptions.Text = Convert.ToString(currentValue);
                lastChecked = "Standard";
            }

        }

        private void rdoPearlized_CheckedChanged(object sender, EventArgs e)
        {

            if (rdoPearlized.Checked == true)
            {
                double currentValue = double.Parse(txtAdditionalOptions.Text) + 345.72;

                if (lastChecked == "Customized")
                {
                    currentValue = currentValue - 599.99;
                }

                txtAdditionalOptions.Text = Convert.ToString(currentValue);
                lastChecked = "Pearlized";
            }
        }

        private void rdoCustomizedDetailing_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCustomizedDetailing.Checked == true)
            {
                double currentValue = double.Parse(txtAdditionalOptions.Text) + 599.99;

                if (lastChecked == "Pearlized")
                {
                    currentValue = currentValue - 345.72;
                }

                txtAdditionalOptions.Text = Convert.ToString(currentValue);
                lastChecked = "Customized";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBasePrice.Clear();
            txtAdditionalOptions.Clear();
            txtSubTotal.Clear();
            txtSalesTax.Clear();
            txtTotal.Clear();
            txtTradeInAllowance.Text = "0";
            txtAmountDue.Clear();

            checkboxStereoSystem.Checked = false;
            checkboxLeatherInterior.Checked = false;
            checkboxComputerNavigation.Checked = false;

            //rdoStandard.Checked = true;


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void caculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCalculate.PerformClick();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnClear.PerformClick();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program calculates the amount due on a New or Used Vehicle");
        }
    }
}
