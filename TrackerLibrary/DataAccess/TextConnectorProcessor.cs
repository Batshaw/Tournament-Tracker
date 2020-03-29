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

        public static List<TeamModel> ConvertToTeamModels(this List<string> lines)
        {
            List<TeamModel> output = new List<TeamModel>();

            foreach (var line in lines)
            {
                string[] cols = line.Split(',');

                TeamModel model = new TeamModel();
                model.Id = int.Parse(cols[0]);
                model.TeamName = cols[1];

                output.Add(model);
            }

            return output;
        }
        public static void SaveToTeamsAndTeamMembersFile(this List<TeamModel> teams, string teamsFile, string teamMembersFile)
        {
            List<string> teamLines = new List<string>();
            foreach (var p in teams)
            {
                teamLines.Add($"{ p.Id },{ p.TeamName }");
            }
            File.WriteAllLines(teamsFile.FullFilePath(), teamLines);

            List<string> teamMembersLines = new List<string>();

            List<string> allLines_string = new List<string>();
            // Check if TeamMembersFile exists
            if (File.Exists(teamMembersFile.FullFilePath()))
            {
                // Read all the lines of the teamMembersFile
                string[] allLines = File.ReadAllLines(teamMembersFile.FullFilePath());
                allLines_string = allLines.OfType<string>().ToList(); 
            }

            TeamModel lastAddedTeam = teams.Last();
            int currentId = allLines_string.Count() + 1;
            // Add all members of the last added Team to the lines container
            // because only the last added Team in the list teams has teamMembers, other has only ID and Name
            foreach (var p in lastAddedTeam.TeamMembers)
            {
                allLines_string.Add($"{ currentId },{ lastAddedTeam.Id },{ p.Id }");

                currentId += 1;
            }

            // Overwrite the file with readText and the string of new team
            File.WriteAllLines(teamMembersFile.FullFilePath(), allLines_string);
        }
    }
}
