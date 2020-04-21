using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class UCDashboard : UserControl, ITournamentRequester
    {
        private List<PrizeModel> prizes = GlobalConfig.Connection.GetPrizes_All();
        private List<TeamModel> teams = GlobalConfig.Connection.GetTeam_All();
        private List<TournamentModel> tournaments = GlobalConfig.Connection.GetTournament_All();
        private List<Button> viewerButtons = new List<Button>();
        public UCDashboard()
        {
            InitializeComponent();
            WireUpLists();
        }
        private void WireUpLists()
        {
            tournamentSelectionComboBox.DataSource = null;

            tournamentSelectionComboBox.DataSource = tournaments;
            tournamentSelectionComboBox.DisplayMember = "TournamentName";
        }

        public void TournamentRefresh(TournamentModel model)
        {
            tournaments.Add(model);
            WireUpLists();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            //TournamentModel model = (TournamentModel)tournamentSelectionComboBox.SelectedItem;
            //TournamentViewerForm viewForm = new TournamentViewerForm(model);
            //viewForm.Show();
        }
    }
}
