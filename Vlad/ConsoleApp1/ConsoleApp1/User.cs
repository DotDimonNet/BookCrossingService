using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    abstract class User
    {
        

        public User(string name, string email)
        {
            Name = name;
            Email = email;
           
        }
        public string Name { get; set; } 
        public string Email { get; set; }


        
        public void AddBook()
        {
            using (FileStream fs = new FileStream("book.json", FileMode.OpenOrCreate))
            {
               
            }     
        }

       

    }

       
}   
    

