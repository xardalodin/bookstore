using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookstore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //string json = backend.Class.DecodeJson.downloadjson();

            //backend.Class.Ibooks books = backend.Class.DecodeJson.decodejason(json);

            backend.Class.IBookstoreService s = new backend.Class.IBookstoreService();
            IEnumerable<backend.IBook> result = await s.GetBooksAsync("test");
            foreach (var book in result)
            {
                textBox1.Text += String.Format("{0} \n\n",book.Author);
            }

        }
    }
}
