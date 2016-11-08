using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.backend.Class
{
    public class IBooksWithInterface : backend.IBook
    {

        public string author;
        public decimal price;
        public string title;
        public int inStock;

        private int numberOfThisBookIncart;
        public string Author { get { return author; } }
        public decimal Price { get { return price; } }
        public string Title { get { return title; } }
        public int InStock { get { return inStock; } }

        public int NumberOfThisBookIncart { get { return numberOfThisBookIncart; } set { numberOfThisBookIncart = value; } }

        public IBooksWithInterface()
        { }
        public IBooksWithInterface(string title, string author, decimal price,int instock)
        {
            this.price = price;
            this.author = author;
            this.title = title;
            this.inStock = instock;
            this.numberOfThisBookIncart = 0;
        }
        public IBooksWithInterface(string title, string author, decimal price, int instock, int inCart)
        {
            this.price = price;
            this.author = author;
            this.title = title;
            this.inStock = instock;
            this.numberOfThisBookIncart = inCart;
        }

        public void addtocart()
        {
            this.numberOfThisBookIncart++;
        }
        public void subFromcart()
        {
            this.numberOfThisBookIncart--;
        }
    }
}
