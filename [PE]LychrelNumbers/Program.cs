using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _PE_LychrelNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetAllLychrelNumberBelow(10000).Count);
        }

        public static bool IsPalindromic(BigInteger number)
        {
            string numberAsString = number.ToString();
            string ReversNumberAsString = new String(numberAsString.Reverse().ToArray());
            if (ReversNumberAsString == numberAsString)
            {
                return true;
            }
            return false;
        }

        public static BigInteger AddNumberAndReverseNumber(BigInteger number)
        {
            return (number + BigInteger.Parse(new String(number.ToString().Reverse().ToArray())));
        }

        public static bool IsLychrelNumber(BigInteger number)
        {
            int i = 0;
            do
            {
                number = AddNumberAndReverseNumber(number);
                if (IsPalindromic(number))
                {
                    return false;
                }
                i++;
            } while (i != 50);
            return true;
        }

        public static List<BigInteger> GetAllLychrelNumberBelow(BigInteger number)
        {
            List<BigInteger> LychrelNumbers = new List<BigInteger>();
            for (int i = 10; i < 10001; i++)
            {
                if (IsLychrelNumber(i))
                {
                    LychrelNumbers.Add(i);
                }
            }
            return LychrelNumbers;
        }
    }
}
