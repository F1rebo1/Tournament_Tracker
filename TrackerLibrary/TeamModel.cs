using System;

namespace TrackerLibrary{
	public class TeamModel{
        /// <summary>
        /// This records a list of people that are part of the same team
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        /// <summary>
        /// This records the name used to refer to the list of people on the same team
        /// </summary>
        public string TeamName {get; set;}
    }
}
