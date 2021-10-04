using System;
using System.Collections.Generic;
using System.Text;

namespace bookcrosing
{
	class Book
	{
		public string Name;
		public string AuthorName;
		public string Language;
		public string Genre;
		public bool IsStorring = true;
		public bool Empty = false;
		public int NumberList;
		public void GetInfo()
		{
			Console.WriteLine($"Book's name: {Name} Author: {AuthorName} Book's language:{Language} Genre {Genre} ");

		}

		public Book(string name, string authorName, string language, string genre, int numberList)
		{
			Name = name;
			AuthorName = authorName;
			Language = language;
			Genre = genre;
			NumberList = numberList;
		}
	}
}
