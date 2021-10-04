using System;
using System.Collections.Generic;
using System.Text;

namespace Console_project1
{
    class User
    {
        public string nameUser;
        public int ageUser;

        public void GetInfo()
        {
            Console.WriteLine($"Имя: (nameUser) Возраст: (ageUser)");
        }

    }
