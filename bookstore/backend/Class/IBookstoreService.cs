using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web.Script.Serialization;


namespace bookstore.backend.Class
{
     public class IBookstoreService : backend.IBookstoreService
    {
   
        public async Task<IEnumerable<backend.IBook>> GetBooksAsync(string searchString)
        {     
            Task<string> downloadAsync = DownloadAsync();
            // do stuff man that dont need the books. like move window around.


            // waiting for file to come home.
            string json = await downloadAsync;
            backend.Class.Ibooks books = backend.Class.DecodeJson.decodejason(json);

            // add a search function for tital and author
            return Search(backend.Class.DecodeJson.convert(books), searchString);
             
            //return backend.Class.DecodeJson.convert(books);
        }
        public IEnumerable<backend.Class.IBooksWithInterface> Search(IEnumerable<backend.Class.IBooksWithInterface> books, string search)
        {            
            List<IBooksWithInterface> templist = new List<IBooksWithInterface>();

            foreach (var book in books)
            {
                if (book.Author.Contains(search) || book.Title.Contains(search))
                {
                    templist.Add(book);
                }
            }

            return templist.AsEnumerable();
        }
        /// <summary>
        /// async download of json file I assume its working.. 
        /// </summary>
        /// <returns></returns>
        public async Task<string> DownloadAsync()
        {
            Uri bookstore = new Uri("http://www.contribe.se/arbetsprov-net/books.json");
            try {
                var client = new WebClient();

                string json = await client.DownloadStringTaskAsync(bookstore);
                return json;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("server Down: uri not found");
                return null;
            }
            
        }
    
    }
}
