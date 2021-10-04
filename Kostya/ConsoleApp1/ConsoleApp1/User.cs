using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public IEnumerable<Book> Books { get; set; }
        public User(string name, int age, Book[] books)
        {
            Name = name;
            Age = age;
            foreach (var book in books)
            {
                Books.Append(book);
            }
        }
        public void GetBook(Book[] books)
        {
            foreach (var book in books)
            {
                Console.WriteLine(Name + " gain book '" + book.Name + "'");
                Books.Append(book);
            }
        }
        public void SendBookToUser(string[] bookNames, User user)
        {
            IEnumerable<Book> booksToSend;
            foreach (var bookName in bookNames)
            {
                var book = Books.Where(x => x.Name == bookName);
                //booksToSend.Append(book);
                Books = Books.Where(x => x.Name != bookName);
            }
            
        }
    }
}
