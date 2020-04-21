using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class DashBoardForm : Form, ITournamentRequester, IPrizeRequester, ITeamRequester
    {
        private List<PrizeModel> prizes = GlobalConfig.Connection.GetPrizes_All();
        private List<TeamModel> teams = GlobalConfig.Connection.GetTeam_All();
        private List<TournamentModel> tournaments = GlobalConfig.Connection.GetTournament_All();
        private List<Button> viewerButtons = new List<Button>();
        public TournamentModel toShowTournament = new TournamentModel();
        public DashBoardForm()
        {

            InitializeComponent();
            AddButton();
            ucDashboard.BringToFront();
            homeButton.FlatAppearance.BorderSize = 2;
            homeButton.FlatAppearance.BorderColor = Color.FromArgb(62, 127, 121);
            resetBorderLook(homeButton);
            WireUpLists();
        }

        private void AddButton()
        {
            viewerButtons.Add(createPrizeViewerButton);
            viewerButtons.Add(creatTeamViewerButton);
            viewerButtons.Add(tournamentViewButton);
            viewerButtons.Add(createTournamentButton);
            viewerButtons.Add(homeButton);
        }

        private void WireUpLists()
        {
            //tournamentSelectionComboBox.DataSource = null;

            //tournamentSelectionComboBox.DataSource = tournaments;
            //tournamentSelectionComboBox.DisplayMember = "TournamentName";
        }
        public void TournamentRefresh(TournamentModel model)
        {
            tournaments.Add(model);
            WireUpLists();
        }
        public void PrizeComplete(PrizeModel model)
        {
            prizes.Add(model);
            WireUpLists();
        }
        public void TeamComplete(TeamModel model)
        {
            teams.Add(model);
            WireUpLists();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            //TournamentModel model = (TournamentModel)tournamentSelectionComboBox.SelectedItem;
            //this.ucTournamentViewer = new UCTournamentViewer(model);
            //ucTournamentViewer.BringToFront();
            //resetBorderLook(tournamentViewButton);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            TournamentCreatorForm tourForm = new TournamentCreatorForm(this);
            // tourForm.Show();
            ucTournamentCreator.BringToFront();
            resetBorderLook(createTournamentButton);
        }
        private void tournamentViewButton_Click(object sender, EventArgs e)
        {
            ucTournamentViewer.BringToFront();
            resetBorderLook(tournamentViewButton);
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            ucDashboard.BringToFront();
            resetBorderLook(homeButton);
        }

        private void creatTeamViewerButton_Click(object sender, EventArgs e)
        {
            ucTeamCreator.BringToFront();
            resetBorderLook(creatTeamViewerButton);
        }

        private void createPrizeViewerButton_Click(object sender, EventArgs e)
        {
            ucPrizeCreator.BringToFront();
            resetBorderLook(createPrizeViewerButton);
        }
        private void resetBorderLook(Button withoutThis)
        {
            withoutThis.BringToFront();
            withoutThis.FlatAppearance.BorderSize = 2;
            withoutThis.FlatAppearance.BorderColor = Color.FromArgb(62, 127, 121);
            activePanel.Top = withoutThis.Top;
            activePanel.Height = withoutThis.Height;
            foreach (var button in viewerButtons)
            {
                if (button != withoutThis)
                {
                    button.FlatAppearance.BorderSize = 1;
                    button.FlatAppearance.BorderColor = Color.WhiteSmoke;
                }
            }
            
        }
        public void changeViewedTournament(TournamentModel model)
        {
            // firstTournament = model;
            this.ucTournamentViewer.tournament = model;
            this.ucTournamentViewer.RefreshTournament();
            this.ucTournamentViewer.BringToFront();
            resetBorderLook(tournamentViewButton);
        }

        private void ucTournamentViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
