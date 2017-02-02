using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HissiApplication
{
    class Hissi
    {
        private readonly int maxKerros = 5;
        private readonly int minKerros = 1;

        private int kerros;
        public int Kerros
        {
            get
            {
                return kerros;
            }
            set
            {
                if (minKerros <= value) kerros = value;
                else{
                    Console.WriteLine("syota olemassa oleva kerros!");
                    Kerros = kerros;
                }
            }
        }




    }
}
