using System;

namespace firstDay
{
    class Program
    {
        static void Main(string[] args)
        {
            //how it works?
            //1. user (Nata) found an interesting book
            //2. user requested this book
            //3. another user (George) got a request
            //4. another user can approve or cancel this request (if he finds some books of Nata interesting, then he approves, in other case cancels)
            //5. one more confirmation of Nata is needed that she is ready for suggested exchange (not implemented yet) or we can postpone
            // every delivery for 2 days, so that Nata has time to cancel delivery (such desicios in easier for implementation)
            // needs to be connected to the database.... 

            //Console.WriteLine("Hello World!");
            var b1 = new Book(Book.type.Printed, 225, "Dan Brown", "Lost symbol", 2016,2006);
            var b2 = new Book(Book.type.Printed, 300, "Dan Brown", "Da Vinci code", 2011, 2001);
            var l1 = new Library("AHB", "Ukraine, Vinnytsia,Chechova, 145"); //2
            var l2 = new Library("HBB", "Ukraine,CHERNIGIV,Kotlyarevskogo, 145"); //3
            var u1 = new Person("Alex", "Mitchel", "Ukraine, Kyiv, Shevchenka,16"); //0
            var u2 = new Person("Lara", "Koul", "Ukraine, Herson, Gryshevskogo,16"); //1
            u1.addBook(b1);
            u2.addBook(b2);
            u1.requestAnotherUser(1, u2.booksOfUser);
            u2.approveAnotherUser(0,u1.booksOfUser);
            l1.requestAnotherUser(0, u1.booksOfUser);
            u1.approveAnotherUser(2, l1.booksOfUser);
            Console.WriteLine(b1);

        }
    }
}
