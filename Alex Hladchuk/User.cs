using System;


namespace ConsoleApp1
{
    class User
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public object[] Ownership { set; get; }
        public object[] OwnershipHelper { set; get; }

        public void GaveBook(object Book, string BookTravelAgensy)
        {
            for (int i = 0; i < Ownership.Length; i++)
            {
                int numIndex = Array.IndexOf(Ownership, Book);
                Ownership = Ownership.Where()
            }
            OwnershipHelper = Ownership;
            
            Console.WriteLine($"{Name} gave {Book} to the {BookTravelAgensy}");
        }
        public void TookBook(string Book, string BookTravelAgensy)
        {
            Console.WriteLine($"{Name} took {Book} from the {BookTravelAgensy}");
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

    }
}