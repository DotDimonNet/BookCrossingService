using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Store
    {
        public string Name { get; set; }
        IEnumerable<Book> Books { get; set; }
        DeliveryAgency DeliveryAgency { get; set; }
        public Store(string name, Book[] books, DeliveryAgency deliveryAgency)
        {
            Name = name;
            Books = books;
            DeliveryAgency = deliveryAgency;
        }
        void GetBook(Book book)
        {
            Console.WriteLine("Книга отримана");
        }
        public void SendBooks(string[] bookNames, User user)
        {
            Console.WriteLine("Books prepeared for sending by Agency '" + DeliveryAgency.Name + "'");
            //DeliveryAgency.Deliver(user, bookNames);
        }
        public void sendBook(string bookName)
        {
            Books = Books.Where(x => x.Name != bookName);
        }
    }
}
