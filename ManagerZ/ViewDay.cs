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

namespace ManagerZ
{
    public partial class ViewDay : Form
    {
        SqlDay sqlDay = new SqlDay();
        public ViewDay()
        {
            InitializeComponent();
            
        }

        private void ViewDayBtn_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;

            DayModel day = sqlDay.GetOneByDate(date.ToString("yyyy - MM - dd"));

            TotalSpentView.Text = day.TotalSpent.ToString();
            TotalMadeView.Text = day.TotalMade.ToString();
            ProductsSoldView.Text = day.SoldProductsCount.ToString();
            MostSoldProductView.Text = day.MostCommonProduct;
            MostSoldCategoryView.Text = day.MostCommonCategory;
            DateView.Text = day.Date.ToString("yyyy - MM - dd");
        }

        private void DeleteDayBtn_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
            SqlDay sqlDay = new SqlDay();
            sqlDay.DeleteOneByDate(date.ToString("yyyy - MM - dd"));

        }
    }
}
