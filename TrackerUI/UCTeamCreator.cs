using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary.Models;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class UCTeamCreator : UserControl
    {
        ITeamRequester callingForm;
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        public UCTeamCreator(ITeamRequester caller)
        {
            InitializeComponent();
            callingForm = caller;
            WireUpLists();
        }
        private void WireUpLists()
        {
            // It has to set the DataSource as null first in order to refresh it later
            selectMemberDropDown.DataSource = null;

            selectMemberDropDown.DataSource = availableTeamMembers;
            selectMemberDropDown.DisplayMember = "FullName";

            selectedmemberListBox.DataSource = null;

            selectedmemberListBox.DataSource = selectedTeamMembers;
            selectedmemberListBox.DisplayMember = "FullName";
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            if (teamNameTextBox.Text.Length != 0 && selectedTeamMembers.Count != 0)
            {
                TeamModel model = new TeamModel();

                model.TeamName = teamNameTextBox.Text;
                model.TeamMembers = selectedTeamMembers;

                GlobalConfig.Connection.CreateTeam(model);

                callingForm.TeamComplete(model);

                // Close the window after click create team button
            }
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

                // Add the new created member to the selectedMemberListBox
                selectedTeamMembers.Add(model);
                WireUpLists();

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

        private void removeMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectedmemberListBox.SelectedItem;

            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                WireUpLists();
            }
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            // Catch the selected item from the dropdown and cast it into a PersonModel
            PersonModel p = (PersonModel)selectMemberDropDown.SelectedItem;

            if (p != null)
            {
                // Remove and add this model 
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                // Refresh the display of the lists
                WireUpLists();
            }
        }
    }
}
