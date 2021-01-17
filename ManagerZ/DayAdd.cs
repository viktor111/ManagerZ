using ManagerZ.Data;
using ManagerZ.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerZ
{
    public partial class DayAdd : Form
    {
        
        private List<Product> AllProducts()
        {
            List<Product> AllProducts = new List<Product>();
            
            SqlConnector connector = new SqlConnector();

            SqlConnection connection = connector.Connection(@"Server=.;Database=ManagerZ;Integrated Security=True");

            String querry = "SELECT * FROM dbo.Products";
            SqlCommand command = new SqlCommand(querry, connection);
            connection.Open();
            using(SqlDataReader sqlDataReader = command.ExecuteReader())
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
        
        public DayAdd()
        {
            InitializeComponent();
            List<Product> allProducts = AllProducts();
            foreach (Product p in allProducts)
            {
                ProductCb.Items.Add(p.Name);
            }
        }

        private void ProductCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
