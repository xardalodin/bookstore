using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// only used to move to notifications form,, could probably be removed
namespace bookstore.backend.Class
{
    public class ShopingCart
    {
        private List<backend.Class.IBooksWithInterface> booksInCart;
        private decimal totalCostOFBooksInCart;

        public List<backend.Class.IBooksWithInterface> BooksInCart
        {
            get { return booksInCart; }
            set { booksInCart = BooksInCart;}
        }
        public decimal TotalCostOFBooksInCart { get { return totalCostOFBooksInCart; } }

        public ShopingCart(List<backend.Class.IBooksWithInterface> booksInCart)
        {
            this.booksInCart = booksInCart;

        }
        public ShopingCart(List<backend.Class.IBooksWithInterface> booksInCart,decimal total)
        {
            this.booksInCart = booksInCart;
            this.totalCostOFBooksInCart = total;
        }
        public void TotalCost()
        {
            decimal totalcost = 0;
            foreach (var book in booksInCart)
            {
                totalcost += book.Price * book.NumberOfThisBookIncart;
            }

            totalCostOFBooksInCart = totalcost;
        }

    }
}
