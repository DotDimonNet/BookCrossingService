using System;

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
            mainDB.Add(misterMercedes);
            mainDB.Add(light);

            void Border()
            {
                Console.WriteLine("==================================================");
            }

            void UserGaveBook(PersonU user, int bookID)
            {
                Book Book = mainDB.DB[bookID];
                user.GaveBook(Book, "Agensy");
            }
            void UserTookBook(PersonU user, int bookID)
            {
                Book Book = mainDB.DB[bookID];
                user.TookBook(Book);
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
            vinnitsaLib.GetInfo();
            Border();
            mainDB.ShowDB();
            Border();

            UserTookBook(tom, 1);
            Border();
            tom.GetOwnership();
            



        }
    }
}

