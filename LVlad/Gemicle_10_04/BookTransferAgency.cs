using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemicle_10_04
{
    class BookTransferAgency
    {
        public Store[] Stores { get; set; }
        public User[] Users { get; set; }
        public string AgencyName { get; set; }

        public void PrintStoresList(object[] obj)
        {
            int i = 1;
            foreach(var st in Stores)
            {
                Console.WriteLine(i + ": " + st);
                i++;
            }
        }
        

    }
}
