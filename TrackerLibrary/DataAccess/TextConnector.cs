using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;
using System.Data;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {

        private const string PrizesFile = "PrizeModels.csv";

        public PrizeModel CreatePrize(PrizeModel model)
        {
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            int currentId = 1;
            if(prizes.Count > 0) currentId = prizes.OrderByDescending(x => x.id).First().id + 1;

            model.id = currentId;

            prizes.Add(model);

            prizes.SaveToPrizeFile(PrizesFile);

            return model;
        }

        private const string PeopleFile = "PersonModels.csv";
        public PersonModel CreatePerson(PersonModel person)
        {
            List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

            int currentPerson = 1;
            if (people.Count > 0) currentPerson = people.OrderByDescending(x => x.id).First().id + 1;

            person.id = currentPerson;

            people.Add(person);

            people.SaveToPeopleFile(PeopleFile);

            return person;
        }

        public List<PersonModel> GetPerson_All()
        {
            List<PersonModel> output = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
            return output;
        }
    }
}
