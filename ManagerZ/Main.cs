using System;
using System.Windows.Forms;

namespace ManagerZ
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Interval = 1000;
            label3.Text = DateTime.Now.ToString("MMMM-dd-yyyy");

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
            var listProducts = new AllProducts();
            listProducts.Show();
        }

        private void DayBtn_Click(object sender, EventArgs e)
        {
            var addDay = new DayAdd();
            addDay.Show();
        }

        private void ViewDayBtn_Click(object sender, EventArgs e)
        {
            var viewDay = new ViewDay();
            viewDay.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var incomeCalc = new IncomeCalc();
            incomeCalc.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var incomeCalc = new Form1();
            incomeCalc.Show();
        }
    }
}
