using Dapper;
using InterestModuleDataControl.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestModuleDataControl
{
    internal class DataAccess
    {
        //TODO: use generic
        internal List<T> LoadData<T, P>(string sqlStatement, P parameters, string connectionString) {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<T> rows = connection.Query<T>(sqlStatement, parameters, commandType: CommandType.StoredProcedure).ToList();
                return rows;
            }
        }

        internal void SaveData<T>(string sqlStatement, T parameters, string connectionString)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Execute(sqlStatement, parameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
