using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagerZ.Models;
using System.Data.SqlClient;
using ManagerZ.Data;
using Microsoft.Data.Sqlite;
using System.Configuration;

namespace ManagerZ
{
    public partial class CreateProduct : Form
    {

        Product product = new Product();
        
        public CreateProduct()
        {
            InitializeComponent();

            CategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
        }

        private void NameTb_TextChanged(object sender, EventArgs e)
        {
            string name = NameTb.Text;
            product.Name = name;
        }


        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            product.Category = CategoryComboBox.Text;
        }

        private void ViewProductBtn_Click(object sender, EventArgs e)
        {
            double price = Convert.ToDouble(PriceTb.Text);
            product.Price = price;


            double cost = Convert.ToDouble(CostTb.Text);
            product.Cost = cost;
            NameViewer.Text = product.Name;
            PriceVewer.Text = product.Price.ToString();
            CategoryViewer.Text = product.Category;
            CostViewer.Text = product.Cost.ToString();
            FinalPriceFinalProduct.Text = (product.Price - product.Cost).ToString();
        }

        private void DiscardBtn_Click(object sender, EventArgs e)
        {
            NameViewer.Text = "...";
            PriceVewer.Text = "...";
            CategoryViewer.Text = "...";

            NameTb.Clear();
            PriceTb.Clear();
            CostTb.Clear();
            
            progressBar1.Value = 0;
            
        }

        private void Calculate(int i)
        {
            double pow = Math.Pow(i, i);
        }

        public void DoWork(IProgress<int> progress)
        {
            for (int j = 0; j < 100000; j++)
            {
                Calculate(j);

                if (progress != null)
                    progress.Report((j + 1) * 100 / 100000);
            }
        }

        private async void AddBtn_Click(object sender, EventArgs e)
        {
            double price = Convert.ToDouble(PriceTb.Text);
            product.Price = price;


            double cost = Convert.ToDouble(CostTb.Text);
            product.Cost = cost;

            SqlConnector connector = new SqlConnector();
            string connstr = ConfigurationManager.ConnectionStrings["MsSql"].ConnectionString;
            SqlConnection connection = connector.Connection(connstr);

            connection.Open();
            
            String querry = "INSERT INTO Products(Name, Price, Category, CostToMake, FinalPrice) VALUES(@Name, @Price, @Category, @CostToMake, @FinalPrice)";

            SqlCommand command = new SqlCommand(querry, connection);
            //product.FinalPrice = product.Price - product.Cost;
            command.Parameters.AddWithValue("@Name", product.Name);
            command.Parameters.AddWithValue("@Price", product.Price);
            command.Parameters.AddWithValue("@Category", product.Category);
            command.Parameters.AddWithValue("@CostToMake", product.Cost);
            command.Parameters.AddWithValue("@FinalPrice", product.FinalPrice);

            progressBar1.Maximum = 100;
            progressBar1.Step = 1;

            var progress = new Progress<int>(v =>
            {              
                progressBar1.Value = v;
            });

            
            await Task.Run(() => DoWork(progress));
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void PriceTb_TextChanged(object sender, EventArgs e)
        {
            // ToDo: Check error handle !!!!!!!!!!!!!!
            if (PriceTb.Text.Contains('.'))
            {
                PriceTb.Text = PriceTb.Text.Replace('.', ',');
                MessageBox.Show("Cant include . it was changed to ,");
            }
        }

        private void CostTb_TextChanged(object sender, EventArgs e)
        {
            // ToDo: Check error handle !!!!!!!!!!!!!!
            if (CostTb.Text.Contains("."))
            {
                CostTb.Text = PriceTb.Text.Replace('.', ',');
                MessageBox.Show("Cant include . it was changed to ,");
            }
        }

    }
}
