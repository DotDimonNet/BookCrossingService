using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemicle_10_04
{
    class WebStore:Store
    {
        public string StoreLink { get; set; }

        public override void Delivery()
        {
            Console.WriteLine("Delivery from website " + StoreLink);
        }
        public WebStore()
        {
           
        }
        public WebStore(string name, string link)
        {
            StoreName = name;
            StoreLink = link;
        }
        public override string ToString()
        {
            return "Name: " + StoreName +"\nLink: " + StoreLink;
        }
    }
}
