using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PE_GoldbachsOtherConjecture
{
    class Program
    {

        public static List<int> Primes = EratosthenesSieveUnder(10000);

        static void Main(string[] args)
        {
            List<int> Numbers = GenerateIntFromTo(2, 10000);
            List<int> OddCompositeNumbers = SelectOddCompostieNumbers(Numbers);
            Console.WriteLine(SearchForFirstUnGoldbachNumber(OddCompositeNumbers));
        }

        public static List<int> GenerateIntFromTo(int From, int To)
        {
            List<int> Numbers = new List<int>();
            for (int i = From; i < To + 1; i++)
            {
                Numbers.Add(i);
            }
            return Numbers;
        }

        public static List<int> SelectOddCompostieNumbers(List<int> Numbers)
        {
            Console.WriteLine("Generate odd composite number");
            List<int> OddCompositeNumbers = Numbers.Where(x => x % 2 != 0).ToList();
            OddCompositeNumbers = SelectCompositeNumbers(OddCompositeNumbers);
            Console.WriteLine("End generate odd composite number");
            return OddCompositeNumbers;
        }

        public static List<int> EratosthenesSieveUnder(int Under)
        {
            List<int> Numbers = GenerateIntFromTo(2, Under);
            List<int> EratosthenesSieve = new List<int>();
            Console.WriteLine("Generate prime numbers");
            while (Numbers.Count != 0)
            {
                    EratosthenesSieve.Add(Numbers.First());
                    Numbers = Numbers.Where(x => !(x % Numbers.First() == 0)).ToList();
            }
            Console.WriteLine("Generate prime numbers compliete");
            return EratosthenesSieve;
        }

        public static bool IsPrime(int Number)
        {
            Primes.Where(x => x == Number);
            return !(Primes.Where(x => x == Number).ToList().Count==0) ;
        }

        public static List<int> GenerateAllDoubleSquaresUnder(int Number)
        {
            List<int> SquareNumbers = new List<int>();
            int counter = 1;
            do
            {
                SquareNumbers.Add(counter);
                counter++;
            } while (2*counter*counter<Number);
            return SquareNumbers;
        }

        public static bool IsGoldbachNumber(int Number)
        {
            List<int> NumberSquaresNumbersDifference = new List<int>();
            List<int> SquareNumbers = GenerateAllDoubleSquaresUnder(Number);
            NumberSquaresNumbersDifference = new List<int>(SquareNumbers);
            NumberSquaresNumbersDifference = NumberSquaresNumbersDifference.Select(x => x = Number - 2*x*x).ToList();
            return !(NumberSquaresNumbersDifference.Where(x => IsPrime(x)).ToList().Count == 0);
        }

        public static int SearchForFirstUnGoldbachNumber(List<int> OddCompositeNumbers)
        {
            Console.WriteLine("Searching for Ungoldbach number");
            foreach (var item in OddCompositeNumbers)
            {
                if (!IsGoldbachNumber(item))
                {
                    return item;
                }
            }
            Console.WriteLine("Goldbach number not found, try bigger range");
            return 0;
        }

        public static List<int> SelectCompositeNumbers(List<int> Numbers)
        {
            foreach (var prime in Primes)
            {
                if (Numbers.Contains(prime))
                {
                    Numbers.Remove(prime);
                }
            }
            return Numbers;
        }
    }
}
