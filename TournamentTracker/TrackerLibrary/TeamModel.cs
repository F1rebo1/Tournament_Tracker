using System;

namespace TrackerLibrary{
	public class TeamModel{
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        public string TeamName { get; set; };

        public TeamModel() {
            TeamMembers = new List<PersonModel>();
        }
    }
}
