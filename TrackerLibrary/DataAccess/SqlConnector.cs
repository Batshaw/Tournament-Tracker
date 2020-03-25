using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using TrackerLibrary.Models;
using Dapper;

namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        // TODO - Make the CreatePrize method actually save to the database
        /// <summary>
        /// Saves a new prize to the database
        /// </summary>
        /// <param name="model"></param>
        /// <returns>The prize information, including the unique identifier.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString("Tournaments")))
            {
                // TODO - Continue here!!!
                var p = new DynamicParameters();

                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                p.Add("@id", 0, DbType.Int32, direction: ParameterDirection.Output);

                // execute the connection for the stored procedure namely dbo.spPrizes_Insert with the parameters stored in p
                connection.Execute("dbo.spPrizes_Insert", p, commandType:CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");
                return model;
            }
        }
    }
}
