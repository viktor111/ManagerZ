
namespace ManagerZ
{
    partial class DayAdd
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
            this.ProductCb = new System.Windows.Forms.ComboBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.FinalizeDayBtn = new System.Windows.Forms.Button();
            this.TotalSpentView = new System.Windows.Forms.Label();
            this.TotalMadeView = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProductsSoldView = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MostSoldCategory = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.MostSoldProduct = new System.Windows.Forms.Label();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductCb
            // 
            this.ProductCb.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ProductCb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProductCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductCb.FormattingEnabled = true;
            this.ProductCb.Location = new System.Drawing.Point(43, 31);
            this.ProductCb.Name = "ProductCb";
            this.ProductCb.Size = new System.Drawing.Size(121, 21);
            this.ProductCb.TabIndex = 0;
            this.ProductCb.SelectedIndexChanged += new System.EventHandler(this.ProductCb_SelectedIndexChanged);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.SystemColors.Control;
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtn.Location = new System.Drawing.Point(227, 29);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // FinalizeDayBtn
            // 
            this.FinalizeDayBtn.Location = new System.Drawing.Point(617, 392);
            this.FinalizeDayBtn.Name = "FinalizeDayBtn";
            this.FinalizeDayBtn.Size = new System.Drawing.Size(75, 23);
            this.FinalizeDayBtn.TabIndex = 4;
            this.FinalizeDayBtn.Text = "FinalizeDay";
            this.FinalizeDayBtn.UseVisualStyleBackColor = true;
            // 
            // TotalSpentView
            // 
            this.TotalSpentView.AutoSize = true;
            this.TotalSpentView.Location = new System.Drawing.Point(87, 63);
            this.TotalSpentView.Name = "TotalSpentView";
            this.TotalSpentView.Size = new System.Drawing.Size(28, 13);
            this.TotalSpentView.TabIndex = 5;
            this.TotalSpentView.Text = "0,00";
            // 
            // TotalMadeView
            // 
            this.TotalMadeView.AutoSize = true;
            this.TotalMadeView.Location = new System.Drawing.Point(87, 37);
            this.TotalMadeView.Name = "TotalMadeView";
            this.TotalMadeView.Size = new System.Drawing.Size(28, 13);
            this.TotalMadeView.TabIndex = 6;
            this.TotalMadeView.Text = "0,00";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(639, 214);
            this.dataGridView1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "TotalSpent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(6, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "TotalEarned";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.MostSoldProduct);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.MostSoldCategory);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ProductsSoldView);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TotalMadeView);
            this.groupBox1.Controls.Add(this.TotalSpentView);
            this.groupBox1.Location = new System.Drawing.Point(53, 337);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Today";
            // 
            // ProductsSoldView
            // 
            this.ProductsSoldView.AutoSize = true;
            this.ProductsSoldView.Location = new System.Drawing.Point(277, 39);
            this.ProductsSoldView.Name = "ProductsSoldView";
            this.ProductsSoldView.Size = new System.Drawing.Size(13, 13);
            this.ProductsSoldView.TabIndex = 11;
            this.ProductsSoldView.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(181, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "ProductsSold";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.AddBtn);
            this.groupBox2.Controls.Add(this.ProductCb);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(53, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 75);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AddProduct";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(181, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "MostSoldCategory";
            // 
            // MostSoldCategory
            // 
            this.MostSoldCategory.AutoSize = true;
            this.MostSoldCategory.Location = new System.Drawing.Point(280, 63);
            this.MostSoldCategory.Name = "MostSoldCategory";
            this.MostSoldCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MostSoldCategory.Size = new System.Drawing.Size(33, 13);
            this.MostSoldCategory.TabIndex = 13;
            this.MostSoldCategory.Text = "None";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(348, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 15);
            this.label11.TabIndex = 14;
            this.label11.Text = "MostSoldProduct";
            // 
            // MostSoldProduct
            // 
            this.MostSoldProduct.AutoSize = true;
            this.MostSoldProduct.Location = new System.Drawing.Point(454, 39);
            this.MostSoldProduct.Name = "MostSoldProduct";
            this.MostSoldProduct.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MostSoldProduct.Size = new System.Drawing.Size(33, 13);
            this.MostSoldProduct.TabIndex = 15;
            this.MostSoldProduct.Text = "None";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(ManagerZ.Models.Product);
            // 
            // DayAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.FinalizeDayBtn);
            this.Name = "DayAdd";
            this.Text = "DayAdd";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ProductCb;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Button FinalizeDayBtn;
        private System.Windows.Forms.Label TotalSpentView;
        private System.Windows.Forms.Label TotalMadeView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label ProductsSoldView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label MostSoldCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MostSoldProduct;
        private System.Windows.Forms.Label label11;
    }
}