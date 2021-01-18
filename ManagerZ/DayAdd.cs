using ManagerZ.Data;
using ManagerZ.Models;
using ManagerZ.Services;
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
        SqlProduct sqlProduct = new SqlProduct();
        List<Product> addedProducts = new List<Product>();

        public DayAdd()
        {
            
            InitializeComponent();
            List<Product> allProducts = sqlProduct.GetAll();
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
            string productName = ProductCb.SelectedItem.ToString();

            Product p = sqlProduct.GetOneByName(productName);

            addedProducts.Add(p);

            BindingSource source = new BindingSource();
            source.DataSource = addedProducts;
            dataGridView1.DataSource = source;
        }
    }
}
