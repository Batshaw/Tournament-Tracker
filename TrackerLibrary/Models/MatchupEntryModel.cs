using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        public MatchupEntryModel()
        {

        }
        public int Id { get; set; }
        public int TeamCompetingId { get; set; } 
        /// <summary>
        /// Represents one team in a matchup.
        /// </summary>
        public TeamModel TeamCompeting = new TeamModel(); // { get; set; }
        /// <summary>
        /// Represents the score of the game for this particular team.
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Represents which Matchup this team came from as the winner.
        /// </summary>
        public MatchupModel ParentMatchup = new MatchupModel(); // { get; set; }
        public int ParentMatchupId { get; set; }
    }
}
