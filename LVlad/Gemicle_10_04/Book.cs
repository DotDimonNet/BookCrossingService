using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemicle_10_04
{
    class Book
    {
        public User User { get; set; }
        public string BookName { get; set; }
        public int PublicationYear { get; set; }
        public int PageQuantity { get; set; }
        public double Price { get; set; }
        public Author BookAuthor { get; set; }

        public Book()
        {

        }
        public Book( User user, string name, int pubYear, double price, Author author )
        {
            User = user;
            BookName = name;
            PublicationYear = pubYear;
            Price = price;
            BookAuthor = author;
        }
        public Book(string name, int pubYear, double price, Author author)
        {
            BookName = name;
            PublicationYear = pubYear;
            Price = price;
            BookAuthor = author;
        }

        public static Book CreateBook(Author author)
        {
            Book book = new Book();
            Console.WriteLine("Input book name:");
            book.BookName = Console.ReadLine();
            Console.WriteLine("Input book year of publication:");
            book.PublicationYear = Program.InputInt();
            Console.WriteLine("Input book page quantity:");
            book.PageQuantity = Program.InputInt();
            Console.WriteLine("Input book price:");
            book.Price = Program.InputDouble();
            
            book.BookAuthor = author;
            return book;
        }
    }
}
