using ManagerZ.Data;
using ManagerZ.Models;
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

        public Order GetOrder(string id)
        {
            Order order = new Order();

            SqlConnection con = new SqlConnection(connstr);

            String querry = "SELECT * FROM dbo.Orders WHERE Id=@Id";
            SqlCommand command = new SqlCommand(querry, con);

            command.Parameters.AddWithValue("Id", id);
            con.Open();
            using (SqlDataReader sqlDataReader = command.ExecuteReader())
            {
                while (sqlDataReader.Read())
                {
                    order.Id = Convert.ToInt32(id);
                    order.Status = sqlDataReader["Status"].ToString();
                    order.ProductIds = sqlDataReader["ProductIds"].ToString();
                    order.ProductCount = Convert.ToInt32(sqlDataReader["ProductCount"]);
                    order.PhoneNumber = sqlDataReader["PhoneNumber"].ToString(); ;
                    order.Note = sqlDataReader["Note"].ToString();;
                    order.Name = sqlDataReader["Name"].ToString();;
                    order.Cost = Convert.ToDecimal(sqlDataReader["Cost"]);
                    order.Address = sqlDataReader["Address"].ToString();
                    order.Date = Convert.ToDateTime(sqlDataReader["Date"]);
                    order.Spent = Convert.ToDecimal(sqlDataReader["Spent"]);
                }
            }

            return order;
        }
    }
}
