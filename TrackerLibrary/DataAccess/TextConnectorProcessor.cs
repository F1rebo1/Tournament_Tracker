using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess.TextHelpers{
    public static class TextConnectorProcessor{
        /// <summary>
        /// This appends the full file path before the file read/save location provided in fileName
        /// </summary>
        /// <param name="fileName">This is the name/location that the file is to be saved at/read from</param>
        /// <returns>The full file path of the save/read location</returns>
        public static string FullFilePath(this string fileName){
            return $"{GlobalConfig.CnnString("textFilePath")}\\{fileName}";
        }
        /// <summary>
        /// This loads an existing file into an enumerable list of type string
        /// </summary>
        /// <param name="file">This is the name of the file</param>
        /// <returns>The list of strings containing the contents of the input file</returns>
        public static List<string> LoadFile(this string file){
            if(!File.Exists(file)) return new List<string>();
            return File.ReadAllLines(file).ToList();
        }

        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines){
            List<PrizeModel> output = new List<PrizeModel>();

            foreach(string line in lines){
                string[] cols = line.Split(',');

                PrizeModel p = new PrizeModel();
                p.id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = double.Parse(cols[4]);
                output.Add(p);
            }
            return output;
        }

        public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName){

            List<string> lines = new List<string>();

            foreach(PrizeModel p in models){
                lines.Add($"{ p.id },{ p.PlaceNumber },{ p.PlaceName},{ p.PrizeAmount },{ p.PrizePercentage }");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static List<PersonModel> ConvertToPersonModels(this List<string> lines){
            List<PersonModel> output = new List<PersonModel>();

            foreach(string line in lines){
                string[] cols = line.Split(",");

                PersonModel p = new PersonModel();
                p.id = int.Parse((string)cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.EmailAddress = cols[3];
                p.CellphoneNumber = cols[4];
                output.Add(p);
            }
            return output;
        }

        public static void SaveToPeopleFile(this List<PersonModel> people, string fileName){
            List<string> lines = new List<string>();

            foreach(PersonModel p in people){
                lines.Add($"{ p.id },{ p.FirstName },{ p.FirstName },{ p.EmailAddress },{ p.CellphoneNumber }");
            }

            File.WriteAllLines(fileName.FullFilePath(),lines);
        }
    }
}
