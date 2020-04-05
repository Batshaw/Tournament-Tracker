using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }      // Only method inside the GlobalConfig can set the Connections,
                                                                            // but anyone can access to this.

        public const string PrizesFile = "PrizeModels.csv";        // create a private and constant filename for PrizesFile
        public const string PeopleFile = "PeopleModels.csv";       // create a private and constant filename for PeopleFile
        public const string TeamsFile = "TeamsModels.csv";
        public const string TournamentsFile = "TournamentModels.csv";
        public const string MatchupsFile = "MatchupModels.csv";
        public const string MatchupEntriesFile = "MatchupEntryModels.csv";

        /// <summary>
        /// Initialize which Connection to use
        /// </summary>
        /// <param name="database"></param>
        /// <param name="textFiles"></param>
        public static void InitializeConnections(DatabaseType database)
        {
            if (database == DatabaseType.Sql)
            {
                // TODO - Set up the SQL Connector properly
                // create the SQL Connection and add it to the Connections list
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }
            else if (database == DatabaseType.TextFile)
            {
                // TODO - Set up the Text Connector properly
                // create the TextFile Connection and add it to the Connections list
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }

        /// <summary>
        /// Call the ConnectionString in App.config
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string ConnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
