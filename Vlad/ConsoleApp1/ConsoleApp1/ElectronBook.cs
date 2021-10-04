using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ElectronBook:Book
    {
        public ElectronBook(string name, string genre, string author, string language, string formatOfFile, string sizeOfFile):base(name, genre, author)
        {
            Language = language;
            FormatOfFile = formatOfFile;
            SizeOfFile = sizeOfFile;
        }
        public string Language { get; set; }
        public string FormatOfFile { get; set; }
        public string SizeOfFile { get; set; }

    }
}
