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
    public partial class TeamCreatorForm : Form
    {
        public TeamCreatorForm()
        {
            InitializeComponent();
        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                // create a Person after checking the valid of the form
                PersonModel model = new PersonModel();
                model.FirstName = firstNameTextBox.Text;
                model.LastName = lastNameTextbox.Text;
                model.EmailAdress = EmailTextBox.Text;
                model.PhoneNumber = PhoneTextBox.Text;

                GlobalConfig.Connection.CreatePerson(model);

                // reset the fields of the form to default
                firstNameTextBox.Text = "";
                lastNameTextbox.Text = "";
                EmailTextBox.Text = "";
                PhoneTextBox.Text = "";
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            // TODO - Code for ValidateForm
            return output;
        }
    }
}
