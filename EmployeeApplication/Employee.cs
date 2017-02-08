using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication
{
    class Employee
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Profession { get; set; }
        public int Salary { get; set; }

        // constructor 
        public Employee()
        {
        }

        public Employee(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }

        //methods

        public void EmployeeMethod()
        {
            Console.WriteLine("Employee:");
        }
        public override string ToString()
        {
            return "- Name: " + Firstname + " " + Lastname + ", Profession: " + Profession + ", Salary: " + Salary;
        }


    }
}
