﻿using System;
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
using System.Security.Cryptography;

namespace TrackerUI
{
    public partial class UCDashboard : UserControl
    {
        DashBoardForm callingForm;
        //private List<PrizeModel> prizes = GlobalConfig.Connection.GetPrizes_All();
        //private List<TeamModel> teams = GlobalConfig.Connection.GetTeam_All();
        //private List<TournamentModel> tournaments = GlobalConfig.Connection.GetTournament_All();
        //private List<Button> viewerButtons = new List<Button>();
        public UCDashboard(DashBoardForm caller)
        {
            InitializeComponent();
            callingForm = caller;
            WireUpLists();
        }
        public UCDashboard()
        {

        }
        public void WireUpLists()
        {
            tournamentSelectionComboBox.DataSource = null;

            tournamentSelectionComboBox.DataSource = callingForm.tournaments;
            tournamentSelectionComboBox.DisplayMember = "TournamentName";
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            TournamentModel model = (TournamentModel)tournamentSelectionComboBox.SelectedItem;
            callingForm.changeViewedTournament(model);
        }

        private void tournamentSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
             // = (TournamentModel)tournamentSelectionComboBox.SelectedItem;
        }
    }
}
