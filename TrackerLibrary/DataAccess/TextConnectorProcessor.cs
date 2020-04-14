using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

// Load TextFile


// Convert the text to List<PrizeModel>
// Find the maxID
// Add the new record with the new ID = maxID + 1
// Convert the prizes to list<string>
// Save the list<string> to the textFile


namespace TrackerLibrary.DataAccess.TextHelper
{ 
    public static class TextConnectorProcessor
    {
        /// <summary>
        /// Extension method for string to change the string to the full filePath
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static string FullFilePath(this string fileName)                         // this: to make this method becomes an extension method
        {
            // return D:\BatshawProjekt\Tournament-Tracker\TextFileData + \fileName
            return $"{ ConfigurationManager.AppSettings["filePath"] }\\{ fileName }";   // AppSettings[key] in appSettings in App.config
        }

        public static List<string> LoadFile(this string file)       // each line in the TextFile is a value in this string
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();

            foreach (var line in lines)
            {
                string[] cols = line.Split(',');            // each line is splitted with ,

                PrizeModel p = new PrizeModel();
                // Read the value from the line into the variables of the new model
                p.Id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = double.Parse(cols[4]);

                output.Add(p);
            }
            
            return output;      // return the model with variables or an empty model if there are no file or no line
        }
        public static void SaveToPrizeFile(this List<PrizeModel> models)
        {
            List<string> lines = new List<string>();

            foreach (var p in models)
            {
                lines.Add($"{ p.Id },{ p.PlaceNumber },{ p.PlaceName },{ p.PrizeAmount },{ p.PrizePercentage }");
            }

            File.WriteAllLines(GlobalConfig.PrizesFile.FullFilePath(), lines);     // Overwrite the file with new content which is the whole list of models
        }

        public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
        {
            List<PersonModel> output = new List<PersonModel>();

            foreach (var line in lines)
            {
                string[] cols = line.Split(',');

                PersonModel p = new PersonModel();
                // Read the value from the line into the variables of the new model
                p.Id = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.EmailAdress = cols[3];
                p.PhoneNumber = cols[4];

                output.Add(p);
            }

            return output;
        }
        public static void SaveToPeopleFile(this List<PersonModel> models)
        {
            List<string> lines = new List<string>();

            foreach (var p in models)
            {
                lines.Add($"{ p.Id },{ p.FirstName },{ p.LastName },{ p.EmailAdress },{ p.PhoneNumber }");
            }

            File.WriteAllLines(GlobalConfig.PeopleFile.FullFilePath(), lines);
        }

        public static List<TeamModel> ConvertToTeamModels(this List<string> lines)
        {
            // Load file and convert to List<PersonModel>
            List<PersonModel> people = GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

            List<TeamModel> output = new List<TeamModel>();

            foreach (var line in lines)
            {
                string[] cols = line.Split(',');

                TeamModel model = new TeamModel();
                model.Id = int.Parse(cols[0]);
                model.TeamName = cols[1];

                int idOfMember;
                foreach (var c in cols[2])
                {
                    bool cIsInt = int.TryParse(c.ToString(), out idOfMember);
                    if (cIsInt)
                    {
                        foreach (var person in people)
                        {
                            if (idOfMember == person.Id)
                            {
                                model.TeamMembers.Add(person);
                            }
                        }
                    }
                }

                output.Add(model);
            }

            return output;
        }
        public static void SaveToTeamsFile(this List<TeamModel> teams)
        {
            List<string> teamLines = new List<string>();
            foreach (var team in teams)
            {
                string stringToAdd = $"{ team.Id },{ team.TeamName },";
                foreach (var member in team.TeamMembers)
                {
                    stringToAdd = stringToAdd + $"{ member.Id }|";
                }
                teamLines.Add(stringToAdd);
            }
            File.WriteAllLines(GlobalConfig.TeamsFile.FullFilePath(), teamLines);
        }

