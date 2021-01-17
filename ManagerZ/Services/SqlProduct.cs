using ManagerZ.Data;
using ManagerZ.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerZ.Services
{
    class SqlProduct : ISqlProduct
    {
        public List<Product> GetAll()
        {
            List<Product> AllProducts = new List<Product>();

            SqlConnector connector = new SqlConnector();

            SqlConnection connection = connector.Connection(@"Server=.;Database=ManagerZ;Integrated Security=True");

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
    }
}
