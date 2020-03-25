using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Load TextFile


// Convert the text to List<PrizeModel>
// Find the maxID
// Add the new record with the new ID = maxID + 1
// Convert the prizes to list<string>
// Save the list<string> to the textFile


namespace TrackerLibrary.DataAccess.TextConnection
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
            return $"{ ConfigurationManager.AppSettings["filePath"] }\\{ fileName }";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }
    }
}
