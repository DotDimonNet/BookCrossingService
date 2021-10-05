using System;

namespace ConsoleApp1
{
    class LibraryU : User
    {
        public LibraryU(string name, string adress)
        {
            Name = name;
            Adress = adress;
        }
        public void GetInfo()
        {
            Console.Write($"Library: {Name}\n" +
                          $"Adress: {Adress}\n");
        }
    }
}
