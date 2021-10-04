using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class PhysicBook:Book

    {
        public PhysicBook(string name, string genre, string author, string publishingHouse, int ageOfPublish, string language):base(name, genre, author)
        {
            PublishingHouse = publishingHouse;
            AgeOfPublishing = ageOfPublish;
            Language = language;
        }
        public string PublishingHouse { get; set; }
        public int AgeOfPublishing { get; set; }
        public string Language { get; set; }
    }
}
