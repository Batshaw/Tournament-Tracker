using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class PrizeCreatorForm : Form
    {
        public PrizeCreatorForm()
        {
            InitializeComponent();
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                // create a Prize ater checking the valid of the form.
                PrizeModel model = new PrizeModel(placeNameTextBox.Text,
                                                  placeNumberTextBox.Text,
                                                  prizeAmountTextBox.Text,
                                                  prizePercentageTextBox.Text);

                // save the prize for each Connection (SQL and TextFile)
                foreach (var db in GlobalConfig.Connections)
                {
                    db.CreatePrize(model);
                }

                // reset the fields of the form to default
                placeNameTextBox.Text = "";
                placeNumberTextBox.Text = "";
                prizeAmountTextBox.Text = "0";
                prizePercentageTextBox.Text = "0";

            }
            else
            {
                MessageBox.Show("This form has invalid information!!!");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValid = int.TryParse(placeNumberTextBox.Text, out placeNumber);

            if (!placeNumberValid)     //check if the convert of the text into int is done and output the result of the convert
            {
                output = false;
            }

            if (placeNumber < 1)
            {
                output = false;
            }

            if (placeNameTextBox.Text.Length == 0)
            {
                output = false;
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;
            bool prizeAmountValid = decimal.TryParse(prizeAmountTextBox.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(prizePercentageTextBox.Text, out prizePercentage);

            if (prizeAmountValid == false || prizePercentageValid == false)
            {
                output = false;
            }

            if (prizePercentage <= 0 && prizeAmount <= 0)
            {
                output = false;
            }
            if (prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }
            
            return output;
        }
    }
}
