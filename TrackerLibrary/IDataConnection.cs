﻿using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public interface IDataConnection
    {
        /// <summary>
        /// Interface to create/save a PrizeModel
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        PrizeModel CreatePrize(PrizeModel model);
        PersonModel CreatePerson(PersonModel model);
        List<TeamModel> GetTeam_All();
        List<PersonModel> GetPerson_All();
        List<TournamentModel> GetTournament_All();
        TeamModel CreateTeam(TeamModel model);
        List<PrizeModel> GetPrizes_All();
        TournamentModel CreateTournament(TournamentModel model);

        void UpdateMatchup(MatchupModel model);
    }
}
