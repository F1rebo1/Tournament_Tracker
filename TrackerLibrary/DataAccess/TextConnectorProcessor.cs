using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace TrackerLibrary.DataAccess{
    public static class TextConnectorProcessor{
        public static string FullFilePath(this string fileName){
            return $"{GlobalConfig.CnnString("textFilePath")}\\{fileName}";
        }

        public static List<string> LoadFile(this string file){
            if(!File.Exists(file)) return new List<string>();
            return File.ReadAllLines(file).ToList();
        }
    }
}
