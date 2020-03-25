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
            model.Id = 1;

            return model;
        }
    }
}
