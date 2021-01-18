
namespace ManagerZ
{
    partial class Form1
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AllProductsBtn = new System.Windows.Forms.Button();
            this.DayBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 105);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(130, 333);
            this.treeView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // BtnCreate
            // 
            this.BtnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCreate.Location = new System.Drawing.Point(30, 119);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(87, 23);
            this.BtnCreate.TabIndex = 2;
            this.BtnCreate.Text = "NewProduct";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(30, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "NewEmployee";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AllProductsBtn
            // 
            this.AllProductsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AllProductsBtn.Location = new System.Drawing.Point(30, 208);
            this.AllProductsBtn.Name = "AllProductsBtn";
            this.AllProductsBtn.Size = new System.Drawing.Size(87, 23);
            this.AllProductsBtn.TabIndex = 4;
            this.AllProductsBtn.Text = "AllProducts";
            this.AllProductsBtn.UseVisualStyleBackColor = true;
            this.AllProductsBtn.Click += new System.EventHandler(this.AllProductsBtn_Click);
            // 
            // DayBtn
            // 
            this.DayBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DayBtn.Location = new System.Drawing.Point(30, 253);
            this.DayBtn.Name = "DayBtn";
            this.DayBtn.Size = new System.Drawing.Size(87, 23);
            this.DayBtn.TabIndex = 5;
            this.DayBtn.Text = "AddDay";
            this.DayBtn.UseVisualStyleBackColor = true;
            this.DayBtn.Click += new System.EventHandler(this.DayBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DayBtn);
            this.Controls.Add(this.AllProductsBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AllProductsBtn;
        private System.Windows.Forms.Button DayBtn;
    }
}

