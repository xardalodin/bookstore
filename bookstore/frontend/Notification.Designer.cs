namespace bookstore.frontend
{
    partial class Notification
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
            this.LVnotif = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.LVnotInStock = new System.Windows.Forms.ListView();
            this.titleLVnotif = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.authorLVnotif = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceLVnotif = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumberLVnotif = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.titleLVnotInStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.authorLVnotInStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceLVnotInStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.instockLVnotInStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.tbTopay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "These books books have been bought";
            // 
            // LVnotif
            // 
            this.LVnotif.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.titleLVnotif,
            this.authorLVnotif,
            this.priceLVnotif,
            this.NumberLVnotif});
            this.LVnotif.GridLines = true;
            this.LVnotif.Location = new System.Drawing.Point(16, 30);
            this.LVnotif.MultiSelect = false;
            this.LVnotif.Name = "LVnotif";
            this.LVnotif.Size = new System.Drawing.Size(597, 170);
            this.LVnotif.TabIndex = 1;
            this.LVnotif.UseCompatibleStateImageBehavior = false;
            this.LVnotif.View = System.Windows.Forms.View.Details;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "These Books are not in Stock at the moment";
            // 
            // LVnotInStock
            // 
            this.LVnotInStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.titleLVnotInStock,
            this.authorLVnotInStock,
            this.priceLVnotInStock,
            this.instockLVnotInStock});
            this.LVnotInStock.GridLines = true;
            this.LVnotInStock.Location = new System.Drawing.Point(19, 242);
            this.LVnotInStock.Name = "LVnotInStock";
            this.LVnotInStock.Size = new System.Drawing.Size(594, 112);
            this.LVnotInStock.TabIndex = 3;
            this.LVnotInStock.UseCompatibleStateImageBehavior = false;
            this.LVnotInStock.View = System.Windows.Forms.View.Details;
            // 
            // titleLVnotif
            // 
            this.titleLVnotif.Text = "Title";
            this.titleLVnotif.Width = 100;
            // 
            // authorLVnotif
            // 
            this.authorLVnotif.Text = "Author";
            this.authorLVnotif.Width = 100;
            // 
            // priceLVnotif
            // 
            this.priceLVnotif.Text = "Price";
            // 
            // NumberLVnotif
            // 
            this.NumberLVnotif.Text = "Number Orderd";
            this.NumberLVnotif.Width = 100;
            // 
            // titleLVnotInStock
            // 
            this.titleLVnotInStock.Text = "Title";
            this.titleLVnotInStock.Width = 100;
            // 
            // authorLVnotInStock
            // 
            this.authorLVnotInStock.Text = "Author";
            this.authorLVnotInStock.Width = 100;
            // 
            // priceLVnotInStock
            // 
            this.priceLVnotInStock.Text = "Price";
            this.priceLVnotInStock.Width = 100;
            // 
            // instockLVnotInStock
            // 
            this.instockLVnotInStock.Text = "not in stock";
            this.instockLVnotInStock.Width = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount to Pay";
            // 
            // tbTopay
            // 
            this.tbTopay.Location = new System.Drawing.Point(513, 212);
            this.tbTopay.Name = "tbTopay";
            this.tbTopay.Size = new System.Drawing.Size(100, 20);
            this.tbTopay.TabIndex = 5;
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 366);
            this.Controls.Add(this.tbTopay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LVnotInStock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LVnotif);
            this.Controls.Add(this.label1);
            this.Name = "Notification";
            this.Text = "Notification";
            this.Load += new System.EventHandler(this.Notification_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView LVnotif;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView LVnotInStock;
        private System.Windows.Forms.ColumnHeader titleLVnotif;
        private System.Windows.Forms.ColumnHeader authorLVnotif;
        private System.Windows.Forms.ColumnHeader priceLVnotif;
        private System.Windows.Forms.ColumnHeader NumberLVnotif;
        private System.Windows.Forms.ColumnHeader titleLVnotInStock;
        private System.Windows.Forms.ColumnHeader authorLVnotInStock;
        private System.Windows.Forms.ColumnHeader priceLVnotInStock;
        private System.Windows.Forms.ColumnHeader instockLVnotInStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTopay;
    }
}