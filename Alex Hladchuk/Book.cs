using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Book
    {
        private string name;
        private string author;
        private string type;

        public string Name { set; get; }
        public string Author { set; get; }
        public string Type { set; get; }

        public Book(string name, string author, string type)
        {
            //Name
            Name = name;
            //Author
            Author = author;
            //Type
            if (type != "text" && type != "file")
            {
                Console.WriteLine("Book's type Error\n");
            }
            else
            {
                Type = type;
            }
        }
        public void GetInfo()
        {
            Console.WriteLine($"Name: {Name}\n" +
                $"Author: {Author}\n" +
                $"Type: {Type}");
        }
    }
}
