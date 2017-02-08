using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication
{
    class Boss : Employee
    {

    public string Car { get; set; }
    public int Bonus { get; set; }

    // constructor
    public Boss()
        {
        }

        public Boss(string firstname, string lastname, string profession, int salary, string car, int bonus)
                : base(firstname, lastname)
        {
            Car = car;
            Bonus = bonus;
        }


        //methods
        public void BossMethod()
        {
            Console.WriteLine("Boss:");
        }
        public override string ToString()
        {
            return base.ToString() + ", Car: " + Car + ", Bonus: " + Bonus;
        }







    }
}
