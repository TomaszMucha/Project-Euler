using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PE_CircularPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = new List<int>();
            List<int> Primes = new List<int>();
            int counter = 2;
            for (int i = 0; i < 1000000 - 1; i++)
            {
                Numbers.Add(counter);
            }
            do
            {
                Primes.Add(Numbers.First());
                Numbers = Numbers.Select(x => x).Where(x => x % Numbers.First() != 0).ToList();
            } while (Primes.Count < 1000);
            Primes.AddRange(Numbers);
            Primes = Primes.Where(x => ((!(x.ToString().ToCharArray().Contains('2'))) && (!(x.ToString().ToCharArray().Contains('5'))) && (!(x.ToString().ToCharArray().Contains('0'))) || (x < 10))).ToList();
            List<int> CircularNumbers = new List<int>();
            List<int> TempPrime = new List<int>(Primes);
            foreach (var Prime in TempPrime)
            {
                List<int> temp = new List<int>();
                temp = GenereteAllShiftes(Prime);
                temp = new HashSet<int>(temp).ToList();
                int circularCounter = temp.Count;
                for (int i = 0; i < TempPrime.Count; i++)
                {
                    if (temp.Any(x => x == TempPrime[i]))
                    {
                        circularCounter--;
                    }
                }
                if (circularCounter == 0)
                {
                    CircularNumbers.AddRange(temp);

                }
                for (int j = 0; j < temp.Count; j++)
                {
                    Primes.RemoveAll(x => x == temp[j]);
                }
            }
            CircularNumbers = new HashSet<int>(CircularNumbers).ToList();
            Console.WriteLine(CircularNumbers.Count);
        }
    }
}

        public static List<int> GenereteAllShiftes(int number)
        {
            List<int> AllNumbers = new List<int>();
            char[] intAsCharArray = number.ToString().ToCharArray();
            int size = intAsCharArray.Count();
            for (int i = 0; i < size; i++)
            {
                char temp = intAsCharArray.Last();
                for (int j = 0; j < intAsCharArray.Length-1; j++)
                {
                    intAsCharArray[size-j-1] = intAsCharArray[size-2-j];
                }
                intAsCharArray[0] = temp;
                AllNumbers.Add(Int32.Parse(new String(intAsCharArray)));
            }
            return AllNumbers;
        }
    }
}
