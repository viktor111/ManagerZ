using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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
    }
}
