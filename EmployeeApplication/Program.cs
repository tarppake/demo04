using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
        
            //luo työntekijän
            Employee employee = new Employee();
            employee.Firstname = "Kirsi";
            employee.Lastname = "Kernel";
            employee.Profession = "Teacher";
            employee.Salary = 1200;
            employee.EmployeeMethod(); // tulostaa employee:
            Console.WriteLine(employee.ToString()); // tulosta työntekijän tiedot


            
            // luo pomon
            Boss boss = new Boss();
            boss.Firstname = "Jussi";
            boss.Lastname = "Jurkka";
            boss.Profession = "Head of Institute";
            boss.Salary = 9000;
            boss.Car = "Audi";
            boss.Bonus = 5000;
            boss.BossMethod(); //tulostaa boss:
            Console.WriteLine(boss.ToString()); //tulostaa pomon tiedot
        }
    }
}
