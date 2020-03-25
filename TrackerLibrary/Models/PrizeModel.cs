using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        public PrizeModel()
        {

        }
        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            this.PlaceName = placeName;

            int.TryParse(placeNumber, out int placeNumberValue);
            this.PlaceNumber = placeNumberValue;

            decimal.TryParse(prizeAmount, out decimal prizeAmountValue);
            this.PrizeAmount = prizeAmountValue;

            double.TryParse(prizePercentage, out double prizePercentageValue);
            this.PrizePercentage = prizePercentageValue;
        }

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
