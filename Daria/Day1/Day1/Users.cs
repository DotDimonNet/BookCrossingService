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
        
        public string UserBooks { get; set; }
        public Users(string Name, string Address, string PhoneNumber)
        {
            name = Name;
            address = Address;
            phoneNumber = PhoneNumber;
            
           // Console.WriteLine("ok");
        }
        public void GetInfo()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Address: {0}", address);
            
        }
        public string GetInfoString()
        {
            return name + ',' + address + ',' + phoneNumber  + '.';
        }

        public void Follow(Book book) { }
        public void Swap(Book book, Users anotherUser) { }

        public void AddBook(Book book)
        {
            UserBooks = UserBooks + book.title;
        }        
       

    }
    
}
