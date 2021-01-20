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
using ManagerZ.Services;

namespace ManagerZ
{
    public partial class ListProducts : Form
    {
        int id;
        Product product = new Product();
        SqlConnection con = new SqlConnection(@"Server=.;Database=ManagerZ;Integrated Security=True");
        SqlDataAdapter adapt;
        
        public ListProducts()
        {
            InitializeComponent();
            dataGridView1.EditMode = DataGridViewEditMode.EditOnKeystroke;
            //dataGridView1.CellBeginEdit += dataGridView1_CellBeginEdit;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
        }

        private void ListProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'managerZDataSet2.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter2.Fill(this.managerZDataSet2.Products);

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView datagridView1 = (DataGridView)sender;

            int colIndexEdited = e.ColumnIndex;
            int rowIndexEdited = e.RowIndex;

            int id = Convert.ToInt32(dataGridView1.Rows[rowIndexEdited].Cells[0].Value);
            string propertyEdited  = dataGridView1.Columns[colIndexEdited].HeaderText;
            string valueEdited = dataGridView1.Rows[rowIndexEdited].Cells[colIndexEdited].Value.ToString();

            SqlProduct sqlProduct = new SqlProduct();
            sqlProduct.UpdateById(id, propertyEdited, valueEdited);
            datagridView1.Refresh();
        }
    }
}
