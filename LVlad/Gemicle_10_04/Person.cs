using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemicle_10_04
{
    class Person
    {
        private DateTime _date;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BornDate 
        {
            get => _date; 
            set
            {
                if(value<= DateTime.Now)
                {
                    _date = value;
                }
            }
        }

        public Person()
        {

        }

        public Person(string fName, string lName, DateTime bornDate)
        {
            FirstName = fName;
            LastName = lName;
            BornDate = bornDate;
        }
       
    }
}
