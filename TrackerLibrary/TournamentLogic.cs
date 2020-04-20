using System;
using System.Collections.Generic;
using System.Configuration;
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

        public static void UpdateTournamentResult(TournamentModel model)
        {
            List<MatchupModel> toScore = new List<MatchupModel>();

            foreach (var round in model.Rounds)
            {
                foreach (var matchup in round)
                {
                    if (matchup.Winner == null && (matchup.Entries.Any(x => x.Score != 0) || matchup.Entries.Count == 1))
                    {
                        toScore.Add(matchup);
                    }
                }
            }
            MarkWinnerMatchups(toScore);
            MoveWinnerToNextRound(toScore, model);
            toScore.ForEach(x => GlobalConfig.Connection.UpdateMatchup(x));
        }
        private static void MoveWinnerToNextRound(List<MatchupModel> toScore, TournamentModel tournament)
        {
            //// move the winner to the next round
            foreach (var matchup in toScore)
            {
                foreach (var round in tournament.Rounds)
                {
                    foreach (var roundmatchup in round)
                    {
                        foreach (var matchupentry in roundmatchup.Entries)
                        {
                            if (matchupentry.ParentMatchup.Id == matchup.Id)
                            {
                                matchupentry.TeamCompeting = matchup.Winner;
                                GlobalConfig.Connection.UpdateMatchup(roundmatchup);
                            }
                        }
                    }
                }
            }
        }
        private static void MarkWinnerMatchups(List<MatchupModel> toScore)
        {
            // greater or lesser
            string greaterWins = ConfigurationManager.AppSettings["greaterWins"];

            foreach (var matchup in toScore)
            {
                if (matchup.Entries.Count == 1)
                {
                    matchup.Winner = matchup.Entries[0].TeamCompeting;
                    continue;
                }
                // 0 means false or low score wins
                if (greaterWins == "0")
                {
                    if (matchup.Entries[0].Score < matchup.Entries[1].Score)
                    {
                        matchup.Winner = matchup.Entries[0].TeamCompeting;
                    }
                    else if (matchup.Entries[1].Score < matchup.Entries[0].Score)
                    {
                        matchup.Winner = matchup.Entries[1].TeamCompeting;
                    }
                    else
                    {
                        throw new Exception("We do not allow ties in this application.");
                    }
                }
                else
                {
                    // 1 means true or high score wins
                    if (matchup.Entries[0].Score > matchup.Entries[1].Score)
                    {
                        matchup.Winner = matchup.Entries[0].TeamCompeting;
                    }
                    else if (matchup.Entries[1].Score > matchup.Entries[0].Score)
                    {
                        matchup.Winner = matchup.Entries[1].TeamCompeting;
                    }
                    else
                    {
                        throw new Exception("We do not allow ties in this application.");
                    }
                } 
            }
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
            while (value < teamsCount)
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
