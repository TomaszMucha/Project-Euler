using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PE_10001stPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SizeOfTab");
            int size = Int32.Parse(Console.ReadLine());
            List<int> Numbers = new List<int>();
            List<int> Primes = new List<int>();
            int counter = 2;
            for (int i = 0; i < size-1; i++)
            {
                Numbers.Add(counter);
                counter++;
            }
            do
            {
                Primes.Add(Numbers.First());
                Numbers = Numbers.Select(x => x).Where(x => x % Numbers.First() != 0).ToList();
            } while (Numbers.Count!=0);

            Console.WriteLine(Primes[100000]);
        }
    }
}
