using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Book

    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public string Type { get; set;}

        public Book(string name, string genre, string author, int pages, string type)
        {
            Name = name;
            Genre = genre;
            Author = author;
            Pages = pages;
            Type = type;
        }
    }
}
