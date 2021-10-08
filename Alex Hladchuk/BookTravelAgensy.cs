using System;
using System.Linq;

namespace ConsoleApp1
{
    class BookTravelAgency
    {
        public string Name { set; get; }
        public Book[] TransferOwnership { set; get; }

        public BookTravelAgency(string name)
        {
            Name = name;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Name: {Name}");
        }

        public void GaveBook(Book Book, string User)
        {
            if (TransferOwnership.Length != 0)
            {
                int Len = TransferOwnership.Length;
                TransferOwnership = TransferOwnership.Where(book => book != Book).ToArray();
                if (Len == TransferOwnership.Length)
                {
                    Console.WriteLine("User doesn't have this book");
                    return;
                }
                Console.WriteLine($"{Name} gave {Book.Name} - {Book.Author} to the {User}");
            }
            else
            {
                Console.WriteLine("Ownership is empty");
            }
        }
        public void TookBook(Book Book, string User)
        {
            Book[] OwnershipHelper = TransferOwnership;
            if (OwnershipHelper != null)
            {
                Array.Resize(ref OwnershipHelper, OwnershipHelper.Length + 1);
                OwnershipHelper[OwnershipHelper.Length - 1] = Book;
            }
            else
            {
                TransferOwnership = new Book[] { Book };
            }
            Console.WriteLine($"{Name} took {Book.Name} - {Book.Author} from the {User}");
        }
    }
}
