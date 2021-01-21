using ManagerZ.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerZ
{
    public partial class AllProducts : Form
    {
        SqlProduct sqlProduct = new SqlProduct();



        public AllProducts()
        {
            InitializeComponent();
            DataTable da = sqlProduct.GetAllDataAdapter();

            dataGridView1.EditMode = DataGridViewEditMode.EditOnKeystroke;

            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;

            dataGridView1.DataSource = da;
        }



        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView datagridView1 = (DataGridView)sender;

            int colIndexEdited = e.ColumnIndex;
            int rowIndexEdited = e.RowIndex;

            int id = Convert.ToInt32(dataGridView1.Rows[rowIndexEdited].Cells[0].Value);
            string propertyEdited = dataGridView1.Columns[colIndexEdited].HeaderText;
            string valueEdited = dataGridView1.Rows[rowIndexEdited].Cells[colIndexEdited].Value.ToString();

            sqlProduct.UpdateById(id, propertyEdited, valueEdited);
            datagridView1.Refresh();
        }
    }
}
