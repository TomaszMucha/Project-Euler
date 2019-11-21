using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _PE_LatticePaths
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger Answer = Factor(40) / (Factor(20) * Factor(20));
            Console.WriteLine("Answer: " + Answer);

        }

        public static BigInteger Factor(int number)
        {
            BigInteger Answer = new BigInteger(1);
            for (int i = 1; i < number+1; i++)
            {
                Answer = Answer * i;
            }
            return Answer;
        }
    }
}
