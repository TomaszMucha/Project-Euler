using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PE_HighlyDivisibleTriangularNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int triangleNumber = 1;
            int counter = 1;
            do
            {
                triangleNumber += counter+1;
                counter++;
            } while (GetDivisors(triangleNumber).Count<501);

            Console.WriteLine(triangleNumber);
        }

        static List<int> GetDivisors (int number)
        {
            List<int> Divisors = new List<int>();
            for (int i = 1; i < Math.Floor(Math.Sqrt(number+1)); i++)
            {
                if (number%i==0)
                {
                    Divisors.Add(i);
                    Divisors.Add(number/i);
                    Divisors.OrderBy(x=>x);
                }
            }
            return Divisors;
        }
    }
}
