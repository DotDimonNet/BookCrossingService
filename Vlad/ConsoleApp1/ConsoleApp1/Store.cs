using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class Store:IStore
    {
        public void Delivery()
        {
            Console.WriteLine("Delivering");
        }

    }
}
