using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class BooksDB
    {
        public string ID { set; get; }
        public object Book { set; get; }

        public override string ToString()
        {
            return $"ID: {ID} Object: {Book}";
        }
        public Dictionary<int, string> DB = new Dictionary<int, string>();
        public void Add(string Book)
        {
            int NewID = DB.Count + 1;
            DB.Add(NewID, Book);
        }
        public void ShowDB()
        {
            foreach (var line in DB)
            {
                Console.WriteLine(line.ToString());
            }
        }
    }
}
