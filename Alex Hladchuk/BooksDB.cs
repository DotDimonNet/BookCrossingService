using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class BooksDB
    {
        public int ID { set; get; }
        public Book Book { set; get; }

        public string Print(KeyValuePair<int, Book> line)
        {
            return $"ID: {line.Key} Book: {line.Value.Name} - {line.Value.Author} - {line.Value.Type}";
        }
        public Dictionary<int, Book> DB = new Dictionary<int, Book>();
        public void Add(Book Book)
        {
            int NewID = DB.Count + 1;
            DB.Add(NewID, Book);
        }
        public void ShowDB()
        {
            foreach (KeyValuePair<int,Book> line in DB)
            {
                Console.WriteLine(Print(line));
            }
        }
    }
}
