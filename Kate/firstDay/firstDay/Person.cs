using System;
using System.Collections.Generic;
using System.Text;

namespace firstDay
{
    class Person : user
    {
        int id;
        public List<Book> booksOfUser;
        String requstsFromUser;
        String myRequests;
        private String name { get; set; }
        private String surname { get; set; }
        private String address { get; set; }
        private DateTime dateOfBirth { get; set; }
        public Person(String name, String surname, String address)
        {
            booksOfUser = new List<Book>();
            this.name = name;
            this.surname = surname;
            this.address = address;
        }
        public int numOfDeliveries;
        public int numOfReceiving;
        String number;
        String email;
        bool check()
        {
            if (numOfDeliveries != numOfReceiving)
                return false;
            return true;
        }
        public void addBook(Book b)
        {
            booksOfUser.Add(b);
        }
        override
        public void requestAnotherUser(int id, List<Book> toSend)
        {
            //find user by id in database and add to his/her requests
            //requstsFromUser += id +" " + toSend.ToArray().ToString();
        }
        override
       public void approveAnotherUser(int id, List<Book> book)
        {
            TransferCenter.deliver(book);
            //removal of requested books from users and request removel
            FinalFeedback.proposeFeedback();

        }
        override
        public void cancelRequest(int id, List<Book> book)
        {
            //removal of request

        }
        override
        public void validateData()
        {
        }
    }
}
