using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonU tom = new PersonU("Tom", 19, "Pushkina 2", "male");
            PersonU jerry = new PersonU("Jerry", 10, "Soborna 18", "female");
            Book misterMercedes = new Book("Mister Mercedes", "Stiven King", "text");
            Book light = new Book("Light", "Stiven King", "file");

            void Border()
            {
                Console.WriteLine("==================================================");
            }

            Border();
            tom.GetInfo();
            Border();
            jerry.GetInfo();
            Border();
            misterMercedes.GetInfo();
            Border();
            light.GetInfo();
            Border();



            LibraryU vinnitsaLib = new LibraryU();

        }
    }
}

