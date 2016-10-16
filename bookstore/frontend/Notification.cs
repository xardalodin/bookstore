using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookstore.frontend
{
    public partial class Notification : Form
    {
        public Notification(backend.Class.ShopingCart input)
        {
            InitializeComponent();
            List<ListViewItem> listviewCoulums = new List<ListViewItem>();
            decimal totalcost = 0;
            foreach (var book in input.BooksInCart)
            {
                // check if Coustomer ordered more than where in stock
                int status = backend.Class.ShopingCart.check(book.InStock, book.NumberOfThisBookIncart);              
                if (status != 0)// if its not zero a book was orderd.
                {
                    //totalcost = totalcost + (status * book.Price);
                    totalcost = backend.Class.ShopingCart.TotalCost(totalcost, book.Price, status);
                    ListViewItem temp = new ListViewItem();
                    temp.Text = book.Title;
                    temp.SubItems.Add(book.Author);
                    temp.SubItems.Add(book.Price.ToString());
                    temp.SubItems.Add(status.ToString());
                    listviewCoulums.Add(temp);
                }
            }
            LVnotif.Items.AddRange(listviewCoulums.ToArray());
            tbTopay.Text = totalcost.ToString();

            List<ListViewItem> listviewCoulums2 = new List<ListViewItem>();

            foreach (var book in input.BooksInCart)
            {
                int status =backend.Class.ShopingCart.outofstock(book.InStock, book.NumberOfThisBookIncart);
                if (status != -1)
                {
                    ListViewItem temp2 = new ListViewItem();
                    temp2.Text = book.Title;
                    temp2.SubItems.Add(book.Author);
                    temp2.SubItems.Add(book.Price.ToString());
                    temp2.SubItems.Add(status.ToString());
                    listviewCoulums2.Add(temp2);
                }
            }
            LVnotInStock.Items.AddRange(listviewCoulums2.ToArray());
        }

        /*
        private int outofstock(int instock, int orderd)
        {
            int orderstatus = instock - orderd;
            if (orderstatus < 0)// ordered more than instock
            {
                return orderd - instock; // missing
            }
            else { return -1; } // still left in stock  
        }
        private int check(int instock, int orderd)
        {
            int orderstatus = instock - orderd;
            if (orderstatus < 0)// ordered more than instock
            {
                return instock;
            }
            else
            {
                return orderd;
            }
        }
        */

        private void Notification_Load(object sender, EventArgs e)
        {

        }
    }
}
