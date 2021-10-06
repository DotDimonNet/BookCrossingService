using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            BooksDB mainDB = new BooksDB();

            LibraryU vinnitsaLib = new LibraryU("City Main Library", "Yangelya 14");
            PersonU tom = new PersonU("Tom", 19, "Pushkina 2", "male");
            PersonU jerry = new PersonU("Jerry", 10, "Soborna 18", "female");
            Book misterMercedes = new Book("Mister Mercedes", "Stiven King", "text");
            Book light = new Book("Light", "Stiven King", "file");
            mainDB.Add(misterMercedes.Name+" - "+misterMercedes.Author+" - "+misterMercedes.Type);
            mainDB.Add(light.Name+" - "+light.Author+" - "+light.Type);

            void Border()
            {
                Console.WriteLine("==================================================");
            }

            void UserGaveBook(PersonU user, int bookID)
            {
                bool isBook = false;
                foreach (var ID in user.Ownership)
                {
                    if (ID == bookID)
                    {
                        string Book = mainDB.DB[bookID];
                        user.GaveBook(bookID, Book,"Agensy");
                        isBook = true;
                        break;
                    }
                }
                if (isBook == false)
                {
                    Console.WriteLine("User doesn't have this book");
                }
            }
            void UserTookBook(PersonU user, int bookID)
            {
                string Book = mainDB.DB[bookID];
                user.TookBook(bookID, Book);
            }

            // CONTROL

            Border();
            tom.GetInfo();
            Border();
            jerry.GetInfo();
            Border();
            misterMercedes.GetInfo();
            Border();
            light.GetInfo();
            Border();
            mainDB.ShowDB();
            Border();


            UserTookBook(tom, 1);
            Border();
            tom.GetInfo();
            



        }
    }
}

