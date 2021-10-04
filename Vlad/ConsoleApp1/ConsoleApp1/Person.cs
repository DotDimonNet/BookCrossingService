using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Person : User
    {
       public Person(string name,  int age, string email) : base(name, email)
        {
            Age = age;
        }

        private int _age;

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Value must be >0");
                }
                else
                {
                    _age = value;
                }
            }
        }

        

        public void DisplayAboutPerson()
        {
            Console.WriteLine(Name + ' ' + Age);
        }
    }
}
