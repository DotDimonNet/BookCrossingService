using System;

namespace ConsoleApp1
{
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
}
