using System;

namespace TrackerLibrary{
    public class PrizeModel{
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
    }
}