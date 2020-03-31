using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        public int Id { get; set; }
        /// <summary>
        /// Represents the name of the tournament.
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Represents the entry fee.
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Represents the list of entered teams.
        /// </summary>
        public List<TeamModel> EnteredTeam { get; set; }
        /// <summary>
        /// Represents the Prize of the Tournament.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; }
        /// <summary>
        /// Represents the Round of the Tournament.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; }
    }
}
