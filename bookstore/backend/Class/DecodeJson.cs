using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Net;

namespace bookstore.backend.Class
{
    public class DecodeJson
    {


        public static Ibooks decodejason(string json)// for testing async not working in nunit
        {
            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            Ibooks books = new System.Web.Script.Serialization.JavaScriptSerializer().Deserialize<backend.Class.Ibooks>(json);
            return books;

            // note a list is a enumrable just run command books.books.AsEnumerable();
        }

        public static string downloadjson()// for testing async not working in nunit
        {
            Uri bookstore = new Uri("http://www.contribe.se/arbetsprov-net/books.json");
            var json = new WebClient().DownloadString(bookstore);
            return json;
        }
       
        public static IEnumerable<backend.Class.IBooksWithInterface> convert(Ibooks book)
        {// quick convertion fix .. there is probably a faster one...
            IEnumerable<backend.Class.IBooksWithInterface> result;

            List<IBooksWithInterface> templist = new List<IBooksWithInterface>();
           
            foreach (var bok in book.books)// aa public to private variables... load ones.. 
            {
                templist.Add(new IBooksWithInterface(bok.title, bok.author, bok.price, bok.inStock));
            }
            result = templist.AsEnumerable();
            return result;
        }
    }
}