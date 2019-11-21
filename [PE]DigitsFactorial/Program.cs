using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _PE_DigitsFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BigInteger> Numbers = new List<BigInteger>();
            for (int i = 3; i < 2540161; i++)
            {
                if (GetSumOfDigitFactor(GetDigits(i))==i)
                {
                    Numbers.Add(i);
                }
            }

            Console.WriteLine(Numbers.Aggregate((currentSum, item)=>currentSum+item));
        }

        public static List<int> GetDigits(int number)
        {
            char[] numberChars = number.ToString().ToCharArray();
            List<int> Digits = new List<int>();
            foreach (var Digit in numberChars)
            {
                Digits.Add(((int)Digit) - 48);
            }

            return Digits;
        }

        public static BigInteger GetSumOfDigitFactor(List<int> Digits)
        {
            BigInteger sum = 0;
            foreach (var Digit in Digits)
            {
                sum += GetFactorial(Digit);
            }
            return sum;
        }

        public static BigInteger GetFactorial(int number)
        {
            BigInteger Resoult = 1;
            for (int i = 1; i < number + 1; i++)
            {
                Resoult = Resoult * i;
            }
            return Resoult;
        }
    }
}
