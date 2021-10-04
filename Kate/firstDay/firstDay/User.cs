using System;
using System.Collections.Generic;
using System.Text;

namespace firstDay
{
    abstract class user 
    {
        public abstract void requestAnotherUser(int id, List<Book> toSend);
        public abstract void approveAnotherUser(int id, List<Book> book);
        public abstract void cancelRequest(int id, List<Book> book);
        public abstract void validateData();
    }

}
