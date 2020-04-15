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
    public partial class DashBoardForm : Form, ITournamentRequester
    {
        private List<TournamentModel> tournaments = GlobalConfig.Connection.GetTournament_All();
        public DashBoardForm()
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

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            TournamentCreatorForm tourForm = new TournamentCreatorForm(this);
            tourForm.Show();
        }

        public void TournamentRefresh(TournamentModel model)
        {
            tournaments.Add(model);
            WireUpLists();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            TournamentModel model = (TournamentModel)tournamentSelectionComboBox.SelectedItem;
            TournamentViewerForm viewForm = new TournamentViewerForm(model);
            viewForm.Show();
        }
    }
}
