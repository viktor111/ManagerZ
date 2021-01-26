using ManagerZ.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerZ.Services
{
    class SqlOrder
    {

        SqlConnector connector = new SqlConnector();

        string connstr = ConfigurationManager.ConnectionStrings["MsSqlIp"].ConnectionString;

        public DataTable GetAllDataAdapter()
        {

            SqlConnection con = new SqlConnection(connstr);

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = con;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "Select * from Orders";
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);

            return dtRecord;
        }
    }
}
