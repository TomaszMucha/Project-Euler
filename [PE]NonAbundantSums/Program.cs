using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _PE_NonAbundantSums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfAllNumberCanBeWrittenAsSumOfTwoAbundandNumbers(GetAllNumbersCanBeWrittenAsSumOfTwoAbundantNumbers(28123,GetAllAbundantUnder(28123))));
        }

        public static List<BigInteger> GetAllDivisors(BigInteger number)
        {
            List<BigInteger> Divisors = new List<BigInteger>();
            for (BigInteger i = 1; i < (Int32.Parse(number.ToString())/2)+1; i++)
            {
                if (number % i == 0)
                {
                    Divisors.Add(i);
                }
            }
            return Divisors;
        }

        public static BigInteger GetSumOfDivisors(List<BigInteger> Divisors)
        {
            BigInteger sum = 0;
            for (int i = 0; i < Divisors.Count; i++)
            {
                sum += Divisors[i];
            }
            return sum;
        }

        public static bool IsAbundant(BigInteger number, BigInteger sumOfDivisors)
        {
            return number < sumOfDivisors;
        }

        public static List<BigInteger> GetAllAbundantUnder(BigInteger number)
        {
            List<BigInteger> AbundantNumbers = new List<BigInteger>();
            for (BigInteger i = 12; i < number; i++)
            {
                if (IsAbundant(i,GetSumOfDivisors(GetAllDivisors(i))))
                {
                    AbundantNumbers.Add(i);
                    Console.WriteLine(i);
                }
            }
            return AbundantNumbers;
        }

        public static bool CanBeWrittenAsSumOfTwoAbundants(BigInteger number, List<BigInteger> AbundandNumbers)
        {
            Console.WriteLine(number);
            for (BigInteger i = 0; i < AbundandNumbers.Count; i++)
            {
                for (BigInteger j = 0; j < AbundandNumbers.Count; j++)
                {
                    if (AbundandNumbers[Int32.Parse(i.ToString())] +AbundandNumbers[Int32.Parse(j.ToString())] ==number)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static BigInteger SumOfAllNumberCanBeWrittenAsSumOfTwoAbundandNumbers(List<BigInteger> NumbersToSum)
        {
            BigInteger sum = 0;
            for (int i = 0; i < NumbersToSum.Count; i++)
            {
                sum += NumbersToSum[i];
            }
            return sum;
        }

        public static List<BigInteger> GetAllNumbersCanBeWrittenAsSumOfTwoAbundantNumbers(BigInteger number, List<BigInteger> AbundantNumbers)
        {
            List<BigInteger> NumbersCanBeWrittenAsSumOfTwoAbundantNumbers = new List<BigInteger>();
            for (BigInteger i = 12; i < number; i++)
            {
                if (CanBeWrittenAsSumOfTwoAbundants(i, AbundantNumbers))
                {
                    NumbersCanBeWrittenAsSumOfTwoAbundantNumbers.Add(i);
                }
            }
            return NumbersCanBeWrittenAsSumOfTwoAbundantNumbers;
        }
    }
}
