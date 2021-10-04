using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemicle_10_04
{
    class Store
    {
        public Book[] Books { get; set; }
        public BookTransferAgency BookTransferAgency { get; set; }
        public string StoreName { get; set; }

        public Store()
        {

        }
        public Store(string storeName)
        {
           StoreName = storeName;
        }
        public Store(string storeName, Book[] books, BookTransferAgency bookTransferAgency)
        {
            StoreName = storeName;
            Books = books;
            BookTransferAgency = bookTransferAgency;
        }
        void Sell(Book[] books, User user)
        {

        }

        public virtual void Delivery()
        {
            Console.WriteLine("Delivery from store " + StoreName);
        }

        public override string ToString()
        {
            return "Name: " + StoreName;
        }
    }
}
