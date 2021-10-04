using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class Book
    {
     
        public Book(string name, string genre, string author)
        {
            NameOfBook = name;
            GenreOfBook = genre;
            AuthorOfBook = author;
        }


        public string NameOfBook { get; set; }
        public string GenreOfBook { get; set; }

        public string AuthorOfBook { get; set; }

    }
}
