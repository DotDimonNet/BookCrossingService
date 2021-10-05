using System;
using System.Collections.Generic;
using System.Linq;

namespace Day1
{
    class Program
    {
        public enum Flags
        {
            Red = 1,
            Blue = 13
        }
        public interface IDou
        {
            
        }
        class Dou:IDou
        {
            public string Name { get; set; }
           
        }
        public static IEnumerable<string> F1(Dictionary<int, string> dic)
        {
            return dic.Where(x => x.Key % 2 == 1).Select(x => x.Value);
        }
        public static IEnumerable<string> F2(Dictionary<int, string> dic)
        {
            return dic.Where(x => x.Value.Length <= 5).Select(x => x.Value);
        }
        public static IEnumerable<string> F3(Dictionary<int, string> dic)
        {
            return dic.Select(x => $"{x.Key}_{x.Value.Substring(0,3)}" );
        }
        public static IEnumerable<string> F4(Dictionary<int, string> dic)
        {
            return dic.Where(x => (x.Key % 2 == 1)&&(x.Value.Length<=5)).Select(x => $"{x.Key}_{x.Value.Substring(0, 3)}");
        }

        static void Main(string[] args)
        {
            Dictionary<int, string> countries = new Dictionary<int, string>(10);
            countries.Add(1, "Ukraine");
            countries.Add(3, "Great Britain");
            countries.Add(2, "USA");
            countries.Add(4, "France");
            countries.Add(5, "China");
            countries.Add(6, "Russia");
            countries.Add(7, "Great Britain");
            countries.Add(8, "Canada");
            countries.Add(9, "France");
            countries.Add(10, "Japan");
            IEnumerable<string> aa = F4(countries);

            IDou dou = new Dou();

            Console.WriteLine("Hello World!");
            Users first = new Users("Dasha",
                                    "Vinnytsia",
                                    "0680000000");
            first.GetInfo();
            Book myBook = new Book("Mark Twein", " Adventures of Tom Sawyer");
            List<Book> myBooks = new List<Book>
            {
                new Book("Mark Tw", "book1"),
                new Book("Mark Twe", "book2"),
                new Book("Mark", "book3")
            };
            

            first.AddBook(myBook);
           

            foreach (var item in myBooks)
            {
                first.AddBook(item);
            }
            //first.ShowUserBooks();
            var names = from u in first.UserBooks select u.author;

            foreach (string n in names)
                Console.WriteLine(n);

            Console.WriteLine(Flags.Red);
            //Console.WriteLine("My book");
            //Console.WriteLine(first.UserBooks);
            //Console.WriteLine("My new book");
            //first.AddBook(myBook1);
            //Console.WriteLine(first.UserBooks);
            //Console.WriteLine(first.GetInfoString());

            // DAY2

            //Day2 monday = new UpDay2();
            //UpDay2 tuesday = new UpDay2();
            //Console.WriteLine(monday.name);
            //Console.WriteLine(tuesday.name);
            //tuesday.ShowName();

            // + 

            //Dot vim = new Dot(10, 9);
            //Dot bim = new Dot(5, 6);
            //Dot rim = vim + bim;
            //Console.WriteLine($" A:{rim.getA()}, B: {rim.getB()} ");

            // string 


            //string name = "0,5 7,8 4,9 12,45 123.100";
            //string nameUp = name.Replace(",", ".");//0.5 7.8 4.9 12.45 123.100
            //Console.WriteLine(nameUp);
            //string nameUpgrade = nameUp.Replace(" ", ",");
            //Console.WriteLine(nameUpgrade);//0.5,7.8,4.9,12.45,123.100

            //string sentence = "wim";
            //char[] charArr = sentence.ToCharArray();
            //foreach (char ch in charArr)
            //{
            //    Console.WriteLine(ch);
            //}
            //Console.WriteLine("1 char: {0},2 char: {1},3 char: {2}",charArr[0], charArr[1],charArr[2]);
            //Console.WriteLine(first.ToString());//Day1.Users
            //Console.WriteLine(first);//Day1.Users

            //string str = "red, green, blue, yellow, pink, purple";
            //string myString = str.Replace("blue", "light-blue");
            //string[] myColors = myString.Split(',');

            //for (int i = 0; i < myColors.Length; i++)
            //{
            //    Console.WriteLine(myColors[i]);
            //}
            //String str2 = String.Join(' ', myColors);
            //Console.WriteLine(str2);

            //array
            //int[] numbers = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 };

            //IEnumerable<int> evens = from i in numbers
            //                         where i % 2 == 0
            //                         select i;
            //foreach (int i in evens)
            //    Console.WriteLine(i);


        }
    }
}
