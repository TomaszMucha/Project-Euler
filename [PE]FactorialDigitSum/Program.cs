using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;



namespace _PE_FactorialDigitSum
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger Factor = new BigInteger(1);
            for (int i = 1; i < 101; i++)
            {
                Factor = Factor * i;
            }
            string factorAsStrign = Factor.ToString();
            int sum = 0;
            foreach (var item in factorAsStrign)
            {
                sum+=Int32.Parse(item.ToString());
            }
            Console.WriteLine(sum);
        }
    }
}
