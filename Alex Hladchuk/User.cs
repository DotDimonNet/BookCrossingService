﻿using System;
using System.Linq;

namespace ConsoleApp1
{
    class User
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public object[] Ownership { set; get; }

        public void GaveBook(Book Book, string BookTravelAgensy)
        {
            if (Ownership.Length != 0)
            {
                int Len = Ownership.Length;
                Ownership = Ownership.Where(book => book != Book).ToArray();
                if (Len == Ownership.Length)
                {
                    Console.WriteLine("User doesn't have this book");
                    return;
                }
                Console.WriteLine($"{Name} gave {Book.Name} - {Book.Author} to the {BookTravelAgensy}");
            }
            else
            {
                Console.WriteLine("Ownership is empty");
            }
        }

        public void TookBook(Book Book, string BookTravelAgensy)
        {
            object[] OwnershipHelper = Ownership;
            if (OwnershipHelper != null)
            {
                Array.Resize(ref OwnershipHelper, OwnershipHelper.Length + 1);
                OwnershipHelper[OwnershipHelper.Length - 1] = Book;
            }
            else
            {
                Ownership = new object[] { Book };
            }
            Console.WriteLine($"{Name} took {Book.Name} - {Book.Author} from the {BookTravelAgensy}");
        }
        public void TookBook(Book Book)
        {
            object[] OwnershipHelper = Ownership;
            if (OwnershipHelper != null)
            {
                Array.Resize(ref OwnershipHelper, OwnershipHelper.Length + 1);
                OwnershipHelper[OwnershipHelper.Length - 1] = Book;
            }
            else
            {
                Ownership = new object[] { Book };
            }
            Console.WriteLine($"{Name} took {Book.Name} - {Book.Author}");
        }
        public void GetOwnership()
        {
            if (Ownership != null)
            {
                foreach (Book book in Ownership)
                {
                    Console.WriteLine($"{book.Name} - {book.Author}");
                }
            }
        }
    }


    
    
}