using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagerZ.Data;
using ManagerZ.Models;


namespace ManagerZ
{
    public partial class ListProducts : Form
    {
        int id;
        Product product = new Product();
        SqlConnection con = new SqlConnection(@"Server=.;Database=ManagerZ;Integrated Security=True");
        SqlDataAdapter adapt;

        List<string> categoriesTemp = new List<string>(); // Change to DB later
        

        public ListProducts()
        {
            InitializeComponent();
            categoriesTemp.Add("Cake");
            categoriesTemp.Add("Walffe");
            categoriesTemp.Add("Dish");
            CategoryCb.DataSource = categoriesTemp;
        }

        private void ListProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'managerZDataSet1.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter1.Fill(this.managerZDataSet1.Products);
            // TODO: This line of code loads data into the 'managerZDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.managerZDataSet.Products);

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ClearData()
        {
            NameTxt.Text = "";
            PriceTxt.Text = "";
            CostTxt.Text = "";
        }
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {           
           
        }    

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from dbo.Products", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Products(Name, Price, Category, CostToMake, FinalPrice) VALUES(@Name, @Price, @Category, @CostToMake, @FinalPrice)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@Name", product.Name);
            cmd.Parameters.AddWithValue("@Price", product.Price);
            cmd.Parameters.AddWithValue("@Category", product.Category);
            cmd.Parameters.AddWithValue("@CostToMake", product.Cost);
            cmd.Parameters.AddWithValue("@FinalPrice", product.FinalPrice);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted Successfully");
            DisplayData();
            ClearData();

        }

        private void NameTxt_TextChanged(object sender, EventArgs e)
        {
            product.Name = NameTxt.Text;
        }

        private void PriceTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                product.Price = Convert.ToDouble(PriceTxt.Text);
            }
            catch
            {

            }
            
        }

        private void CategoryCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            product.Category = (string)CategoryCb.SelectedItem;
        }

        private void CostTxt_TextChanged(object sender, EventArgs e)
        {
            product.Cost = Convert.ToDouble(CostTxt.Text);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("update tbl_Record set Name=@Name,Price=@Price,Category=@Category,Cost=@CostToMake,FinalPirce=@FinalPrice where ID=@id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@Name", product.Name);
            cmd.Parameters.AddWithValue("@Price", product.Price);
            cmd.Parameters.AddWithValue("@Category", product.Category);
            cmd.Parameters.AddWithValue("@CostToMake", product.Cost);
            cmd.Parameters.AddWithValue("@FinalPrice", product.FinalPrice);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Updated Successfully");
            con.Close();
            DisplayData();
            ClearData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            NameTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            PriceTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            CategoryCb.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            CostTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
