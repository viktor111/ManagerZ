using ManagerZ.Data;
using ManagerZ.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerZ.Services
{
    class SqlDay : ISqlDay
    {

        SqlConnector connector = new SqlConnector();
        string connstr = ConfigurationManager.ConnectionStrings["MsSqlIp"].ConnectionString;

        public void DeleteOneByDate(string date)
        {            
            SqlConnection connection = connector.Connection(connstr);
            String querry = "DELETE FROM dbo.Days WHERE Date=@Date";
            connection.Open();
            SqlCommand command = new SqlCommand(querry, connection);
            command.Parameters.AddWithValue("@Date", date);
            command.ExecuteNonQuery();
            
            connection.Close();
        }

        public DayModel GetOneByDate(string date)
        {
            
            SqlConnection connection = connector.Connection(connstr);
            DayModel day = new DayModel();
            String querry = "SELECT * FROM dbo.Days WHERE Date=@Date";
            SqlCommand command = new SqlCommand(querry, connection);

            command.Parameters.AddWithValue("Date", date);
            connection.Open();
            using (SqlDataReader sqlDataReader = command.ExecuteReader())
            {
                while (sqlDataReader.Read())
                {
                    day.Id = Convert.ToInt32(sqlDataReader["Id"]);
                    day.TotalMade = Convert.ToDouble(sqlDataReader["TotalMade"]);
                    day.TotalSpent = Convert.ToDouble(sqlDataReader["TotalSpent"]);
                    day.SoldProductsCount = Convert.ToInt32(sqlDataReader["SoldProductsCount"]);
                    day.MostCommonCategory = sqlDataReader["MostCommonCategory"].ToString();
                    day.MostCommonProduct = sqlDataReader["MostCommonProduct"].ToString();                  
                }
                connection.Close();
            }
            return day;
        }

        public DayModel SaveDay(DayModel day)
        {
            SqlConnector connector = new SqlConnector();
          
            SqlConnection connection = connector.Connection(connstr);

            connection.Open();

            String querry = "INSERT INTO Days(TotalMade, TotalSpent, SoldProductsCount, MostCommonProduct, MostCommonCategory, Date) VALUES(@TotalMade, @TotalSpent, @SoldProductsCount, @MostCommonProduct, @MostCommonCategory, @Date)";

            SqlCommand command = new SqlCommand(querry, connection);

            command.Parameters.AddWithValue("@TotalMade", day.TotalMade);
            command.Parameters.AddWithValue("@TotalSpent", day.TotalSpent);
            command.Parameters.AddWithValue("@SoldProductsCount", day.SoldProductsCount);
            command.Parameters.AddWithValue("@MostCommonProduct", day.MostCommonProduct);
            command.Parameters.AddWithValue("@MostCommonCategory", day.MostCommonCategory);
            command.Parameters.AddWithValue("@Date", day.Date);

            command.ExecuteNonQuery();

            connection.Close();

            return day;
        }      
    }
}
