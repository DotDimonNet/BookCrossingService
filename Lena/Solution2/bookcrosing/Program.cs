using System;

namespace bookcrosing
{
	class Program
	{

		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Book book = new Book("a", "b", "c", "d", 0);
			Console.WriteLine(book.AuthorName);
			Console.ReadKey();
		}
	}
}
