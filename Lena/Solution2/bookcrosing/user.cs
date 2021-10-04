using System;
using System.Collections.Generic;
using System.Text;

namespace bookcrosing
{
	class User
	{
		public string Name { get; set; }
		public int Age;
		public void GetInfo()
		{
			Console.WriteLine($"Name: {Name} Age: {Age}");
		}

		public User()
		{
			Console.WriteLine();
		}
		public User(string name, int age)
		{
			Name = name;
			Age = age;
		}


		public void Do()
		{
			User user1 = new User();
			User user2 = new User("", 12);
		}

	}
}
