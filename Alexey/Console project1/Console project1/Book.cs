using System;
using System.Collections.Generic;
using System.Text;

namespace Console_project1
{
    class Book
    {
        public string AuthorName;

        public string BookTitle;

        public int Year;

        public void GetInfo()
        {
            Console.WriteLine($"Imya avtora: (AuthorName) Nazvaniye knigi: (BookTitle) God: (Year)");
        }
    }
}

