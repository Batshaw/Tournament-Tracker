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

            WireUpLists();

            LoadFormData();
            LoadRounds();
        }
        private void WireUpLists()
        {
            roundsBinding.DataSource = rounds;
            roundDropDown.DataSource = roundsBinding;

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
            LoadMatchups(1);
        }

        private void roundDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)roundDropDown.SelectedItem);
            LoadMatchupForScoreSection((MatchupModel)matchupListBox.SelectedItem);
        }
        private void LoadMatchups(int round)
        {
            foreach (var matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound == round)
                {
                    // selectedMatchup = matchups;
                    selectedMatchup.Clear();
                    foreach (var matchup in matchups.ToList())
                    {
                        // winner == null means unplayed match
                        if (matchup.Winner == null || !uplayedOnlyCheckBox.Checked)
                        {
                            selectedMatchup.Add(matchup);
                            // matchupsBinding.ResetBindings(false);
                        } 
                    }
                }
            }
            // WireUpMatchListBox();
            matchupsBinding.ResetBindings(false);
            WireUpLists();
        }

        private void LoadMatchupForScoreSection(MatchupModel model)
        {
            if (model != null)
            {
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
            DisplayMatchupInfo();
        }
        private void DisplayMatchupInfo()
        {
            bool isVisible = selectedMatchup.Count > 0;

            team1NameLabel.Visible = isVisible;
            team1ScoreLabel.Visible = isVisible;
            team1ScoreTextBox.Visible = isVisible;
            team2NameLabel.Visible = isVisible;
            team2ScoreLabel.Visible = isVisible;
            team2ScoreTextBox.Visible = isVisible;
            versusLabel.Visible = isVisible;
            scoreButton.Visible = isVisible;

        }
        private void matchupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchupForScoreSection((MatchupModel)matchupListBox.SelectedItem);
        }

        private void uplayedOnlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)roundDropDown.SelectedItem);
        }

        private void scoreButton_Click(object sender, EventArgs e)
        {
            MatchupModel matchup = (MatchupModel)matchupListBox.SelectedItem;
            double team1Score = 0;
            double team2Score = 0;

            for (int i = 0; i < matchup.Entries.Count; i++)
            {
                if (i == 0)
                {
                    bool scoreValid = double.TryParse(team1ScoreTextBox.Text, out team1Score);
                    if (scoreValid)
                    {
                        matchup.Entries[0].Score = team1Score; 
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid score!!!");
                        return;
                    }
                }
                if (i == 1)
                {
                    bool scoreValid = double.TryParse(team2ScoreTextBox.Text, out team2Score);
                    if (scoreValid)
                    {
                        matchup.Entries[1].Score = team2Score;
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid score!!!");
                        return;
                    }
                }
            }

            if (team1Score > team2Score)
            {
                // Team 1 wins
                matchup.Winner = matchup.Entries[0].TeamCompeting;
            }
            else if (team2Score > team1Score)
            {
                matchup.Winner = matchup.Entries[1].TeamCompeting;
            }
            else
            {
                MessageBox.Show("This app do not handle tie games. (not an even score");
            }
            LoadMatchups((int)roundDropDown.SelectedItem);
            LoadMatchupForScoreSection((MatchupModel)matchupListBox.SelectedItem);
        }
    }
}
