using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PE_AmicableNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<NumberWithDivisors> Numbers = new List<NumberWithDivisors>();
            for (ulong i = 2; i < 10000; i++)
            {
                Numbers.Add(new NumberWithDivisors(i));
            }

            for (ulong i = 0; i < 9998; i++)
            {
                Numbers[(int)i] = GetProperDivisors(Numbers[(int)i]);
                Numbers[(int)i].SumOfDivisors = (ulong)Numbers[(int)i].Divisors.Sum(x => (decimal)x);
            }

            List<NumberWithDivisors> AmicableNumbers = new List<NumberWithDivisors>();
            List<NumberWithDivisors> ReducedAmicableNumbers = new List<NumberWithDivisors>();

            for (ulong i = 0; i < 9998; i++)
            {
                for (ulong j = 0; j < 9998; j++)
                {
                    if (Numbers[(int)i].Number==Numbers[(int)j].SumOfDivisors && i!=j && Numbers[(int)j].Number == Numbers[(int)i].SumOfDivisors)
                    {
                        AmicableNumbers.Add(Numbers[(int)i]);
                        AmicableNumbers.Add(Numbers[(int)j]);
                        if (i%1000==0 && j % 1000 == 0)
                        {
                            Console.WriteLine("Checked: {0} {1}", i, j);
                        }
                    }
                }
            }

            ReducedAmicableNumbers = AmicableNumbers.GroupBy(x=>x.Number).Select(x=>x.First()).ToList();
            ReducedAmicableNumbers.Sort((x, y) => x.Number.CompareTo(y.Number));

            Console.WriteLine(ReducedAmicableNumbers.Sum(x=>(decimal)x.Number));
            
        }

        static NumberWithDivisors GetProperDivisors(NumberWithDivisors Number)
        {
            for (ulong i = 1; i < Math.Floor(Math.Sqrt(Number.Number))+1; i++)
            {
                if (Number.Number % i == 0)
                {
                    Number.Divisors.Add(i);
                    Number.Divisors.Add(Number.Number / i);
                }
            }
            Number.Divisors.OrderBy(x=>x);
            Number.Divisors.Sort();
            Number.Divisors = new HashSet<ulong>(Number.Divisors).ToList();
            if (Number.Divisors.Count!=0)
            {
                Number.Divisors.RemoveAt(Number.Divisors.Count-1);
            }
            return Number;
        }
    }
}
