using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public interface IDataConnection
    {
        /// <summary>
        /// Interface to create/save a PrizeModel
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        PrizeModel CreatePrize(PrizeModel model);
    }
}
