
namespace ManagerZ
{
    partial class ViewDay
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
            this.label1 = new System.Windows.Forms.Label();
            this.ViewDayBtn = new System.Windows.Forms.Button();
            this.DeleteDayBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DateView = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MostSoldProductView = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.MostSoldCategoryView = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductsSoldView = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TotalMadeView = new System.Windows.Forms.Label();
            this.TotalSpentView = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SelectDay";
            // 
            // ViewDayBtn
            // 
            this.ViewDayBtn.Location = new System.Drawing.Point(417, 54);
            this.ViewDayBtn.Name = "ViewDayBtn";
            this.ViewDayBtn.Size = new System.Drawing.Size(75, 23);
            this.ViewDayBtn.TabIndex = 2;
            this.ViewDayBtn.Text = "View";
            this.ViewDayBtn.UseVisualStyleBackColor = true;
            this.ViewDayBtn.Click += new System.EventHandler(this.ViewDayBtn_Click);
            // 
            // DeleteDayBtn
            // 
            this.DeleteDayBtn.Location = new System.Drawing.Point(521, 54);
            this.DeleteDayBtn.Name = "DeleteDayBtn";
            this.DeleteDayBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteDayBtn.TabIndex = 3;
            this.DeleteDayBtn.Text = "Delete";
            this.DeleteDayBtn.UseVisualStyleBackColor = true;
            this.DeleteDayBtn.Click += new System.EventHandler(this.DeleteDayBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.DateView);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.MostSoldProductView);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.MostSoldCategoryView);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ProductsSoldView);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TotalMadeView);
            this.groupBox1.Controls.Add(this.TotalSpentView);
            this.groupBox1.Location = new System.Drawing.Point(112, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Today";
            // 
            // DateView
            // 
            this.DateView.AutoSize = true;
            this.DateView.Location = new System.Drawing.Point(396, 65);
            this.DateView.Name = "DateView";
            this.DateView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DateView.Size = new System.Drawing.Size(33, 13);
            this.DateView.TabIndex = 17;
            this.DateView.Text = "None";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(348, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Date";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(181, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "MostSoldCategory";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(6, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "TotalSpent";
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(188, 57);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // ViewDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DeleteDayBtn);
            this.Controls.Add(this.ViewDayBtn);
            this.Controls.Add(this.label1);
            this.Name = "ViewDay";
            this.Text = "ViewDay";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ViewDayBtn;
        private System.Windows.Forms.Button DeleteDayBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label DateView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label MostSoldProductView;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label MostSoldCategoryView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ProductsSoldView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label TotalMadeView;
        private System.Windows.Forms.Label TotalSpentView;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}