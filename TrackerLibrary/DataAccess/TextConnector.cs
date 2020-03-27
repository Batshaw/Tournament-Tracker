using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelper;
using System.Linq;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";        // create a private and constant filename for PrizesFile

        // TODO - Wire up the CreatePrize for text files
        /// <summary>
        /// Saves the Prize to the TextFile
        /// </summary>
        /// <param name="model"></param>
        /// <returns>The prize information, including the uniqe identifier</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // Load file and Convert the text to List<PrizeModel>
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            // Find the maxID
            int currentId = 1;
            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;     // Order by Descending by the Id and take the first Id  // lambda expression
            }
            model.Id = currentId;

            // Add the new record with the new ID = maxID + 1
            prizes.Add(model);

            // Convert the prizes to list<string>
            // Save the list<string> to the textFile
            prizes.SaveToPrizeFile(PrizesFile);

            return model;
        }
    }
}
