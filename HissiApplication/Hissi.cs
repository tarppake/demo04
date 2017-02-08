using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HissiApplication
{
    class Hissi
    {
        //private readonly int maxKerros = 5;
        private readonly int minKerros = 1;

        private int Kerros;
        public int kerros
        {
            get
            {
                return kerros;
            }
            set
            {
                if (Kerros => minKerros) Kerros = kerros;
                else{
                    Console.WriteLine("syota olemassa oleva kerros!");
                 
                }
            }
        }




    }
}
