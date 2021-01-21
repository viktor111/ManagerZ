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
using System.Windows.Forms;

namespace ManagerZ.Services
{
    class SqlProduct : ISqlProduct
    {
        SqlConnector connector = new SqlConnector();

        string connstr = ConfigurationManager.ConnectionStrings["MsSqlIp"].ConnectionString;



        public List<Product> GetAll()
        {
            List<Product> AllProducts = new List<Product>();
            
            SqlConnection connection = connector.Connection(connstr);

            String querry = "SELECT * FROM dbo.Products";
            SqlCommand command = new SqlCommand(querry, connection);
            connection.Open();
            using (SqlDataReader sqlDataReader = command.ExecuteReader())
            {
                while (sqlDataReader.Read())
                {
                    Product product = new Product();
                    product.Id = (int)sqlDataReader["Id"];
                    product.Name = sqlDataReader["Name"].ToString();
                    product.Price = Convert.ToDouble(sqlDataReader["Price"]);
                    product.Category = sqlDataReader["Category"].ToString();
                    product.Cost = Convert.ToDouble(sqlDataReader["Price"]);

                    AllProducts.Add(product);
                }
                connection.Close();
            }
            return AllProducts;
        }

        public DataTable GetAllDataAdapter()
        {

            SqlConnection con = new SqlConnection(connstr);

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = con;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "Select * from Products";
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);

            return dtRecord;
        }

        public Product GetOneByName(string name)
        {
            SqlConnection connection = connector.Connection(connstr);
            Product product = new Product();
            String querry = "SELECT * FROM dbo.Products WHERE Name=@Name";
            SqlCommand command = new SqlCommand(querry, connection);

            command.Parameters.AddWithValue("Name", name);
            connection.Open();
            using (SqlDataReader sqlDataReader = command.ExecuteReader())
            {
                while (sqlDataReader.Read())
                {
                    product.Id = (int)sqlDataReader["Id"];
                    product.Name = sqlDataReader["Name"].ToString();
                    product.Price = Convert.ToDouble(sqlDataReader["Price"]);
                    product.Category = sqlDataReader["Category"].ToString();
                    product.Cost = Convert.ToDouble(sqlDataReader["CostToMake"]);
                }
                connection.Close();
            }
            return product;
        }

        public string UpdateById(int id, string propertyToUpdate, string data)
        {
            if(data == "")
            {
                MessageBox.Show("Please input something!");
            }
            else
            {
                SqlConnection connection = connector.Connection(connstr);
                string querry = $"UPDATE Products SET {propertyToUpdate} = @data WHERE Id = {id}";
                SqlCommand command = new SqlCommand(querry, connection);
                command.Parameters.AddWithValue("@data", data);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            return propertyToUpdate;
        }
    }
}
