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
    public partial class OrderDetails : Form
    {
        Order order;
        SqlOrder sqlOrder = new SqlOrder();
        SqlDay sqlDay = new SqlDay();

        public OrderDetails(string id)
        {
            order = sqlOrder.GetOrder(id);
            InitializeComponent();

            LbAdress.Text = order.Address;
            LbName.Text = order.Name;
            LbPhoneNumber.Text = order.PhoneNumber;
            LbPrice.Text = order.Cost.ToString();
            LbNote.Text = order.Note;
            LbAdress.Text = order.Address;
            LbStatus.Text = order.Status;
            LbDate.Text = order.Date.ToString();
            LbProductCount.Text = order.ProductCount.ToString();
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            DayModel day = sqlDay.GetOneByDate(DateTime.Now.ToString("yyyy - MM - dd"));

            if(day.Id == 0)
            {
                day.SoldProductsCount += order.ProductCount;
                day.TotalMade += order.Cost;
                day.TotalSpent += order.Spent;
                day.MostCommonProduct = "could not determine";
                day.MostCommonCategory = "could not determine";
                sqlDay.SaveDay(day);
            }
            else
            {
                day.SoldProductsCount += order.ProductCount;
                day.TotalMade += order.Cost;
                day.TotalSpent += order.Spent;
                day.MostCommonProduct = "could not determine";
                day.MostCommonCategory = "could not determine";
                sqlDay.Update(day);
            }
            
        }
    }
}
