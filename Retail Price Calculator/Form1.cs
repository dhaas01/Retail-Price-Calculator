using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retail_Price_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The CalculateRetail method will take in the wholesale price and the markup percent as arguments.
        // It will calculate and then return the retail price.
        private double CalculateRetail(ref double wholesale, ref double markupPercent)
        {
            return wholesale + (wholesale * (markupPercent / 100));
        }


        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // Variables to hold the retail price, the wholesale price, and the markup percent.
            double retailPrice, wholesale, markupPercent;

            // Get the wholesale price.
            if (double.TryParse(wholesaleTextBox.Text, out wholesale))
            {
                // Get the markup percent.
                if (double.TryParse(markupTextBox.Text, out markupPercent))
                {

                    // Calculate the retail price.
                    retailPrice = CalculateRetail(ref wholesale, ref markupPercent);

                    // Display the retail price.
                    retailPriceLabel.Text = retailPrice.ToString("c");
                }
                else
                {
                    // Display an error message.
                    MessageBox.Show("The value for the markup percentage is invalid.");
                }
            } 
            else
            {
                //  Display an error message.
                MessageBox.Show("The value for the wholesale price is invalid.");
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
