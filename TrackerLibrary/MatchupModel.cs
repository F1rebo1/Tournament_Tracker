using System;

namespace TrackerLibrary{
    public class MatchupModel{
        /// <summary>
        /// This records the List of matchup entries. Each index of this
        /// list represents all matches for that round of the tournament
        /// </summary>
        public List<MatchupEntryModel> Entries = new List<MatchupEntryModel>();
        /// <summary>
        /// This records the winning team's information
        /// </summary>
        public TeamModel Winner;
        /// <summary>
        /// This records the current round of the tournament
        /// </summary>
        public int MatchupRound;
    }
}