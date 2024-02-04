using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace TrackerLibrary.DataAccess{
    public static class TextConnectorProcessor{
        public static string FullFilePath(string fileName){

            return $"{GlobalConfig.CnnString("textFilePath")}\\{fileName}";

            IConfigurationBuilder configBuilder =
                new ConfigurationBuilder().AddJsonFile("appsettings.json");

            IConfigurationRoot configurationRoot = configBuilder.Build();

            string path = configurationRoot.GetSection("AppSettings")["value"] + @"\";

            string fullPath = path + fileName;

            return fullPath;
        }
    }
}
