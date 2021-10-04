using System;


namespace ConsoleApp1
{
    class Book
    {
        private string autor = "Konan Doil";
        private string name = "Sherlock Holms";
        public Book()
        {
        }
        public Book(string autor, string name)
        {
            this.autor = autor;
            this.name = name;
        }
        public string ConcretBook
        {
            get
            {
                return autor + " " + name;
            }
        }
    }

    interface IGuest
    {
        public void ShowBooks();
    }

    interface IUser : IGuest
    {
        public void GetBook();
        public Book NewBook(string autor, string name);
        public void SendBook();
    }
    class User : IUser
    {
        private string login = "Login";
        private string password = "Password";

        public string Login
        {
            set
            {
                login = value;
            }
            get
            {
                return login;
            }
        }

        public string Password
        {
            set
            {
                password = value;
            }
            get
            {
                return password;
            }
        }

        public void GetBook()
        {
            Store store = new Store();
            store.Delivery();
        }
        public void ShowBooks()
        {
            Store store = new Store();
            store.ShowAveilebelBook();
        }
        public Book NewBook(string autor, string name)
        {
            Store store = new Store();
            store.StoreStorage();
            return new Book(autor, name);
        }
        public void SendBook()
        {
            BookTravelAgency agency = new BookTravelAgency();
            agency.SentToStore();
            Store store = new Store();
            store.StoreStorage();
        }

        class Store
        {
            public void StoreStorage()
            {
                Console.WriteLine("Books add in Store storage");
            }
            public void ShowAveilebelBook()
            {
                Book book = new Book();
                Console.WriteLine("Available book");
                Console.WriteLine(book.ConcretBook);
            }
            public void Delivery()
            {
                BookTravelAgency agency = new BookTravelAgency();
                agency.SendToUser();
            }
        }

        class BookTravelAgency
        {
            public void SendToUser()
            {
                Console.WriteLine("Your book send to you");
            }
            public void SentToStore()
            {
                Console.WriteLine("Your book send to store");
            }
        }

        class Program
        {
            public static string password;
            public static string login;
            public static string comand;
            public static string autor;
            public static string name;
           
            static void Main()
            {
                User user = new User();
                Console.WriteLine("Enter your Login");
                login = Console.ReadLine();
                if (login == user.login)
                {
                    Console.WriteLine("Enter password");
                    password = Console.ReadLine();
                    if (password == user.password)
                    {
                    Label:
                        Console.WriteLine("Enter comand - 1 for Show Books");
                        Console.WriteLine("Enter comand - 2 for Get Book");
                        Console.WriteLine("Enter comand - 3 for Load Book");
                        Console.WriteLine("Enter comand - 4 for Send your Book");
                        comand = Console.ReadLine();
                        switch (comand)
                        {
                            case "1":
                                {
                                    user.ShowBooks();
                                    goto Label;

                                }
                            case "2":
                                {
                                    user.GetBook();
                                    break;
                                }
                            case "3":
                                {
                                    Console.WriteLine("Enter autor");
                                    autor = Console.ReadLine();
                                    Console.WriteLine("Enter name of your book");
                                    name = Console.ReadLine();
                                    user.NewBook(autor, name);
                                    break;
                                }
                            case "4":
                                {
                                    user.SendBook();
                                    break;
                                }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong password");
                    }
                }
                else
                {
                    Console.WriteLine("You not a registered user but you may see our books");
                    IGuest guest = user;
                    guest.ShowBooks();
                }
            }

        }
    }
}
