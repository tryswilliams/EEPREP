using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEPrep
{
    /**
     * Executes queries on the database
     */
    class MySqlDataProvider : IDbDataProvider
    {
        private MySqlDatabaseConnection databaseConnection;

        public MySqlDataProvider(MySqlDatabaseConnection databaseConnection)
        {
            this.databaseConnection = databaseConnection;
        }

        /**
         * 
         */
        public IDataReader ExecuteReader(string sqlQuery)
        {
            if (databaseConnection.State != ConnectionState.Open)
            {
                databaseConnection.OpenConnection();
            }
            IDataReader result;
            MySqlCommand sqlCommand = CreateSqlTextCommand(sqlQuery);
            result = sqlCommand.ExecuteReader();
            return result;
        }

        public object ExecuteScalar(string sqlQuery)
        {
            object result;
            MySqlCommand sqlCommand = CreateSqlTextCommand(sqlQuery);
            result = sqlCommand.ExecuteScalar();
            return result;
        }

        private MySqlCommand CreateSqlTextCommand(string sqlQuery)
        {
            MySqlCommand sqlCommand = (MySqlCommand)databaseConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = sqlQuery;
            return sqlCommand;
        }



    }

}
