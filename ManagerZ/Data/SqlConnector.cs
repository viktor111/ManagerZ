using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.Sqlite;
using System.Configuration;

namespace ManagerZ.Data
{
    class SqlConnector
    {
        public SqlConnection Connection(string connString)
        {
            var connection = new SqlConnection(connString);

            try
            {
                connection.Open();
                connection.Close();
            }
            catch
            {
                
            }

            return connection;
        }


        public SqliteConnection LiteConnection(string connString)
        {

            var connection = new SqliteConnection(connString);

            try
            {
                connection.Open();
                connection.Close();
            }
            catch
            {

            }

            return connection;
        }
    }
}
