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
        private List<PersonModel> availableTeamMembers = new List<PersonModel>();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();

        public TeamCreatorForm()
        {
            InitializeComponent();

            // Add sample data to the lists
            SampleData();

            // Set the data to the list and display them to the form.
            WireUpLists();
        }

        // Method to temporary test the effects of WireUpLists()
        private void SampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Nhu Quang", LastName = "Dang" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Truc Anh", LastName = "Nguyen" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Duy Khanh", LastName = "Tong" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Nhat Linh", LastName = "Hoang" });
        }

        private void WireUpLists()
        {
            selectMemberDropDown.DataSource = availableTeamMembers;
            selectMemberDropDown.DisplayMember = "FullName";

            selectedmemberListBox.DataSource = selectedTeamMembers;
            selectedmemberListBox.DisplayMember = "FullName";
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
            else
            {
                MessageBox.Show("You need to fill in all of the fields first!");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;

            if (firstNameTextBox.Text.Length == 0)
            {
                output = false;
            }
            if (lastNameTextbox.Text.Length == 0)
            {
                output = false;
            }
            if (EmailTextBox.Text.Length == 0)
            {
                output = false;
            }
            if (PhoneTextBox.Text.Length == 0)
            {
                output = false;
            }

            return output;
        }
    }
}
