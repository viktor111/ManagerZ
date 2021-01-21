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
        DayModel day = new DayModel();

        public DayAdd()
        {
            InitializeComponent();
            List<Product> allProducts = sqlProduct.GetAll();
            foreach (Product p in allProducts)
            {
                ProductCb.Items.Add(p.Name);
            }
            Date.Text = day.Date.ToString("MM/dd/yyyy");
        }

        private void ProductCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e) 
        {
            if(ProductCb.SelectedItem == null)
            {
                MessageBox.Show("Cant be empty");
            }
            else
            {
                string productName = ProductCb.SelectedItem.ToString();
                Product p = sqlProduct.GetOneByName(productName);

                addedProducts.Add(p);

                BindingSource source = new BindingSource();
                source.DataSource = addedProducts;
                dataGridView1.DataSource = source;

                double totalEarned = Convert.ToDouble(TotalMadeView.Text) + p.FinalPrice;
                double totalSpend = Convert.ToDouble(TotalSpentView.Text) + p.Cost;
                int productsSold = dataGridView1.Rows.Count - 1;

                TotalMadeView.Text = totalEarned.ToString();
                TotalSpentView.Text = totalSpend.ToString();
                ProductsSoldView.Text = productsSold.ToString();

                List<string> categoryCommon = new List<string>();
                List<string> nameCommon = new List<string>();
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    string category = dataGridView1.Rows[i].Cells["Category"].Value.ToString();
                    categoryCommon.Add(category);
                }
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    string category = dataGridView1.Rows[i].Cells["Name"].Value.ToString();
                    nameCommon.Add(category);
                }

                var mostCommonCategory = categoryCommon
                    .GroupBy(i => i)
                    .OrderByDescending(grp => grp
                    .Count())
                    .Select(grp => grp.Key)
                    .First();
                var mostCommonName = nameCommon
                   .GroupBy(i => i)
                   .OrderByDescending(grp => grp
                   .Count())
                   .Select(grp => grp.Key)
                   .First();

                MostSoldCategory.Text = mostCommonCategory;
                MostSoldProduct.Text = mostCommonName;
            }

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

        private async void FinalizeDayBtn_Click(object sender, EventArgs e)
        {

            bool dayExist = false;

            SqlDay sqlDay = new SqlDay();

            DayModel dayChek = sqlDay.GetOneByDate(day.Date.ToString("yyyy - MM - dd"));
            if (dayChek.Id != 0)
            {
                dayExist = true;
            }


            double totalEarned = Convert.ToDouble(TotalMadeView.Text);
            double totalSpend = Convert.ToDouble(TotalSpentView.Text);
            int productsSold = dataGridView1.Rows.Count - 1;


            List<string> categoryCommon = new List<string>();
            List<string> nameCommon = new List<string>();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                string category = dataGridView1.Rows[i].Cells["Category"].Value.ToString();
                categoryCommon.Add(category);
            }
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                string category = dataGridView1.Rows[i].Cells["Name"].Value.ToString();
                nameCommon.Add(category);
            }

            var mostCommonCategory = categoryCommon
                .GroupBy(i => i)
                .OrderByDescending(grp => grp
                .Count())
                .Select(grp => grp.Key)
                .First();
            var mostCommonName = nameCommon
               .GroupBy(i => i)
               .OrderByDescending(grp => grp
               .Count())
               .Select(grp => grp.Key)
               .First();

            MostSoldCategory.Text = mostCommonCategory;
            MostSoldProduct.Text = mostCommonName;

            day.MostCommonCategory = mostCommonCategory;
            day.MostCommonProduct = mostCommonName;
            day.SoldProductsCount = productsSold;
            day.TotalMade = totalEarned;
            day.TotalSpent = totalSpend;

            progressBar1.Maximum = 100;
            progressBar1.Step = 1;

            var progress = new Progress<int>(v =>
            {
                progressBar1.Value = v;
            });


            await Task.Run(() => DoWork(progress));

            if (!dayExist)
            {
                sqlDay.SaveDay(day);
            }
            else
            {

                DayModel newDay = new DayModel();
                newDay.Id = dayChek.Id;
                newDay.TotalMade = dayChek.TotalMade + day.TotalMade;
                newDay.TotalSpent = dayChek.TotalSpent + day.TotalSpent;
                newDay.SoldProductsCount = dayChek.SoldProductsCount + day.SoldProductsCount;
                newDay.MostCommonProduct = dayChek.MostCommonProduct;
                newDay.MostCommonCategory = dayChek.MostCommonCategory;

                sqlDay.Update(newDay);
            }

        }
    }
}
