using System;


namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Users first = new Users("Dasha",
                                    "Vinnytsia",
                                    "0680000000");
            first.GetInfo();
            Book myBook = new Book("Mark Twein", " Adventures of Tom Sawyer");
            Book myBook1 = new Book("Mark Twein", " book2");
            first.AddBook(myBook);

            Console.WriteLine("My book");
            Console.WriteLine(first.UserBooks);
            Console.WriteLine("My new book");
            first.AddBook(myBook1);
            Console.WriteLine(first.UserBooks);
            //Console.WriteLine(first.GetInfoString());
        }
    }
}
