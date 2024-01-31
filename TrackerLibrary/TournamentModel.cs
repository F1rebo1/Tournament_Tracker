using System;

namespace TrackerLibrary {
	public class TournamentModel{
		public string TournamentName;
		public decimal EntryFee;
		public List<TeamModel> EnteredTeams = new List<TeamModel>();
		public List<PrizeModel> Prizes = new List<PrizeModel>();
        public List<List<MatchupModel>> Rounds = new List<MatchupModel>();
    }
}