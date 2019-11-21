using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PE_DistinctPrimesFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 1000005; i++)
            {
                if (i<1000000)
                {
                    if (GetPrimeFactors(i).Count==4 && GetPrimeFactors(i+1).Count == 4 && GetPrimeFactors(i+2).Count == 4 && GetPrimeFactors(i+3).Count == 4)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }

        public static List<int> GetPrimeFactors(int number)
        {
            int counter = 2;
            List<int> PrimeFactors = new List<int>();
            do
            {
                while (number % counter == 0)
                {
                    PrimeFactors.Add(counter);
                    number /= counter;
                }
                counter++;
            } while (number!=1);
            PrimeFactors = new HashSet<int>(PrimeFactors).ToList();
            return PrimeFactors;
        }
    }
}
