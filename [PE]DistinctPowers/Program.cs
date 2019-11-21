using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _PE_DistinctPowers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BigInteger> Numbers = new List<BigInteger>();
            for (int i = 2; i < 101; i++)
            {
                for (int j = 2; j < 101; j++)
                {
                    BigInteger temp = new BigInteger(1);
                    BigInteger multiplicator = i;
                    for (int k = 0; k < j; k++)
                    {
                        temp *= i;
                    }
                    Numbers.Add(temp);
                }
            }

            Numbers =  (new HashSet<BigInteger>(Numbers)).ToList();

            Console.WriteLine(Numbers.Count);
        }
    }
}
