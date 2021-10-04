using System;
using System.Collections.Generic;
using System.Text;

namespace firstDay
{
    class Credentials
    {
        private String password { get; set; }
        private String login
        { get; set;
        }
        Credentials(String pass, String login) 
        {
            this.password = password;
            this.login = login;
        }
        //login to app
        //check data from database
        private bool verifyUser() 
        {
            return true;
        }
    }
}
