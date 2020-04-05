using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using TrackerLibrary.Models;
using Dapper;
using System.Linq;

namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        private const string database = "Tournaments";

        /// <summary>
        /// Saves a new prize to the database
        /// </summary>
        /// <param name="model"></param>
        /// <returns>The prize information, including the unique identifier.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString(database)))
            {
                var p = new DynamicParameters();

                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                // execute the connection for the stored procedure namely dbo.spPrizes_Insert with the parameters stored in p
                connection.Execute("dbo.spPrizes_Insert", p, commandType:CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");
            }
            return model;
        }

        public PersonModel CreatePerson(PersonModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString(database)))
            {
                var p = new DynamicParameters();

                p.Add("@FirstName", model.FirstName);
                p.Add("@Lastname", model.LastName);
                p.Add("@EmailAddress", model.EmailAdress);
                p.Add("@CellphoneNumber", model.PhoneNumber);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPeople_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");
            }
            return model;
        }

        public List<PersonModel> GetPerson_All()
        {
            List<PersonModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString(database)))
            {
                output = connection.Query<PersonModel>("dbo.spPerson_GetAll", commandType: CommandType.StoredProcedure).ToList();
            }
            return output;
        }

        public TeamModel CreateTeam(TeamModel teamModel)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString(database)))
            {
                // Add new Team to the Teams table in the database
                var param_of_Teams = new DynamicParameters();

                param_of_Teams.Add("@TeamName", teamModel.TeamName);
                param_of_Teams.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTeams_Insert", param_of_Teams, commandType: CommandType.StoredProcedure);

                teamModel.Id = param_of_Teams.Get<int>("@id");

                // Add team member to the TeamMembers table in the database
                var param_of_TeamMembers = new DynamicParameters();

                
                foreach (var member in teamModel.TeamMembers)
                {
                    param_of_TeamMembers.Add("@TeamId", teamModel.Id);
                    param_of_TeamMembers.Add("@PersonId", member.Id);

                    connection.Execute("dbo.spTeamMembers_Insert", param_of_TeamMembers, commandType: CommandType.StoredProcedure);
                }
                
            }
            return teamModel;
        }

        public List<TeamModel> GetTeam_All()
        {
            List<TeamModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString(database)))
            {
                output = connection.Query<TeamModel>("dbo.spTeams_GetAll", commandType: CommandType.StoredProcedure).ToList();

                foreach (var team in output)
                {
                    var p = new DynamicParameters();
                    p.Add("@TeamId", team.Id);
                    team.TeamMembers = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam", p, commandType: CommandType.StoredProcedure).ToList();
                }
            }

            return output;
        }

        public List<PrizeModel> GetPrizes_All()
        {
            List<PrizeModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString(database)))
            {
                output = connection.Query<PrizeModel>("dbo.spPrizes_GetAll", commandType: CommandType.StoredProcedure).ToList();
            }

            return output;
        }

        public TournamentModel CreateTournament(TournamentModel model)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString(database)))
            {
                SaveTournament(connection, model);

                SaveTournamentPrizes(connection, model);

                SaveTournamentEntries(connection, model);
                SaveTournamentRounds(connection, model);
            }
            return model;
        }
        private void SaveTournament(IDbConnection connection, TournamentModel model)
        {
            var p = new DynamicParameters();
            p.Add("@TournamentName", model.TournamentName);
            p.Add("@EntryFee", model.EntryFee);
            p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("dbo.spTournaments_Insert", p, commandType: CommandType.StoredProcedure);

            model.Id = p.Get<int>("@id");
        }
        private void SaveTournamentPrizes(IDbConnection connection, TournamentModel model)
        {
            foreach (var prize in model.Prizes)
            {
                var p = new DynamicParameters();

                p.Add("@TournamentId", model.Id);
                p.Add("@PrizeId", prize.Id);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                // execute the connection for the stored procedure namely dbo.spPrizes_Insert with the parameters stored in p
                connection.Execute("dbo.spTournamentPrizes_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }
        private void SaveTournamentEntries(IDbConnection connection, TournamentModel model)
        {
            foreach (var team in model.EnteredTeam)
            {
                var p = new DynamicParameters();

                p.Add("@TournamentId", model.Id);
                p.Add("@TeamId", team.Id);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTournamentEntries_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }
        private void SaveTournamentRounds(IDbConnection connection, TournamentModel model)
        {
            // List<List<MatchupModel> Rounds
            // List<MatchupEntryModel> Entries

            // loop through the rounds
            // loop through the matchups in round
            // save the matchup
            // loop through the entries and save them
            foreach (var round in model.Rounds)
            {
                foreach (var matchup in round)
                {
                    var p = new DynamicParameters();

                    p.Add("@TournamentId", model.Id);
                    p.Add("@MatchupRound", matchup.MatchupRound);
                    p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                    connection.Execute("dbo.spMatchups_Insert", p, commandType: CommandType.StoredProcedure);

                    matchup.Id = p.Get<int>("@id");

                    foreach (var entry in matchup.Entries)
                    {
                        p = new DynamicParameters();
                        p.Add("@MatchupId", matchup.Id);
                        p.Add("@ParentMatchupId", entry.ParentMatchup.Id);
                        p.Add("@TeamCompetingId", entry.TeamCompeting.Id);

                        connection.Execute("dbo.spMatchupEntries_Insert", p, commandType: CommandType.StoredProcedure);
                    }
                }
            }

        }
    }
}
