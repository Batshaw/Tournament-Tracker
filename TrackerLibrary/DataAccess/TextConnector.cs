using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        // TODO - Wire up the CreatePrize for text files
        /// <summary>
        /// Saves the Prize to the TextFile
        /// </summary>
        /// <param name="model"></param>
        /// <returns>The prize information, including the uniqe identifier</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // Load TextFile


            // Convert the text to List<PrizeModel>
            // Find the maxID
            // Add the new record with the new ID = maxID + 1
            // Convert the prizes to list<string>
            // Save the list<string> to the textFile

            return model;
        }
    }
}
