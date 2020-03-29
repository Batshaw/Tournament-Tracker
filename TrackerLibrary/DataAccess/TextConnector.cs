﻿using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelper;
using System.Linq;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";        // create a private and constant filename for PrizesFile
        private const string PeopleFile = "PeopleModels.csv";       // create a private and constant filename for PeopleFile
        private const string TeamsFile = "TeamsModels.csv";
        private const string TeamMembersFile = "TeamMembers.csv";

        // TODO - Wire up the CreatePrize for text files
        /// <summary>
        /// Saves the Prize to the TextFile
        /// </summary>
        /// <param name="model"></param>
        /// <returns>The prize information, including the uniqe identifier</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // Load file and Convert the text to List<PrizeModel>
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            // Find the maxID
            int currentId = 1;
            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;     // Order by Descending by the Id and take the first Id  // lambda expression
            }
            model.Id = currentId;

            // Add the new record with the new ID = maxID + 1
            prizes.Add(model);

            // Convert the prizes to list<string>
            // Save the list<string> to the textFile
            prizes.SaveToPrizeFile(PrizesFile);

            return model;
        }

        public PersonModel CreatePerson(PersonModel model)
        {
            // Load file and Convert the text to List<PersonModel>
            List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

            // Find the maxID
            int currentId = 1;
            if (people.Count > 0)
            {
                currentId = people.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            // Add the new record with the new ID = maxID + 1
            people.Add(model);

            // Convert the people to list<string>
            // Save the list<string> to the textFile
            people.SaveToPeopleFile(PeopleFile);
            
            return model;
        }

        public List<PersonModel> GetPerson_All()
        {
            return PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            // Load file and convert to List<TeamModel>
            List<TeamModel> teams = TeamsFile.FullFilePath().LoadFile().ConvertToTeamModels();

            int currentTeamId = 1;
            if (teams.Count > 0)
            {
                currentTeamId = teams.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentTeamId;

            teams.Add(model);

            teams.SaveToTeamsAndTeamMembersFile(TeamsFile, TeamMembersFile);


            return model;
        }
    }
}
