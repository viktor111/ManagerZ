
namespace ManagerZ
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.AllProductsBtn = new System.Windows.Forms.Button();
            this.DayBtn = new System.Windows.Forms.Button();
            this.ViewDayBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(62, 106);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(130, 333);
            this.treeView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // BtnCreate
            // 
            this.BtnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCreate.Location = new System.Drawing.Point(83, 122);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(87, 23);
            this.BtnCreate.TabIndex = 2;
            this.BtnCreate.Text = "NewProduct";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // AllProductsBtn
            // 
            this.AllProductsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AllProductsBtn.Location = new System.Drawing.Point(83, 161);
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
            this.DayBtn.Location = new System.Drawing.Point(83, 200);
            this.DayBtn.Name = "DayBtn";
            this.DayBtn.Size = new System.Drawing.Size(87, 23);
            this.DayBtn.TabIndex = 5;
            this.DayBtn.Text = "AddDay";
            this.DayBtn.UseVisualStyleBackColor = true;
            this.DayBtn.Click += new System.EventHandler(this.DayBtn_Click);
            // 
            // ViewDayBtn
            // 
            this.ViewDayBtn.Location = new System.Drawing.Point(83, 240);
            this.ViewDayBtn.Name = "ViewDayBtn";
            this.ViewDayBtn.Size = new System.Drawing.Size(87, 23);
            this.ViewDayBtn.TabIndex = 6;
            this.ViewDayBtn.Text = "ViewDay";
            this.ViewDayBtn.UseVisualStyleBackColor = true;
            this.ViewDayBtn.Click += new System.EventHandler(this.ViewDayBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calculator";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Menu;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Menu;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(174, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "...";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(267, 471);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ViewDayBtn);
            this.Controls.Add(this.DayBtn);
            this.Controls.Add(this.AllProductsBtn);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button AllProductsBtn;
        private System.Windows.Forms.Button DayBtn;
        private System.Windows.Forms.Button ViewDayBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

