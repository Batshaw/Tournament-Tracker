using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        public int Id { get; set; }
        /// <summary>
        /// List of the MatchupEntry in this Matchup.
        /// </summary>
        public List<MatchupEntryModel> Entries = new List<MatchupEntryModel>();// { get; set; }
        /// <summary>
        /// Represents the winner of this Matchup.
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Represents the round number of this matchup.
        /// </summary>
        public int MatchupRound { get; set; }

    }
}
