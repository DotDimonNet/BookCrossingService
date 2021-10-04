using System;
using System.Collections.Generic;
using System.Text;

namespace firstDay
{
    class TransferCenter
    {
        int id { get; set; }
        String address { get; set; }
        String number { get; set; }
        TransferCenter(int id, String address, String number) 
        {
            this.id = id;
            this.address = address;
            this.number = number;
        }
        public static void deliver(List<Book> books) 
        {
            Console.WriteLine("Car transfer");
            Console.WriteLine("Loading books");
            Console.WriteLine("Sending");
        }
    }
}
