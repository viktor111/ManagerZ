﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            var createProduct = new CreateProduct();
            createProduct.Show();
        }

        private void AllProductsBtn_Click(object sender, EventArgs e)
        {
            var listProducts = new ListProducts();
            listProducts.Show();
        }

        private void DayBtn_Click(object sender, EventArgs e)
        {
            var addDay = new DayAdd();
            addDay.Show();
        }
    }
}
