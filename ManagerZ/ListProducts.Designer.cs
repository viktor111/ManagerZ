
namespace ManagerZ
{
    partial class ListProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListProducts));
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managerZDataSet = new ManagerZ.ManagerZDataSet();
            this.productsTableAdapter = new ManagerZ.ManagerZDataSetTableAdapters.ProductsTableAdapter();
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.managerZDataSet1 = new ManagerZ.ManagerZDataSet1();
            this.productsTableAdapter1 = new ManagerZ.ManagerZDataSet1TableAdapters.ProductsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costToMakeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerZDataSet2 = new ManagerZ.ManagerZDataSet2();
            this.productsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter2 = new ManagerZ.ManagerZDataSet2TableAdapters.ProductsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerZDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerZDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerZDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.managerZDataSet;
            // 
            // managerZDataSet
            // 
            this.managerZDataSet.DataSetName = "ManagerZDataSet";
            this.managerZDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataMember = "Products";
            this.productsBindingSource1.DataSource = this.managerZDataSet1;
            // 
            // managerZDataSet1
            // 
            this.managerZDataSet1.DataSetName = "ManagerZDataSet1";
            this.managerZDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.costToMakeDataGridViewTextBoxColumn,
            this.finalPriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productsBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(648, 429);
            this.dataGridView1.TabIndex = 0;
            //this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            //this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellBeginEdit);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // costToMakeDataGridViewTextBoxColumn
            // 
            this.costToMakeDataGridViewTextBoxColumn.DataPropertyName = "CostToMake";
            this.costToMakeDataGridViewTextBoxColumn.HeaderText = "CostToMake";
            this.costToMakeDataGridViewTextBoxColumn.Name = "costToMakeDataGridViewTextBoxColumn";
            // 
            // finalPriceDataGridViewTextBoxColumn
            // 
            this.finalPriceDataGridViewTextBoxColumn.DataPropertyName = "FinalPrice";
            this.finalPriceDataGridViewTextBoxColumn.HeaderText = "FinalPrice";
            this.finalPriceDataGridViewTextBoxColumn.Name = "finalPriceDataGridViewTextBoxColumn";
            // 
            // managerZDataSet2
            // 
            this.managerZDataSet2.DataSetName = "ManagerZDataSet2";
            this.managerZDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource2
            // 
            this.productsBindingSource2.DataMember = "Products";
            this.productsBindingSource2.DataSource = this.managerZDataSet2;
            // 
            // productsTableAdapter2
            // 
            this.productsTableAdapter2.ClearBeforeFill = true;
            // 
            // ListProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(672, 453);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListProducts";
            this.Text = "ListProducts";
            this.Load += new System.EventHandler(this.ListProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerZDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerZDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerZDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ManagerZDataSet managerZDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private ManagerZDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private ManagerZDataSet1 managerZDataSet1;
        private System.Windows.Forms.BindingSource productsBindingSource1;
        private ManagerZDataSet1TableAdapters.ProductsTableAdapter productsTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costToMakeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalPriceDataGridViewTextBoxColumn;
        private ManagerZDataSet2 managerZDataSet2;
        private System.Windows.Forms.BindingSource productsBindingSource2;
        private ManagerZDataSet2TableAdapters.ProductsTableAdapter productsTableAdapter2;
    }
}