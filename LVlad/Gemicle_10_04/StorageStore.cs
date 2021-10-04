using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemicle_10_04
{
    class StorageStore:Store
    {
        public string StoreLocation { get; set; }

        public override void Delivery()
        {
            Console.WriteLine("Delivery from storage store " + StoreName);
        }
        public override string ToString()
        {
            return "Name: " + StoreName + "\nLocation: " + StoreLocation;
        }
        public StorageStore(string name, string location)
        {
            StoreName = name;
            StoreLocation = location;
        }
    }
}
