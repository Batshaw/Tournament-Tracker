using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Id of the Prize in SQL
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents the place number of the prize.
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Represents the name of the prize. (Firstplace...)
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Amount of the prize in decimal.
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Percentage of the Prizes.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
