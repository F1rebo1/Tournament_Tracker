using System;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents one competing team within the matchup
        /// </summary>
        public TeamModel TeamCompeting;
        /// <summary>
        /// Represents the score for this specific team
        /// </summary>
        public double Score;
        /// <summary>
        /// Represents the matchup that this team came
        /// from as the winner
        /// </summary>
        public MatchupModel ParentMatchup;
    }
}