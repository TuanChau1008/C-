using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assi_4
{
    public class Books
    {

        private int bookID;
        private string bookName;
        private float bookPrice;
        private int quantity;

        public Books()
        {
        }

        public Books(int bookID, string bookName, float bookPrice, int quantity)
        {
            this.BookID = bookID;
            this.BookName = bookName;
            this.BookPrice = bookPrice;
            this.Quantity = quantity;
        }

        public int BookID { get => bookID; set => bookID = value; }
        public string BookName { get => bookName; set => bookName = value; }
        public float BookPrice { get => bookPrice; set => bookPrice = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
