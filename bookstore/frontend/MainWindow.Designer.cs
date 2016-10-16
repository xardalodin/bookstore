namespace bookstore.frontend
{
    partial class MainWindow
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
            this.LVSeach = new System.Windows.Forms.ListView();
            this.titleListviewSearch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.authorListViewSearch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceListViewSearch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InStockListviewSearch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tBSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddtoCart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.LVCART = new System.Windows.Forms.ListView();
            this.titleLVCart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.authorLVCart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceLVCart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inStockLVCart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InCartLVcart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBuy = new System.Windows.Forms.Button();
            this.tbTotalCost = new System.Windows.Forms.TextBox();
            this.LabelTotalCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LVSeach
            // 
            this.LVSeach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.titleListviewSearch,
            this.authorListViewSearch,
            this.priceListViewSearch,
            this.InStockListviewSearch});
            this.LVSeach.FullRowSelect = true;
            this.LVSeach.GridLines = true;
            this.LVSeach.Location = new System.Drawing.Point(12, 63);
            this.LVSeach.MultiSelect = false;
            this.LVSeach.Name = "LVSeach";
            this.LVSeach.Size = new System.Drawing.Size(426, 253);
            this.LVSeach.TabIndex = 0;
            this.LVSeach.UseCompatibleStateImageBehavior = false;
            this.LVSeach.View = System.Windows.Forms.View.Details;
            // 
            // titleListviewSearch
            // 
            this.titleListviewSearch.Text = "Title";
            this.titleListviewSearch.Width = 134;
            // 
            // authorListViewSearch
            // 
            this.authorListViewSearch.Text = "Author";
            this.authorListViewSearch.Width = 133;
            // 
            // priceListViewSearch
            // 
            this.priceListViewSearch.Text = "Price";
            this.priceListViewSearch.Width = 76;
            // 
            // InStockListviewSearch
            // 
            this.InStockListviewSearch.Text = "InStock";
            this.InStockListviewSearch.Width = 72;
            // 
            // tBSearch
            // 
            this.tBSearch.Location = new System.Drawing.Point(13, 24);
            this.tBSearch.Name = "tBSearch";
            this.tBSearch.Size = new System.Drawing.Size(306, 20);
            this.tBSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(325, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddtoCart
            // 
            this.btnAddtoCart.Location = new System.Drawing.Point(457, 63);
            this.btnAddtoCart.Name = "btnAddtoCart";
            this.btnAddtoCart.Size = new System.Drawing.Size(93, 23);
            this.btnAddtoCart.TabIndex = 3;
            this.btnAddtoCart.Text = "Add to Cart";
            this.btnAddtoCart.UseVisualStyleBackColor = true;
            this.btnAddtoCart.Click += new System.EventHandler(this.btnAddtoCart_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(457, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Delete from Cart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LVCART
            // 
            this.LVCART.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.titleLVCart,
            this.authorLVCart,
            this.priceLVCart,
            this.inStockLVCart,
            this.InCartLVcart});
            this.LVCART.FullRowSelect = true;
            this.LVCART.GridLines = true;
            this.LVCART.Location = new System.Drawing.Point(569, 21);
            this.LVCART.MultiSelect = false;
            this.LVCART.Name = "LVCART";
            this.LVCART.Size = new System.Drawing.Size(538, 234);
            this.LVCART.TabIndex = 5;
            this.LVCART.UseCompatibleStateImageBehavior = false;
            this.LVCART.View = System.Windows.Forms.View.Details;
            this.LVCART.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // titleLVCart
            // 
            this.titleLVCart.Text = "Title";
            this.titleLVCart.Width = 100;
            // 
            // authorLVCart
            // 
            this.authorLVCart.Text = "Author";
            this.authorLVCart.Width = 100;
            // 
            // priceLVCart
            // 
            this.priceLVCart.Text = "Price";
            this.priceLVCart.Width = 70;
            // 
            // inStockLVCart
            // 
            this.inStockLVCart.Text = "InStock";
            // 
            // InCartLVcart
            // 
            this.InCartLVcart.Text = "InCart";
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(457, 143);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(93, 23);
            this.btnBuy.TabIndex = 6;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // tbTotalCost
            // 
            this.tbTotalCost.Location = new System.Drawing.Point(1007, 286);
            this.tbTotalCost.Name = "tbTotalCost";
            this.tbTotalCost.Size = new System.Drawing.Size(100, 20);
            this.tbTotalCost.TabIndex = 8;
            // 
            // LabelTotalCost
            // 
            this.LabelTotalCost.AutoSize = true;
            this.LabelTotalCost.Location = new System.Drawing.Point(946, 293);
            this.LabelTotalCost.Name = "LabelTotalCost";
            this.LabelTotalCost.Size = new System.Drawing.Size(55, 13);
            this.LabelTotalCost.TabIndex = 9;
            this.LabelTotalCost.Text = "Total Cost";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 328);
            this.Controls.Add(this.LabelTotalCost);
            this.Controls.Add(this.tbTotalCost);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.LVCART);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddtoCart);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tBSearch);
            this.Controls.Add(this.LVSeach);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LVSeach;
        private System.Windows.Forms.TextBox tBSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddtoCart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView LVCART;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.TextBox tbTotalCost;
        private System.Windows.Forms.Label LabelTotalCost;
        private System.Windows.Forms.ColumnHeader titleListviewSearch;
        private System.Windows.Forms.ColumnHeader authorListViewSearch;
        private System.Windows.Forms.ColumnHeader priceListViewSearch;
        private System.Windows.Forms.ColumnHeader InStockListviewSearch;
        private System.Windows.Forms.ColumnHeader titleLVCart;
        private System.Windows.Forms.ColumnHeader authorLVCart;
        private System.Windows.Forms.ColumnHeader priceLVCart;
        private System.Windows.Forms.ColumnHeader inStockLVCart;
        private System.Windows.Forms.ColumnHeader InCartLVcart;
    }
}