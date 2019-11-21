using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PE_DigitFifthPowers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = new List<int>();
            for (int i = 2; i < 400000; i++)
            {
                if (GetFifthPowerOfDigitSum(GetDigits(i))==i)
                {
                    Numbers.Add(i);
                }
            }

            foreach (var item in Numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(Numbers.Sum());
        }
       
        public static List<int> GetDigits(int number)
        {
            char[] numberChars = number.ToString().ToCharArray();
            List<int> Digits = new List<int>();
            foreach (var Digit in numberChars)
            {
                Digits.Add(((int)Digit)-48);
            }

            return Digits;
        }

        public static int GetFifthPowerOfDigitSum(List<int> Digits)
        {
            int sum = 0;
            foreach (var Digit in Digits)
            {
                sum += (int)Math.Pow(Digit,5);
            }
            return sum;
        }
    }
}
