using BookCrossingService.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCrossingService.Interfaces
{
    public interface IBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PrintedAge { get; set; }
        public string Publisher { get; set; }
        public int PagesTotal { get; set; }
        public string Description { get; set; }
        public BookType Type { get; set; }
        string GetInfo();
    }
}
