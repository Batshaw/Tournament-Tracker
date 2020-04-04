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
        public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (var p in models)
            {
                lines.Add($"{ p.Id },{ p.PlaceNumber },{ p.PlaceName },{ p.PrizeAmount },{ p.PrizePercentage }");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);     // Overwrite the file with new content which is the whole list of models
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
        public static void SaveToPeopleFile(this List<PersonModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (var p in models)
            {
                lines.Add($"{ p.Id },{ p.FirstName },{ p.LastName },{ p.EmailAdress },{ p.PhoneNumber }");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static List<TeamModel> ConvertToTeamModels(this List<string> lines, string peopleFile)
        {
            // Load file and convert to List<PersonModel>
            List<PersonModel> people = peopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

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
        public static void SaveToTeamsFile(this List<TeamModel> teams, string teamsFile)
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
            File.WriteAllLines(teamsFile.FullFilePath(), teamLines);
        }

        public static List<TournamentModel> ConvertToTournamentModels(this List<string> lines, string teamsFile, string prizesFile, string peopleFile)
        {
            // id,TournamentName,EntryFee,(id|id|id - EnteredTeam),(id|id|id - Prizes), (Rounds - id^id^id|id^id^id|id^id^id)
            List<TournamentModel> output = new List<TournamentModel>();
            List<TeamModel> teams = teamsFile.FullFilePath().LoadFile().ConvertToTeamModels(peopleFile);
            List<PrizeModel> prizes = prizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

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

                // TODO - Capture Rounds information
                output.Add(p);
            }
            return output;
        }
        public static void SaveToTournamentsFile(this List<TournamentModel> tournaments, string fileName)
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
            }
        }
    }
}
