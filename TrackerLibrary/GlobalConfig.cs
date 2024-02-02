using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;
using Microsoft.Extensions.Configuration;
using System.Runtime.InteropServices;

namespace TrackerLibrary
{
    public static class GlobalConfig{
        public static IDataConnection Connection { get; private set; }
        public static void InitializeConections(DatabaseType db){
            if(db == DatabaseType.Sql){
                // TODO: Set up the SQL Connector properly
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }else if(db == DatabaseType.TextFile){
                // TODO: Create a Textfile Connection
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }

        public static string CnnString(string name){
            IConfigurationBuilder configBuilder =
                new ConfigurationBuilder().AddJsonFile("appsettings.json");

            IConfigurationRoot configuration = configBuilder.Build();
            string connectionString = configuration.GetConnectionString(name);
            return connectionString;
        }
    }
}
