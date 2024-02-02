using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig{
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        public static void InitializeConections(bool database, bool textFiles){
            if(database){
                // TODO: Set up the SQL Connector properly
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }

            if(textFiles){
                // TODO: Create a Textfile Connection
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }
    }
}
