using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelper;
using System.Linq;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        // TODO - Wire up the CreatePrize for text files
        /// <summary>
        /// Saves the Prize to the TextFile
        /// </summary>
        /// <param name="model"></param>
        /// <returns>The prize information, including the uniqe identifier</returns>
        public void CreatePrize(PrizeModel model)
        {
            // Load file and Convert the text to List<PrizeModel>
            List<PrizeModel> prizes = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

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
            prizes.SaveToPrizeFile();
        }

        public void CreatePerson(PersonModel model)
        {
            // Load file and Convert the text to List<PersonModel>
            List<PersonModel> people = GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

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
            people.SaveToPeopleFile();
        }

        public List<PersonModel> GetPerson_All()
        {
            return GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
        }

        public void CreateTeam(TeamModel model)
        {
            // Load file and convert to List<TeamModel>
            List<TeamModel> teams = GlobalConfig.TeamsFile.FullFilePath().LoadFile().ConvertToTeamModels();

            int currentTeamId = 1;
            if (teams.Count > 0)
            {
                currentTeamId = teams.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentTeamId;

            teams.Add(model);

            teams.SaveToTeamsFile();
        }

        public List<TeamModel> GetTeam_All()
        {
            return GlobalConfig.TeamsFile.FullFilePath().LoadFile().ConvertToTeamModels();
        }

        public List<PrizeModel> GetPrizes_All()
        {
            return GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();
        }

        public void CreateTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = GlobalConfig.TournamentsFile
                                                .FullFilePath()
                                                .LoadFile()
                                                .ConvertToTournamentModels();

            // TODO - Finish CreateTournament method
            int currentId = 1;
            if (tournaments.Count() > 0)
            {
                currentId = tournaments.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            model.SaveRoundsToFile();

            tournaments.Add(model);
            tournaments.SaveToTournamentsFile();
        }

        public List<TournamentModel> GetTournament_All()
        {
            return GlobalConfig.TournamentsFile.FullFilePath().LoadFile().ConvertToTournamentModels();
        }

        public void UpdateMatchup(MatchupModel model)
        {
            throw new NotImplementedException();
        }
    }
}
