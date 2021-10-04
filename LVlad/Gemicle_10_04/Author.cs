using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemicle_10_04
{
    class Author
    {
        public List<Book> WritedBooks { get; set; }

        public void WriteBook()
        {
            WritedBooks.Add(Book.CreateBook(this));
        }
    }
}
