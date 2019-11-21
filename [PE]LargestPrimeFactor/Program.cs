using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PE_LargestPrimeFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            long number;
            long largestPrimeFactor = 0;
            Console.WriteLine("Number?");
            number = Int64.Parse(Console.ReadLine());
            do
            {
                int divider = 1;
                do
                {
                    divider++;
                } while (number % divider != 0);
                number = number / divider;
                largestPrimeFactor = divider;
            } while (number != 1);
            Console.WriteLine("Largest prime number = {0}",largestPrimeFactor);
        }
    }
}
