using BookCrossingService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCrossingService.Objects
{
    public class Book : IBook, IReadable
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PrintedAge { get; set; }
        public string Publisher { get; set; }
        public int PagesTotal { get; set; }
        public string Description { get; set; }
        public BookType Type { get; set; }
        public string Source { get; set; }
        public DateTime LatestRead { get; set; }
        public bool IsFreeNow { get; set; }

        public Book(string title, string author, int printedAge, string publisher, int pagesTotal, string description, BookType type)
        {
            Title = title;
            Author = author;
            PrintedAge = printedAge;
            Publisher = publisher;
            PagesTotal = pagesTotal;
            Description = description;
            Type = type;
        }

        public string GetInfo()
        {
            return @$"  {nameof(Title)}:    {Title}
                        Author:             {Author}
                        Description:        {Description}";
        }

        public void Read(DateTime startDate)
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            throw new NotImplementedException();
        }
    }

    public enum BookType
    {
        File,
        Text
    }
}
