using bookstore.backend.Class;
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
    public partial class MainWindow : Form
    {
        private decimal totalcost = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            // null test on input 
            if (tBSearch.Text != null)
            {
                backend.Class.IBookstoreService s = new backend.Class.IBookstoreService();
                IEnumerable<backend.IBook> result = await s.GetBooksAsync(tBSearch.Text);
                PopulateSearchListView(result);
                // search engine in backend , Titel and Author. 
                // null test on input 
                // search for title then Author and add everything to a list , send back to list view


                // populate the listview with search result.

            }
        }

        private void PopulateSearchListView(IEnumerable<backend.IBook> books)
        {
            // maybe just use arraylist but naaa
            List<ListViewItem> listviewCoulums = new List<ListViewItem>();

            foreach (var book in books)
            {
                ListViewItem temp = new ListViewItem();
                temp.Text = book.Title;
                temp.SubItems.Add(book.Author);
                temp.SubItems.Add(book.Price.ToString());
                temp.SubItems.Add(book.InStock.ToString());
                listviewCoulums.Add(temp);
            }
            LVSeach.Items.Clear();
            LVSeach.Items.AddRange(listviewCoulums.ToArray());
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            moveSelectedToCart();
            //backend.Class.IBookstoreService s = new backend.Class.IBookstoreService();
            //IEnumerable<backend.Class.IBooksWithInterface> result = await s.GetBooksAsync(tBSearch.Text);
            //PopulateInCartListView(result);
        }

        private void moveSelectedToCart()
        {
            

            // nothing selected, just return
            if (LVSeach.SelectedItems.Count == 0) return;

            List<IBooksWithInterface> templist = new List<IBooksWithInterface>();
            string title = LVSeach.SelectedItems[0].SubItems[0].Text;
            string author = LVSeach.SelectedItems[0].SubItems[1].Text;
            decimal price = decimal.Parse(LVSeach.SelectedItems[0].SubItems[2].Text); 
            int instock = int.Parse(LVSeach.SelectedItems[0].SubItems[3].Text);
            //download whats inside the cart
            
            templist = getLVcart();
            LVCART.Items.Clear(); // now clear it 
            // check if title already exists title && author same.
            bool exists = false;
            foreach (var list in templist)
            {
                if (list.Author.Contains(author) && list.Title.Contains(title))
                {  // ok it exists in list this specifik one, so add one
                    list.addtocart();
                    totalcost = totalcost + list.Price;
                    exists = true;
                    break; // only one so break
                }
            }
            // if it did not exists
            if (!exists)
            {
                IBooksWithInterface temp = new IBooksWithInterface(title, author, price, instock);
                temp.addtocart();
                totalcost = totalcost + price;
                templist.Add(temp);
            }
                PopulateInCartListView(templist.AsEnumerable());
                tbTotalCost.Text = totalcost.ToString();

        }

        private List<IBooksWithInterface> getLVcart()
        {
            List<IBooksWithInterface> templist = new List<IBooksWithInterface>();
            
            int i = 0; // when things just dont work
            foreach (var row in LVCART.Items)
            {
             string title = LVCART.Items[i].SubItems[0].Text;
             string author = LVCART.Items[i].SubItems[1].Text;
             decimal price = decimal.Parse(LVCART.Items[i].SubItems[2].Text);
             int instock =  int.Parse(LVCART.Items[i].SubItems[3].Text);
             int incart = int.Parse(LVCART.Items[i].SubItems[4].Text);
             IBooksWithInterface temp = new IBooksWithInterface(title, author, price, instock,incart);
             templist.Add(temp);
             
                i++;
            }
            
            return templist;
        }
        private void PopulateInCartListView(IEnumerable<backend.IBook> books)
        {   // yes brain its simular code, could break out but not refactoring at the moment...

            List<ListViewItem> listviewCoulums = new List<ListViewItem>();

            foreach (var book in books)
            {
                ListViewItem temp = new ListViewItem();
                temp.Text = book.Title;
                temp.SubItems.Add(book.Author);
                temp.SubItems.Add(book.Price.ToString());
                temp.SubItems.Add(book.InStock.ToString());
                temp.SubItems.Add(book.NumberOfThisBookIncart.ToString());
                listviewCoulums.Add(temp);
            }
           // LVCART.Items.Clear();
            LVCART.Items.AddRange(listviewCoulums.ToArray());
        }
        private decimal multi(decimal first, int second)
        {
            return first * second;
        }

        private void button1_Click(object sender, EventArgs e)
        {  
            if (LVCART.SelectedItems.Count == 0) return;

            List<IBooksWithInterface> templist = new List<IBooksWithInterface>();
            string title = LVCART.SelectedItems[0].SubItems[0].Text;
            string author = LVCART.SelectedItems[0].SubItems[1].Text;
            //download cart 
            templist = getLVcart();
            int i = 0;
            foreach (var list in templist)
            {
                if (list.Author.Contains(author) && list.Title.Contains(title))
                {   // if more than one book subtrackt one    
                    if (list.NumberOfThisBookIncart > 1)
                    {
                        list.subFromcart();
                        totalcost = totalcost - list.Price;
                        break;
                    }
                    else
                    {
                        list.subFromcart();
                        totalcost = totalcost - list.Price;
                        templist.RemoveAt(i);
                        break;
                    }
                    
                }
                i++; // increment;
               
            }
            LVCART.Items.Clear();
            PopulateInCartListView(templist.AsEnumerable());
            tbTotalCost.Text = totalcost.ToString();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            List<IBooksWithInterface> templist = new List<IBooksWithInterface>();
            templist = getLVcart();
            ShopingCart buying = new ShopingCart(templist,totalcost);
            Notification form2 = new Notification(buying);
            form2.Show();
        }
    }
}
