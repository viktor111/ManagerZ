
namespace ManagerZ
{
    partial class CreateProduct
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ProductViewer = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CategoryViewer = new System.Windows.Forms.Label();
            this.PriceVewer = new System.Windows.Forms.Label();
            this.NameViewer = new System.Windows.Forms.Label();
            this.DiscardBtn = new System.Windows.Forms.Button();
            this.ViewProductBtn = new System.Windows.Forms.Button();
            this.MessageProduct = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.CostLabel = new System.Windows.Forms.Label();
            this.CostFinalProduct = new System.Windows.Forms.Label();
            this.CostViewer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FinalPriceFinalProduct = new System.Windows.Forms.Label();
            this.PriceTb = new System.Windows.Forms.TextBox();
            this.CostTb = new System.Windows.Forms.TextBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductViewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(30, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(73, 426);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.SystemColors.Menu;
            this.NameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NameLabel.Location = new System.Drawing.Point(44, 31);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(37, 15);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name";
            // 
            // NameTb
            // 
            this.NameTb.Location = new System.Drawing.Point(109, 24);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(120, 20);
            this.NameTb.TabIndex = 2;
            this.NameTb.TextChanged += new System.EventHandler(this.NameTb_TextChanged);
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.BackColor = System.Drawing.SystemColors.Menu;
            this.PriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PriceLabel.Location = new System.Drawing.Point(47, 79);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(33, 15);
            this.PriceLabel.TabIndex = 3;
            this.PriceLabel.Text = "Price";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.BackColor = System.Drawing.SystemColors.Menu;
            this.CategoryLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CategoryLabel.Location = new System.Drawing.Point(44, 129);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(51, 15);
            this.CategoryLabel.TabIndex = 5;
            this.CategoryLabel.Text = "Category";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(109, 123);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.CategoryComboBox.TabIndex = 7;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // AddBtn
            // 
            this.AddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddBtn.Location = new System.Drawing.Point(702, 12);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 9;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ProductViewer
            // 
            this.ProductViewer.BackColor = System.Drawing.SystemColors.Info;
            this.ProductViewer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ProductViewer.Controls.Add(this.FinalPriceFinalProduct);
            this.ProductViewer.Controls.Add(this.label4);
            this.ProductViewer.Controls.Add(this.CostViewer);
            this.ProductViewer.Controls.Add(this.CostFinalProduct);
            this.ProductViewer.Controls.Add(this.label3);
            this.ProductViewer.Controls.Add(this.label2);
            this.ProductViewer.Controls.Add(this.label1);
            this.ProductViewer.Controls.Add(this.CategoryViewer);
            this.ProductViewer.Controls.Add(this.PriceVewer);
            this.ProductViewer.Controls.Add(this.NameViewer);
            this.ProductViewer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ProductViewer.Location = new System.Drawing.Point(404, 12);
            this.ProductViewer.Name = "ProductViewer";
            this.ProductViewer.Size = new System.Drawing.Size(258, 420);
            this.ProductViewer.TabIndex = 10;
            this.ProductViewer.TabStop = false;
            this.ProductViewer.Text = "Final Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(32, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(32, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // CategoryViewer
            // 
            this.CategoryViewer.AutoSize = true;
            this.CategoryViewer.Location = new System.Drawing.Point(183, 116);
            this.CategoryViewer.Name = "CategoryViewer";
            this.CategoryViewer.Size = new System.Drawing.Size(16, 13);
            this.CategoryViewer.TabIndex = 2;
            this.CategoryViewer.Text = "...";
            // 
            // PriceVewer
            // 
            this.PriceVewer.AutoSize = true;
            this.PriceVewer.Location = new System.Drawing.Point(183, 74);
            this.PriceVewer.Name = "PriceVewer";
            this.PriceVewer.Size = new System.Drawing.Size(16, 13);
            this.PriceVewer.TabIndex = 1;
            this.PriceVewer.Text = "...";
            // 
            // NameViewer
            // 
            this.NameViewer.AutoSize = true;
            this.NameViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.NameViewer.Location = new System.Drawing.Point(180, 29);
            this.NameViewer.Name = "NameViewer";
            this.NameViewer.Size = new System.Drawing.Size(19, 13);
            this.NameViewer.TabIndex = 0;
            this.NameViewer.Text = "....";
            // 
            // DiscardBtn
            // 
            this.DiscardBtn.Location = new System.Drawing.Point(702, 409);
            this.DiscardBtn.Name = "DiscardBtn";
            this.DiscardBtn.Size = new System.Drawing.Size(75, 23);
            this.DiscardBtn.TabIndex = 11;
            this.DiscardBtn.Text = "Discard";
            this.DiscardBtn.UseVisualStyleBackColor = true;
            this.DiscardBtn.Click += new System.EventHandler(this.DiscardBtn_Click);
            // 
            // ViewProductBtn
            // 
            this.ViewProductBtn.Location = new System.Drawing.Point(323, 205);
            this.ViewProductBtn.Name = "ViewProductBtn";
            this.ViewProductBtn.Size = new System.Drawing.Size(75, 23);
            this.ViewProductBtn.TabIndex = 12;
            this.ViewProductBtn.Text = "ViewProduct";
            this.ViewProductBtn.UseVisualStyleBackColor = true;
            this.ViewProductBtn.Click += new System.EventHandler(this.ViewProductBtn_Click);
            // 
            // MessageProduct
            // 
            this.MessageProduct.AutoSize = true;
            this.MessageProduct.Location = new System.Drawing.Point(741, 231);
            this.MessageProduct.Name = "MessageProduct";
            this.MessageProduct.Size = new System.Drawing.Size(0, 13);
            this.MessageProduct.TabIndex = 13;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(702, 205);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(115, 23);
            this.progressBar1.TabIndex = 14;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CostLabel.Location = new System.Drawing.Point(44, 169);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(30, 15);
            this.CostLabel.TabIndex = 15;
            this.CostLabel.Text = "Cost";
            // 
            // CostFinalProduct
            // 
            this.CostFinalProduct.AutoSize = true;
            this.CostFinalProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CostFinalProduct.Location = new System.Drawing.Point(32, 157);
            this.CostFinalProduct.Name = "CostFinalProduct";
            this.CostFinalProduct.Size = new System.Drawing.Size(30, 15);
            this.CostFinalProduct.TabIndex = 16;
            this.CostFinalProduct.Text = "Cost";
            // 
            // CostViewer
            // 
            this.CostViewer.AutoSize = true;
            this.CostViewer.Location = new System.Drawing.Point(180, 159);
            this.CostViewer.Name = "CostViewer";
            this.CostViewer.Size = new System.Drawing.Size(16, 13);
            this.CostViewer.TabIndex = 17;
            this.CostViewer.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "FinalPrice";
            // 
            // FinalPriceFinalProduct
            // 
            this.FinalPriceFinalProduct.AutoSize = true;
            this.FinalPriceFinalProduct.Location = new System.Drawing.Point(180, 329);
            this.FinalPriceFinalProduct.Name = "FinalPriceFinalProduct";
            this.FinalPriceFinalProduct.Size = new System.Drawing.Size(16, 13);
            this.FinalPriceFinalProduct.TabIndex = 19;
            this.FinalPriceFinalProduct.Text = "...";
            // 
            // PriceTb
            // 
            this.PriceTb.Location = new System.Drawing.Point(109, 74);
            this.PriceTb.Name = "PriceTb";
            this.PriceTb.Size = new System.Drawing.Size(120, 20);
            this.PriceTb.TabIndex = 17;
            this.PriceTb.TextChanged += new System.EventHandler(this.PriceTb_TextChanged);
            // 
            // CostTb
            // 
            this.CostTb.Location = new System.Drawing.Point(109, 171);
            this.CostTb.Name = "CostTb";
            this.CostTb.Size = new System.Drawing.Size(120, 20);
            this.CostTb.TabIndex = 18;
            this.CostTb.TextChanged += new System.EventHandler(this.CostTb_TextChanged);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(ManagerZ.Models.Product);
            // 
            // CreateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 459);
            this.Controls.Add(this.CostTb);
            this.Controls.Add(this.PriceTb);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.MessageProduct);
            this.Controls.Add(this.ViewProductBtn);
            this.Controls.Add(this.DiscardBtn);
            this.Controls.Add(this.ProductViewer);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.NameTb);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.listView1);
            this.Name = "CreateProduct";
            this.Text = "CreateProduct";
            this.ProductViewer.ResumeLayout(false);
            this.ProductViewer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTb;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.GroupBox ProductViewer;
        private System.Windows.Forms.Label CategoryViewer;
        private System.Windows.Forms.Label PriceVewer;
        private System.Windows.Forms.Label NameViewer;
        private System.Windows.Forms.Button DiscardBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ViewProductBtn;
        private System.Windows.Forms.Label MessageProduct;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label FinalPriceFinalProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CostViewer;
        private System.Windows.Forms.Label CostFinalProduct;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.TextBox PriceTb;
        private System.Windows.Forms.TextBox CostTb;
    }
}