using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _PE_DigitFactorialChains
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumbersOfSequenceSixtyLength(GetCyclesLengthForNumberUnder(1000000)));
        }

        public static BigInteger GetSumOfDigitFactorial(BigInteger number)
        {
            List<BigInteger> Digits = new List<BigInteger>();
            string numberAsString = number.ToString();
            foreach (var digit in numberAsString)
            {
                Digits.Add(Int32.Parse(digit.ToString()));
            }
            BigInteger sum = 0;
            foreach (var digit in Digits)
            {
                sum += Factorial(digit);
            }
            return sum;
        }

        public static BigInteger Factorial(BigInteger number)
        {
            BigInteger toReturn = 1;
            for (int i = 1; i < number+1; i++)
            {
                toReturn = toReturn * i;
            }
            return toReturn;
        }

        public static List<BigInteger> GetOneCycle(BigInteger number)
        {
            List<BigInteger> Cycle = new List<BigInteger>();
            do
            {
                Cycle.Add(number);
                number = GetSumOfDigitFactorial(number);
            } while (!Cycle.Contains(number));
            return Cycle;
        }

        public static List<int> GetCyclesLengthForNumberUnder(BigInteger number)
        {
            List<int> SequenceLengths = new List<int>();
            for (int i = 5; i < number; i++)
            {
                if (i%10000==0)
                {
                    Console.WriteLine(i);
                }
                SequenceLengths.Add(GetOneCycle(i).Count);
            }
            return SequenceLengths;
        }

        public static int NumbersOfSequenceSixtyLength(List<int> SequenceLengths)
        {
            return SequenceLengths.Count(x => x == 60);
        }
    }
}
