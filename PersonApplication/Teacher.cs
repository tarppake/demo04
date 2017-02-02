using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Teacher : Person //periytyy
    {
        
        public string Room { get; set; }


        // constructors
        public Teacher()
        {
        }

        public Teacher(string firstname, string lastname, string room)
            : base(firstname, lastname) //kutsuu konstruktoria
        {
            Room = room;
        }

        public void TeacherMethod()
        {
            Console.WriteLine("this method belongs to teacher");
        }

        public override string ToString()
        {
            //base on tässä person luokka,
            //eli kutsutaan person luokan tostring()-metodia
            //eli siis: return Firstname + " " + Lastname + " " + Room
            return base.ToString() + " " + Room;
        }

    }
}
