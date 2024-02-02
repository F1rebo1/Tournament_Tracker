using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary{
    public static class GlobalConfig{
        public static List<IDataConnection> Connections { get; private set; }
        public static void InitializeConections(bool database, bool textFiles){
            if(database){
                // TODO: Create a SQL Connection
            }

            if(textFiles){
                // TODO: Create a Textfile Connection
            }
        }
    }
}
