using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemicle_10_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hwllo world!");
            Store store1 = new WebStore { StoreName = "Kobzar", StoreLink = "http//kobzar.com" };
            store1.Delivery();

            Console.ReadLine();
        }
        public static int InputInt()
        {
            int num;
            while(true)
            {
                if (Int32.TryParse(Console.ReadLine(), out num))
                    return num;
                else
                    Console.WriteLine("Value must be integer!");
            }
        }

        public static double InputDouble()
        {
            double num;
            while (true)
            {
                if (Double.TryParse(Console.ReadLine(), out num))
                    return num;
                else
                    Console.WriteLine("Value must be double!");
            }
        }
    }
}
