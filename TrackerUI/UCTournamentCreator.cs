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
    public partial class UCTournamentCreator : UserControl
    {
        DashBoardForm callingForm;
        private List<TeamModel> availabelTeams = GlobalConfig.Connection.GetTeam_All();
        private List<TeamModel> selectedTeams = new List<TeamModel>();
        private List<PrizeModel> selectedPrizes = GlobalConfig.Connection.GetPrizes_All();
        public UCTournamentCreator(DashBoardForm caller)
        {
            InitializeComponent();
            callingForm = caller;
            WireUpLists();
        }
        public void WireUpLists()
        {
            teamSelectDropDown.DataSource = null;
            teamSelectDropDown.DataSource = availabelTeams;
            teamSelectDropDown.DisplayMember = "TeamName";

            teamsPlayersListBox.DataSource = null;
            teamsPlayersListBox.DataSource = selectedTeams;
            teamsPlayersListBox.DisplayMember = "TeamName";

            prizeListBox.DataSource = null;
            prizeListBox.DataSource = selectedPrizes;
            prizeListBox.DisplayMember = "PlaceName";
        }

        public void TeamComplete(TeamModel model)
        {
            availabelTeams.Add(model);
            WireUpLists();
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            // Validate data
            decimal fee = 0;

            // Check if it could convert to decimal and output it to fee
            bool feeAceeptable = decimal.TryParse(entryFeeTextBox.Text, out fee);
            if (!feeAceeptable)
            {
                MessageBox.Show("You need to enter a valid Entry Fee",
                                "Invalid Fee",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // Create Tournament Entry
            TournamentModel tm = new TournamentModel();

            tm.TournamentName = tournamentNameTextBox.Text;
            tm.EntryFee = fee;    // decimal.Parse(entryFeeTextBox.Text);

            tm.Prizes = selectedPrizes;
            tm.EnteredTeam = selectedTeams;

            // Wire our matchups
            TournamentLogic.CreateRounds(tm);

            // Creat all of the prizes entries
            // Creat all of the team entries
            GlobalConfig.Connection.CreateTournament(tm);

            // call this function to move all the matchups with only 1 entry into the next round
            TournamentLogic.UpdateTournamentResult(tm);

            // sending the created tournamnet direct to the dashboard
            callingForm.TournamentComplete(tm);
            callingForm.changeToDashboard();
        }

        private void teamCreatorLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // TODO - teamCreatorLinkLabel_LinkClicked
            callingForm.changeToTeamCreator();
        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel p = (TeamModel)(teamSelectDropDown.SelectedItem);

            if (p != null)
            {
                selectedTeams.Add(p);
                availabelTeams.Remove(p);
            }
            WireUpLists();
        }

        private void deleteTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel p = (TeamModel)(teamsPlayersListBox.SelectedItem);

            if (p != null)
            {
                availabelTeams.Add(p);
                selectedTeams.Remove(p);
            }
            WireUpLists();
        }

        private void deletePrizeButton_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)(prizeListBox.SelectedItem);

            if (p != null)
            {
                selectedPrizes.Remove(p);
            }
            WireUpLists();
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            // TODO - createPrizeButton_Click
            callingForm.changeToPrizeCreator();
        }
    }
}
