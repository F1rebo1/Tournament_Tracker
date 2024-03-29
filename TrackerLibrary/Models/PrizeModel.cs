using System;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// Represents a unique identifier for the prize
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// This records the place that this prize is for
        /// </summary>
        public int PlaceNumber;
        /// <summary>
        /// This records what the place is referred to, i.e.
        /// first place: "Champion", or second place: "First runner up"
        /// </summary>
        public string PlaceName;
        /// <summary>
        /// If specified, this records the prize amount as a decimal value
        /// </summary>
        public decimal PrizeAmount;
        /// <summary>
        /// If specified, this records the prize amount as a percentage value
        /// </summary>
        public double PrizePercentage;

        public PrizeModel() { }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            PlaceNumber = 0;
            PrizeAmount = 0m;
            PrizePercentage = 0;

            bool checkPlaceNumber = int.TryParse(placeNumber, out PlaceNumber);
            bool checkPrizeAmount = decimal.TryParse(prizeAmount, out PrizeAmount);
            bool checkPrizePercentage = double.TryParse(prizePercentage, out PrizePercentage);
        }
    }
}