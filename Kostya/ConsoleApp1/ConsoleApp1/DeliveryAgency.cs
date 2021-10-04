using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DeliveryAgency
    {
        public string Name { get; set; }
        //Store[] Stores;
        //User[] Users;
        public DeliveryAgency(string name/*, Store[] stores, User[] users*/)
        {
            Name = name;
            //Stores = stores;
           // Users = users;
        }
        void Load()
        {
            Console.WriteLine("Loading books");
        }
        void Transport()
        {
            Console.WriteLine("Transporting books");
        }
        void Unload()
        {
            Console.WriteLine("Unloading books");
        }
        public void Deliver(User user, Book[] books)
        {
            Load();
            Transport();
            Unload();
            user.GetBook(books);
        }
    }
}
