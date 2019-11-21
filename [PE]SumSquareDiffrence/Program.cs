using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PE_SumSquareDiffrence
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum1 = 0;
            int sum2 = 0;
            int finalsum = 0;
            for (int i = 1; i < 101; i++)
            {
                sum1 += i * i;
                sum2 += i;
            }
            finalsum = sum2 * sum2 - sum1;
            Console.WriteLine(finalsum);
        }
    }
}
