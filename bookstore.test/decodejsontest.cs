using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using bookstore;

namespace bookstore.test
{
    [TestClass]
    public class decodejsontest
    {
        [TestMethod]

        public async void decodeAsyncTest()
        {
            backend.Class.IBookstoreService s = new backend.Class.IBookstoreService();


            IEnumerable<backend.IBook> result = await s.GetBooksAsync("dude");
            //var first = result.First();
            //bool test = first.Author.Contains("Swede");
            //Assert.IsTrue(test);

            
        }

        [TestMethod]
        public void downloadtest()
        {
            string json = bookstore.backend.Class.DecodeJson.downloadjson();
            bool test = json.Contains("books");
            //assert
            Assert.IsTrue(test);
        }

        [TestMethod]

        public void decodeTest()
        {
            string json = backend.Class.DecodeJson.downloadjson();
            IEnumerable<backend.Class.IBooksWithInterface> books = backend.Class.DecodeJson.decodejason(json);


        }

       
    }
}
