using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Person
    {

    //properties

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string Phonenumber { get; set; }

    //constructor
        
        public Person()
        {
        }
        
       public Person(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }

    //methods

        public void PersonMethod()
        {
            Console.WriteLine("this method belongs to Person!");
        }

        public override string ToString()
        {
            return Firstname + " " + Lastname + " " + Address + " " + Age + " " + Phonenumber;
        }


    }
}
