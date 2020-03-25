using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();       // Only method inside the GlobalConfig can set the Connections,
                                                                                                                   // but anyone can access to this.
        /// <summary>
        /// Initialize which Connection to use
        /// </summary>
        /// <param name="database"></param>
        /// <param name="textFiles"></param>
        public static void InitializeConnections(bool database, bool textFiles)
        {
            if (database)
            {
                // TODO - Set up the SQL Connector properly
                // create the SQL Connection and add it to the Connections list
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }

            if (textFiles)
            {
                // TODO - Set up the Text Connector properly
                // create the TextFile Connection and add it to the Connections list
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }

        public static string ConnString(string name)
        {
            return ConfiguationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
