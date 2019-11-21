using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PE_EvenFibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int fib1 = 1;
            int fib2 = 0;
            int fib3 = 0;
            do
            {
                fib3 = fib2 + fib1;
                fib1 = fib2;
                fib2 = fib3;
                if (fib3%2==0)
                {
                    sum += fib3;
                }
            } while (sum<4000001);

            Console.WriteLine(sum);
        }
    }
}
