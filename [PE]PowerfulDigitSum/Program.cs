using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _PE_PowerfulDigitSum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BigInteger> DigitsSumOfNumbers = new List<BigInteger>();
            for (int i = 1; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    BigInteger temp = new BigInteger(1);
                    for (int k = 0; k < j+1; k++)
                    {
                        temp *= i;
                    }
                    DigitsSumOfNumbers.Add(temp.ToString().Sum(x=>x-'0'));
                }
            }
            Console.WriteLine(DigitsSumOfNumbers.Max());
        }
    }
}