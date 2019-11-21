using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _PE_100DigitFibonacciNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 2;
            List<BigInteger> FibSeq = new List<BigInteger>();
            FibSeq.Add(1);
            FibSeq.Add(1);
            string bigIntStringInit = "1";
            for (int i = 0; i < 999; i++)
            {
                bigIntStringInit += "0";
            }
            do
            {
                FibSeq.Add(FibSeq[counter-2] + FibSeq[counter-1]);
                counter++;
            } while (FibSeq[counter-1]<(BigInteger.Parse(bigIntStringInit)));
            Console.WriteLine(counter);
        }
    }
}
