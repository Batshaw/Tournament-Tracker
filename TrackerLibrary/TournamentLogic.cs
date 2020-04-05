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
        public static void CreateRounds(TournamentModel tournament)
        {
            // Oder our list randomly of teams
            List<TeamModel> randomizedTeams = RandomizeTeamOrder(tournament.EnteredTeam);
            // Check if its big enough, if not, add in a fill-in
            int rounds = FindNumberOfRounds(randomizedTeams.Count());
            int numberOfFillInTeams = NumberOfFillInTeams(rounds, randomizedTeams.Count());
            // Create first round of matchups
            tournament.Rounds.Add(CreateFirstRound(numberOfFillInTeams, randomizedTeams));
            // Create every round after that
            CreateOtherRounds(tournament, rounds);
        }

        private static void CreateOtherRounds(TournamentModel tournament, int rounds)
        {
            // Start with round number 2
            int round = 2;
            // init variable
            List<MatchupModel> prevRound = tournament.Rounds[0];
            List<MatchupModel> curRound = new List<MatchupModel>();
            MatchupModel curMatchup = new MatchupModel();

            while (round <= rounds)
            {
                foreach (var matchup in prevRound)
                {
                    // add the matchup to the matchupEntry of the current matchup
                    curMatchup.Entries.Add(new MatchupEntryModel { ParentMatchup = matchup });
                    // stop adding matchup, because now curMatchup has 2 etries, add it to the curRound
                    if (curMatchup.Entries.Count > 1)
                    {
                        curMatchup.MatchupRound = round;
                        curRound.Add(curMatchup);
                        // reset the curMatchup for the next loop
                        curMatchup = new MatchupModel();
                    }
                }
                // when round is fully filled, add it to the tournament entries list
                tournament.Rounds.Add(curRound);
                // set up for the next loop
                prevRound = curRound;
                curRound = new List<MatchupModel>();
                round += 1;
            }
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
