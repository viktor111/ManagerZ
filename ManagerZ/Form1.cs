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
    public partial class Form1 : Form
    {
        SqlOrder sqlOrder = new SqlOrder();

        public Form1()
        {
            InitializeComponent();

            DataTable da = sqlOrder.GetAllDataAdapter();

            dataGridView1.EditMode = DataGridViewEditMode.EditOnKeystroke;

            dataGridView1.DataSource = da;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable da = sqlOrder.GetAllDataAdapter();

            dataGridView1.EditMode = DataGridViewEditMode.EditOnKeystroke;

            dataGridView1.DataSource = da;
        }
    }
}
