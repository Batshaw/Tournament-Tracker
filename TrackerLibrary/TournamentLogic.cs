using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public static class TournamentLogic
    {
        // Oder our list randomly of teams
        // Check if tis big enough, if not, add in a fill-in
        // Create first round of matchups
        // Create every round after that

        public static void CreateRounds(TournamentModel tournament)
        {
            List<TeamModel> randomizedTeams = RandomizeTeamOrder(tournament.EnteredTeam);
            int rounds = FindNumberOfRounds(randomizedTeams.Count());
            int numberOfFillInTeams = NumberOfFillInTeams(rounds, randomizedTeams.Count());

        }

        private static List<MatchupModel> CreateFirstRound(int numberOfFillInTeams, List<TeamModel> teams)
        {
            List<MatchupModel> output = new List<MatchupModel>();
            MatchupModel current = new MatchupModel();

            foreach (var team in teams)
            {
                current.Entries.Add(new MatchupEntryModel { TeamCompeting = team });
                if (numberOfFillInTeams > 0 || current.Entries.Count() > 1)
                {
                    current.MatchupRound = 1;       // Here is the first Round
                    output.Add(current);
                    current = new MatchupModel();

                    if (numberOfFillInTeams > 0)
                    {
                        numberOfFillInTeams -= 1;
                    }
                }
            }
            return output;
        }

        private static int NumberOfFillInTeams(int rounds, int teamsCount)
        {
            // init variables
            int output = 0;
            int totalTeams = 1;

            // calculate the total number of team needed to perform rounds
            for (int i = 1; i <= rounds; i++)
            {
                totalTeams *= 2;
            }
            output = totalTeams - teamsCount;
            return output;
        }
        
        private static int FindNumberOfRounds(int teamsCount)
        {
            int output = 1;
            int value = 2;
            if (value < teamsCount)
            {
                output += 1;
                value *= 2;
            }
            return output;
        }

        private static List<TeamModel> RandomizeTeamOrder(List<TeamModel> teams)
        {
            // simple random took from StackOverflow
            teams.OrderBy(x => Guid.NewGuid()).ToList();
            return teams;
        }
    }
}
