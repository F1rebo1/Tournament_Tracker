using System;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// This records the first name of the user
        /// </summary>
        public string FirstName;
        /// <summary>
        /// This records the last name of the user
        /// </summary>
        public string LastName;
        /// <summary>
        /// This records the email address of the user
        /// </summary>
        public string EmailAddress;
        /// <summary>
        /// This records the phone number of the user
        /// </summary>
        public string CellphoneNumber;
        /// <summary>
        /// This records the id of an added person
        /// </summary>
        public int id { get; set; }

        public PersonModel(){}

        public PersonModel(string firstName, string lastName, string emailAddress, string cellphoneNumber){
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EmailAddress = emailAddress;
            this.CellphoneNumber = cellphoneNumber;
        }
    }
}