        public static List<TournamentModel> ConvertToTournamentModels(this List<string> lines)
        {
            // id,TournamentName,EntryFee,(id|id|id - EnteredTeam),(id|id|id - Prizes), (Rounds - id^id^id|id^id^id|id^id^id)
            List<TournamentModel> output = new List<TournamentModel>();
            List<TeamModel> teams = GlobalConfig.TeamsFile.FullFilePath().LoadFile().ConvertToTeamModels();
            List<PrizeModel> prizes = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();
            List<MatchupModel> matchups = GlobalConfig.MatchupsFile.FullFilePath().LoadFile().ConvertToMatchupModels();

            foreach (var line in lines)
            {
                string[] cols = line.Split(',');

                TournamentModel p = new TournamentModel();
                p.Id = int.Parse(cols[0]);
                p.TournamentName = cols[1];
                p.EntryFee = decimal.Parse(cols[2]);

                int idOfEnteredTeam;
                foreach (var c in cols[3])
                {
                    bool cIsInt = int.TryParse(c.ToString(), out idOfEnteredTeam);
                    if (cIsInt)
                    {
                        foreach (var team in teams)
                        {
                            if (idOfEnteredTeam == team.Id)
                            {
                                p.EnteredTeam.Add(team);
                            }
                        }
                    }
                }

                int idOfPrize;
                foreach (var c in cols[4])
                {
                    bool cIsInt = int.TryParse(c.ToString(), out idOfPrize);
                    if (cIsInt)
                    {
                        foreach (var prize in prizes)
                        {
                            if (idOfPrize == prize.Id)
                            {
                                p.Prizes.Add(prize);
                            }
                        }
                    }
                }

                // Capture Rounds information
                string[] rounds = cols[5].Split('|');
                foreach (var round in rounds)
                {
                    string[] msId = round.Split('^');
                    List<MatchupModel> ms = new List<MatchupModel>();
                    foreach (var id in msId)
                    {
                        ms.Add(matchups.Where(x => x.Id == int.Parse(id)).First());
                    }

                    p.Rounds.Add(ms);
                }
                output.Add(p);
            }
            return output;
        }
        public static void SaveToTournamentsFile(this List<TournamentModel> tournaments)
        {
            // id,TournamentName,EntryFee,(id|id|id - EnteredTeam),(id|id|id - Prizes), (Rounds - id^id^id|id^id^id|id^id^id)
            List<string> lines = new List<string>();
            foreach (var tournament in tournaments)
            {
                // Write Id, TournamentName, EntryFee
                string stringToAdd = $"{ tournament.Id },{ tournament.TournamentName },{ tournament.EntryFee },";
                // Write EnteredTeam
                foreach (var team in tournament.EnteredTeam)
                {
                    stringToAdd = stringToAdd + $"{ team.Id }|";
                }
                stringToAdd = stringToAdd + ",";
                // Write Prize
                foreach (var prize in tournament.Prizes)
                {
                    stringToAdd = stringToAdd + $"{ prize.Id }|";
                }
                stringToAdd = stringToAdd + ",";
                // Write Rounds
                foreach (var round in tournament.Rounds)
                {
                    foreach (var matchup in round)
                    {
                        stringToAdd = stringToAdd + $"{ matchup.Id}^";
                    }
                    stringToAdd = stringToAdd + "|";
                }
                lines.Add(stringToAdd);
            }
            File.WriteAllLines(GlobalConfig.TournamentsFile.FullFilePath(), lines);
            
        }

