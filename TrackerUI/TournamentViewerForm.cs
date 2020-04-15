using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class TournamentViewerForm : Form
    {
        private TournamentModel tournament;
        List<int> rounds = new List<int>();
        List<MatchupModel> selectedMatchup = new List<MatchupModel>();

        BindingSource roundsBinding = new BindingSource();
        BindingSource matchupsBinding = new BindingSource();

        public TournamentViewerForm(TournamentModel model)
        {
            InitializeComponent();
            tournament = model;

            WireUpRoundDropDown();
            WireUpMatchListBox();

            LoadFormData();
            LoadRounds();
        }
        private void WireUpRoundDropDown()
        {
            // roundDropDown.DataSource = null;
            roundsBinding.DataSource = rounds;

            roundDropDown.DataSource = roundsBinding;
        }
        private void WireUpMatchListBox()
        {
            // matchupListBox.DataSource = null;

            matchupsBinding.DataSource = selectedMatchup;
            matchupListBox.DataSource = matchupsBinding;
            matchupListBox.DisplayMember = "DisplayName";
        }

        private void LoadFormData()
        {
            tournamentName.Text = tournament.TournamentName;
        }
        private void LoadRounds()
        {
            rounds.Clear();
            rounds.Add(1);
            int currentRound = 1;
            foreach (var matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound > currentRound)
                {
                    currentRound = matchups.First().MatchupRound;
                    rounds.Add(currentRound);                    
                }
            }
            // WireUpRoundDropDown();
            roundsBinding.ResetBindings(false);
        }

        private void scoreButton_Click(object sender, EventArgs e)
        {

        }

        private void roundDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups();
        }
        private void LoadMatchups()
        {
            int round = (int)roundDropDown.SelectedItem;
            foreach (var matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound == round)
                {
                    selectedMatchup = matchups;
                }
            }
            // WireUpMatchListBox();
            matchupsBinding.ResetBindings(false);
            WireUpMatchListBox();
        }

        private void LoadMatchupForScoreSection()
        {
            MatchupModel model = (MatchupModel)matchupListBox.SelectedItem;
            for (int i = 0; i < model.Entries.Count; i++)
            {
                if (model.Entries.Count == 1)
                {
                    team2NameLabel.Text = "<none>";
                    team2ScoreTextBox.Text = "";
                }
                if (i == 0)
                {
                    if (model.Entries[0].TeamCompeting.TeamName != null)
                    {
                        team1NameLabel.Text = model.Entries[0].TeamCompeting.TeamName;
                        team1ScoreTextBox.Text = model.Entries[0].Score.ToString();
                    }
                    else
                    {
                        team1NameLabel.Text = "Not Yet Set";
                        team1ScoreTextBox.Text = "";
                    }
                }
                if (i == 1)
                {
                    if (model.Entries[1].TeamCompeting.TeamName != null)
                    {
                        team2NameLabel.Text = model.Entries[1].TeamCompeting.TeamName;
                        team2ScoreTextBox.Text = model.Entries[1].Score.ToString();
                    }
                    else
                    {
                        team2NameLabel.Text = "Not Yet Set";
                        team2ScoreTextBox.Text = "";
                    }
                }
            }
        }
        private void matchupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchupForScoreSection();
        }
    }
}
