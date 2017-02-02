using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HissiApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Hissi hissi = new Hissi();
            hissi.Kerros = 1;

            do
            {
                Console.Write("anna kerros(1 - 5):  ");
                string line = Console.ReadLine();

                Console.WriteLine("hissi on nyt kerroksessa " + hissi.Kerros);
            } while();

        }
    }
}
