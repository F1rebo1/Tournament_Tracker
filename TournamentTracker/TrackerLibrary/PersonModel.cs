using System;

namespace TrackerLibrary{
	public class PersonModel{
		public string FirstName;
		public string LastName;
		public string EmailAddress;
		public string CellphoneNumber;

		public PersonModel(string firstName, string lastName) {
			this.FirstName = firstName;
            this.LastName = lastName;
        }
	}
}
