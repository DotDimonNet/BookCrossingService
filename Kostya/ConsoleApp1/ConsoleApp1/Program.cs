using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var FirstBook = new Book("C# tutorial", "Educational", "Troelsen", 500, "Physical");
            var SecondBook = new Book("C# for beginers", "Educational", "Mike McGrath", 300, "Physical");
            var books = new Book[] { FirstBook, SecondBook};
            var FirstAgency = new DeliveryAgency("Hot delivery");
            var MyStore = new Store("World of books", books, FirstAgency);
            var FirstUser = new User("Kostya", 22, null);

            //MyStore.SendBooks(books, FirstUser);

            Console.ReadLine();
        }
    }
}
