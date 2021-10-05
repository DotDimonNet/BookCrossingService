using System;
using System.Collections.Generic;
using System.Text;

namespace Day1
{
    class Users
    {
         public string name;
        public string address;
        public string phoneNumber;
        public List<Book> UserBooks  { get; set; }
        public Users(string Name, string Address, string PhoneNumber)
        {
            name = Name;
            address = Address;
            phoneNumber = PhoneNumber;
            UserBooks = new List<Book>();
            // Console.WriteLine("ok");
        }
        public void GetInfo()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Address: {0}", address);
            
        }
       

        public void Follow(Book book) { }
        public void Swap(Book book, Users anotherUser) { }

        public void AddBook(Book book)
        {
            UserBooks.Add(book);

        }        
       public void ShowUserBooks()
        {
            foreach (var item in UserBooks)
            {
                Console.WriteLine(item.Title);
            }
        }

    }
    
}
