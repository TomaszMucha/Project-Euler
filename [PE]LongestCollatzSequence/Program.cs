using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _PE_LongestCollatzSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger bigestNumber=1;
            BigInteger longestSequence = 0;
            for (int i = 1; i < 1000001; i++)
            {
                BigInteger CollatzSequenceIteration = CollatzSequence(i);
                if (CollatzSequenceIteration>longestSequence)
                {
                    bigestNumber = i;
                    longestSequence = CollatzSequence(i);
                }
            }
            Console.WriteLine("The longest Collatz sequence we get for number {0}", bigestNumber);
        }

        static BigInteger CollatzSequence(int startingNumber)
        {
            BigInteger Iteration = new BigInteger(0);
            BigInteger number = startingNumber;
            do
            {
                if (number%2==0)
                {
                    number = number / 2;
                    Iteration++;
                }
                else
                {
                    number = number * 3 + 1;
                    Iteration++;
                }
            } while (number!=1);

            return Iteration;
        }
    }
}
