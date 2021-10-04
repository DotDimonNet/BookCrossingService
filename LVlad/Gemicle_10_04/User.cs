using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemicle_10_04
{
    class User:Person
    {
        public List<Book> Books { get; set; }
        public BookTransferAgency[] BookAgencies;

        public void BuyBook(Book book)
        {
            Books.Add(book);
            Console.WriteLine("Book " + book.BookName + "bought.");
        }
        
    }
}
