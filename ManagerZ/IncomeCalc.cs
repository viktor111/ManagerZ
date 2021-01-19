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

            double totalMade = 0;
            double totalSpent = 0;
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
    }
}
