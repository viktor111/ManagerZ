using ManagerZ.Models;
using ManagerZ.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ML;
using System.Drawing.Printing;
using Microsoft.ML.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ManagerZ
{
    public partial class IncomeCalc : Form
    {
        public IncomeCalc()
        {
            InitializeComponent();
        }

        private void StartCalcBtn_Click(object sender, EventArgs e)
        {
            List<string> categoryCommon = new List<string>();
            List<string> nameCommon = new List<string>();

            SqlDay sqlDay = new SqlDay();
            DateTime beginDt = BeginDtp.Value;
            DateTime endDt = EndDtp.Value;

            decimal totalMade = 0;
            decimal totalSpent = 0;
            int totalProductsSold = 0;
           

            while (true)
            {
                DayModel day = new DayModel();
                day = sqlDay.GetOneByDate(beginDt.ToString("yyyy - MM - dd"));
                totalMade += day.TotalMade;
                totalSpent += day.TotalSpent;
                totalProductsSold += day.SoldProductsCount;
                categoryCommon.Add(day.MostCommonCategory);
                nameCommon.Add(day.MostCommonProduct);

                if (beginDt.ToString("yyyy - MM - dd") == endDt.ToString("yyyy - MM - dd"))
                {
                    break;
                }

                beginDt = beginDt.AddDays(1);
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


            TotalMadeView.Text = totalMade.ToString();
            TotalSpentView.Text = totalSpent.ToString();
            ProductsSoldView.Text = totalProductsSold.ToString();
            MostSoldProductView.Text = mostCommonName;
            MostSoldCategoryView.Text = mostCommonCategory;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument documnet = new PrintDocument();

            printDialog.Document = documnet;
            documnet.PrintPage += new PrintPageEventHandler(documnet_PrintPage);

            DialogResult res = printDialog.ShowDialog();

            if(res == DialogResult.OK)
            {
                documnet.Print();
            }
        }

        private void documnet_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;

            Font font = new Font("Courier New", 12);

            float height = font.GetHeight();

            int startX = 10;
            int startY = 10;
            string beginDt = BeginDtp.Value.ToString("yyyy - MM - dd");
            string endDt = EndDtp.Value.ToString("yyyy - MM - dd");

            string totalMade = "Total Made:  " + TotalMadeView.Text;
            string totalSpent = "Total Spent:  " + TotalSpentView.Text;
            string productsSold = "Total Sold:  " + ProductsSoldView.Text;
            string mostSoldProduct = "Most sold product:  " + MostSoldProductView.Text;
            string mostSoldCategory = "Most sold category:  " + MostSoldCategoryView.Text;

            graphics.DrawString(beginDt, new Font("Courier New", 18), new SolidBrush(Color.Black),startX,startY);
            graphics.DrawString(endDt, new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY + 20);

            graphics.DrawString(totalMade, font, new SolidBrush(Color.Black), startX, startY + 40);
            graphics.DrawString(totalSpent, font, new SolidBrush(Color.Black), startX, startY + 55);
            graphics.DrawString(productsSold, font, new SolidBrush(Color.Black), startX, startY + 70);
            graphics.DrawString(mostSoldProduct, font, new SolidBrush(Color.Black), startX, startY + 85);
            graphics.DrawString(mostSoldCategory, font, new SolidBrush(Color.Black), startX, startY + 105);
        }
    }
}
