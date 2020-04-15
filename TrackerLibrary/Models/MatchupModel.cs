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
        /// The ID from database that will be used to look up the Winner as TeamModel
        /// </summary>
        public int WinnerId { get; set; }
        /// <summary>
        /// Represents the round number of this matchup.
        /// </summary>
        public int MatchupRound { get; set; }
        /// <summary>
        /// property to be displayed in TournamentViewerForm
        /// </summary>
        public string DisplayName
        {
            get
            {
                string output = null;

                foreach (var entry in Entries)
                {
                    if (entry.TeamCompeting.TeamName != null)
                    {
                        if (output == null)
                        {
                            output = entry.TeamCompeting.TeamName;
                        }
                        else
                        {
                            output += $" vs. { entry.TeamCompeting.TeamName }";
                        } 
                    }
                    else
                    {
                        output = "Matchup Not Yet Determined";
                        break;
                    }
                }
                return output;
            }
        }
    }
}
