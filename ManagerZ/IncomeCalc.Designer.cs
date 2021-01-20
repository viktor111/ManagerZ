
namespace ManagerZ
{
    partial class IncomeCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncomeCalc));
            this.BeginDtp = new System.Windows.Forms.DateTimePicker();
            this.EndDtp = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StartCalcBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MostSoldProductView = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.MostSoldCategoryView = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductsSoldView = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TotalMadeView = new System.Windows.Forms.Label();
            this.TotalSpentView = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BeginDtp
            // 
            this.BeginDtp.Location = new System.Drawing.Point(87, 41);
            this.BeginDtp.Name = "BeginDtp";
            this.BeginDtp.Size = new System.Drawing.Size(200, 20);
            this.BeginDtp.TabIndex = 0;
            // 
            // EndDtp
            // 
            this.EndDtp.Location = new System.Drawing.Point(87, 88);
            this.EndDtp.Name = "EndDtp";
            this.EndDtp.Size = new System.Drawing.Size(200, 20);
            this.EndDtp.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "BeginDate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "EndDate";
            // 
            // StartCalcBtn
            // 
            this.StartCalcBtn.Location = new System.Drawing.Point(341, 67);
            this.StartCalcBtn.Name = "StartCalcBtn";
            this.StartCalcBtn.Size = new System.Drawing.Size(75, 23);
            this.StartCalcBtn.TabIndex = 4;
            this.StartCalcBtn.Text = "Calculate";
            this.StartCalcBtn.UseVisualStyleBackColor = true;
            this.StartCalcBtn.Click += new System.EventHandler(this.StartCalcBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.MostSoldProductView);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.MostSoldCategoryView);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ProductsSoldView);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TotalMadeView);
            this.groupBox1.Controls.Add(this.TotalSpentView);
            this.groupBox1.Location = new System.Drawing.Point(15, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Income";
            // 
            // MostSoldProductView
            // 
            this.MostSoldProductView.AutoSize = true;
            this.MostSoldProductView.Location = new System.Drawing.Point(454, 39);
            this.MostSoldProductView.Name = "MostSoldProductView";
            this.MostSoldProductView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MostSoldProductView.Size = new System.Drawing.Size(33, 13);
            this.MostSoldProductView.TabIndex = 15;
            this.MostSoldProductView.Text = "None";
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
            // MostSoldCategoryView
            // 
            this.MostSoldCategoryView.AutoSize = true;
            this.MostSoldCategoryView.Location = new System.Drawing.Point(280, 63);
            this.MostSoldCategoryView.Name = "MostSoldCategoryView";
            this.MostSoldCategoryView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MostSoldCategoryView.Size = new System.Drawing.Size(33, 13);
            this.MostSoldCategoryView.TabIndex = 13;
            this.MostSoldCategoryView.Text = "None";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(181, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "MostSoldCategory";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(6, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "TotalEarned";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(6, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "TotalSpent";
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
            // TotalSpentView
            // 
            this.TotalSpentView.AutoSize = true;
            this.TotalSpentView.Location = new System.Drawing.Point(87, 63);
            this.TotalSpentView.Name = "TotalSpentView";
            this.TotalSpentView.Size = new System.Drawing.Size(28, 13);
            this.TotalSpentView.TabIndex = 5;
            this.TotalSpentView.Text = "0,00";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(469, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IncomeCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(554, 264);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StartCalcBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EndDtp);
            this.Controls.Add(this.BeginDtp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IncomeCalc";
            this.Text = "IncomeCalc";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker BeginDtp;
        private System.Windows.Forms.DateTimePicker EndDtp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StartCalcBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label MostSoldProductView;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label MostSoldCategoryView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ProductsSoldView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label TotalMadeView;
        private System.Windows.Forms.Label TotalSpentView;
        private System.Windows.Forms.Button button1;
    }
}