        public static void SaveRoundsToFile(this TournamentModel model)
        {
            // Loop through each round
            // Loop through each matchup
            // Get the id for the new matchup and save the record
            // Loop through each entry, get the id and save it

            foreach (var round in model.Rounds)
            {
                foreach (var matchup in round)
                {
                    // Load all of the matchups from file
                    // get the top id and add one
                    // Store the id
                    // save the matchup record
                    matchup.SaveMatchupsToFile();
                }
            }
        }
        public static void SaveMatchupsToFile(this MatchupModel model)
        {
            List<MatchupModel> matchups = GlobalConfig.MatchupsFile.FullFilePath().LoadFile().ConvertToMatchupModels();

            int currentId = 1;
            if (matchups.Count() > 0)
            {
                currentId = matchups.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            foreach (var entry in model.Entries)
            {
                entry.SaveMatchupEntriesToFile();
            }

            matchups.Add(model);

            List<string> lines = new List<string>();
            foreach (var matchup in matchups)
            {
                string lineToAdd = $"{ matchup.Id },";
                foreach (var entry in matchup.Entries)
                {
                    lineToAdd = lineToAdd + $"{ entry.Id}|";
                }
                string winner = "";
                if (matchup.Winner != null)
                {
                    winner = matchup.Winner.Id.ToString();
                }
                lineToAdd = lineToAdd + $",{ winner },{ matchup.MatchupRound }";
                lines.Add(lineToAdd);
            }
            File.WriteAllLines(GlobalConfig.MatchupsFile.FullFilePath(), lines);

        }
        public static void SaveMatchupEntriesToFile(this MatchupEntryModel model)
        {
            List<MatchupEntryModel> entries = GlobalConfig.MatchupEntriesFile.FullFilePath().LoadFile().ConverToMatchupEntryModels();
            List<string> lines = new List<string>();

            int currentId = 1;
            if (entries.Count() > 0)
            {
                currentId = entries.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;
            entries.Add(model);

            foreach (var entry in entries)
            {
                string parent = "";
                if (entry.ParentMatchup != null)
                {
                    parent = entry.ParentMatchup.Id.ToString();
                }
                lines.Add($"{ entry.Id },{ entry.TeamCompeting.Id },{ entry.Score },{ parent}");
            }
            File.WriteAllLines(GlobalConfig.MatchupEntriesFile.FullFilePath(), lines);
        }
        public static List<MatchupModel> ConvertToMatchupModels(this List<string> lines)
        {
            // id, entries, winner, matchupRound
            List<MatchupModel> output = new List<MatchupModel>();

            foreach (var line in lines)
            {
                string[] cols = line.Split(',');

                MatchupModel p = new MatchupModel();
                p.Id = int.Parse(cols[0]);
                p.Entries = ConvertStringToMatchupEntryModels(cols[1]);
                p.Winner = LookUpTeamById(int.Parse(cols[2]));
                p.MatchupRound = int.Parse(cols[3]);
                output.Add(p);
            }
            return output;
        }
        private static List<MatchupEntryModel> ConvertStringToMatchupEntryModels(string input)
        {
            string[] ids = input.Split('|');
            List<MatchupEntryModel> output = new List<MatchupEntryModel>();
            List<MatchupEntryModel> entries = GlobalConfig.MatchupEntriesFile.FullFilePath().LoadFile().ConverToMatchupEntryModels();

            foreach (var id in ids)
            {
                output.Add(entries.Where(x => x.Id == int.Parse(id)).First());
            }

            return output;
        }
        private static List<MatchupEntryModel> ConverToMatchupEntryModels(this List<string> lines)
        {
            // id, TeamCompeting, Score, ParentMatchup
            List<MatchupEntryModel> output = new List<MatchupEntryModel>();

            foreach (var line in lines)
            {
                string[] cols = line.Split(',');
                MatchupEntryModel me = new MatchupEntryModel();
                me.Id = int.Parse(cols[0]);
                me.TeamCompeting = LookUpTeamById(int.Parse(cols[1]));
                me.Score = double.Parse(cols[2]);
                int parentId = 0;
                if (int.TryParse(cols[3], out parentId))
                {
                    me.ParentMatchup = LookUpMatchupById(int.Parse(cols[3]));
                }
                else
                {
                    me.ParentMatchup = null;
                }
                output.Add(me);
            }
            return output;
        }

        private static TeamModel LookUpTeamById(int id)
        {
            List<TeamModel> teams = GlobalConfig.TeamsFile.FullFilePath().LoadFile().ConvertToTeamModels();
            return teams.Where(x => x.Id == id).First();
        }
        private static MatchupModel LookUpMatchupById(int id)
        {
            List<MatchupModel> matchups = GlobalConfig.MatchupsFile.FullFilePath().LoadFile().ConvertToMatchupModels();
            if (matchups.Count == 0)
            {
                return null;
            }
            return matchups.Where(x => x.Id == id).First();
        }
    }
}
