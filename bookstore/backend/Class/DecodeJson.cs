using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

using System.Net;
using System.Windows.Forms;


namespace bookstore.backend.Class
{
    public class DecodeJson
    {

        public static IEnumerable<backend.Class.IBooksWithInterface> decodejason(string json)// for testing async not working in nunit
        {
            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();

            backend.Class.Books  books = new System.Web.Script.Serialization.JavaScriptSerializer().Deserialize<backend.Class.Books>(json);

            return books.books;                 
            // note a list is a enumrable just run command books.books.AsEnumerable();
        }

        public static string downloadjson()// for testing async not working in nunit
        {
            Uri bookstore = new Uri("http://www.contribe.se/arbetsprov-net/books.json");
            var json = new WebClient().DownloadString(bookstore);
            return json;
        }

    }
}