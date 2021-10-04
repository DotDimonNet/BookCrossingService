using System;
using System.Collections.Generic;
using System.Text;

namespace firstDay
{
    class Library : user
    {
        int id;
        public List<Book> booksOfUser;
        String requstsFromUser { get; set; }
        String myRequests { get; set; }
        private String name { get; set; }
        private String address { get; set; }
        public Library(String name, String address)
        {
            booksOfUser = new List<Book>();
            this.name = name;
            this.address = address;
        }
        public int numOfDeliveries;
        public int numOfReceiving;
        String number;
        String email;

        override
        public void requestAnotherUser(int id, List<Book> toSend)
        {

        }
        override
       public void approveAnotherUser(int id, List<Book> book)
        {
            TransferCenter.deliver(book);
            //removal of books from users 
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
