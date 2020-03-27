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
    }
}
