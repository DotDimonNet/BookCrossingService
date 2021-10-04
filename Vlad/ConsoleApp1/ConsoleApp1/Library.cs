using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Library:User
    {
        public Library(string name, string adressOfLibrary, string email) :base(name, email)
        {
            AdressOfLibrary = adressOfLibrary;

        }
        public string AdressOfLibrary { get; set; }

    }
}
