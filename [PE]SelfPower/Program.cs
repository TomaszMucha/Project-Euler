using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _PE_SelfPower
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum = 0;
            for (int i = 1; i < 1001; i++)
            {
                sum += GetSelfPowerLastTenDigit(i);
            }

            Console.WriteLine(sum%(long)Math.Pow(10,10));
        }

        public static long GetSelfPowerLastTenDigit(long number)
        {
            int counter = (int)number;
            long answer = number;
            for (int i = 1; i < counter; i++)
            {
                answer = (answer * number) % (long)Math.Pow(10, 10);
            }
            return answer;
        }
    }
}
