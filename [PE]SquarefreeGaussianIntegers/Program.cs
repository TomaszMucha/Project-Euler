using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PE_SquarefreeGaussianIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            GaussianInteger GI = new GaussianInteger(4,0);
            GI.IsPrime = GI.CheckIsPrime(GI);
            Console.WriteLine(GI.IsPrime);
        }
    }
}
