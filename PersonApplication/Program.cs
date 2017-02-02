using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            // Person person = new Person();

            //create one teacher 
            Teacher teacher = new Teacher();
            teacher.Firstname = "kirsi";
            teacher.Lastname = "kernel";
            teacher.Age = 30;
            teacher.Address = " piippukatu 2";
            teacher.Phonenumber = "101-4567894";
            teacher.Room = "D444";
            Console.WriteLine(teacher.ToString());

            Student student = new Student("Matti", "mallikas", "H7982");
            student.Address = "kirkkokatu 72";
            student.Age = 23;
            student.Phonenumber = "121-4567892";
            Console.WriteLine(student.ToString());

            teacher.TeacherMethod();
            student.StudentMethod();

        }
    }
}
