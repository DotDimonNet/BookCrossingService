using System;
using System.Linq;

namespace ConsoleApp1
{
    class User
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public int[] Ownership { set; get; }

        public void GaveBook(int BookID, string Book, string BookTravelAgensy)
        {
            if (Ownership.Length != 0)
            {
                Ownership = Ownership.Where(id => id != BookID).ToArray();
                Console.WriteLine($"{Name} gave {Book} to the {BookTravelAgensy}");
            }
            else
            {
                Console.WriteLine("Ownership is empty");
            }
        }

        public void TookBook(int BookID, string Book, string BookTravelAgensy)
        {
            int[] OwnershipHelper = Ownership;
            Array.Resize(ref OwnershipHelper, OwnershipHelper.Length + 1);
            OwnershipHelper[OwnershipHelper.Length - 1] = BookID;
            Console.WriteLine($"{Name} took {Book} from the {BookTravelAgensy}");
        }
        public void TookBook(int BookID, string Book)
        {
            int[] OwnershipHelper = Ownership;
            Console.WriteLine(OwnershipHelper.Length);
            if (OwnershipHelper.Length > 0)
            {
                Array.Resize(ref OwnershipHelper, OwnershipHelper.Length + 1);
                OwnershipHelper[OwnershipHelper.Length - 1] = BookID;
            }
            else
            {
                Ownership = new int[] {BookID};
            }
            Console.WriteLine($"{Name} took {Book}");
        }
    }


    class PersonU : User
    {
        public int Age { set; get; }
        public string Sex { set; get; }
        public PersonU(string name, int age, string adress, string sex)
        {
            //Name
            Name = name;
            //Age
            if (age <= 0)
            {
                Console.Write("Age Error\n");
            }
            else
            {
                Age = age;
            }
            //adress
            Adress = adress;
            //sex
            if (sex != "male" && sex != "female")
            {
                Console.Write("Sex Error\n");
            }
            else
            {
                Sex = sex;
            }
        }

        public void GetInfo()
        {
            Console.Write($"Name: {Name}\n" +
                          $"Age: {Age}\n" +
                          $"Adress: {Adress}\n" +
                          $"Sex: {Sex}\n");
        }
    }
    class LibraryU : User
    {
        public LibraryU(string name, string adress)
        {
            Name = name;
            Adress = adress;
        }
    }
}