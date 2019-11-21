using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _PE_LargeNonMersennePrime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountLast10Digit().ToString()); 
        }

        public static BigInteger CountLast10Digit()
        {
            long mod = 10000000000;
            BigInteger answer = 28433 * BigInteger.ModPow(2, 7830457, mod) + 1;
            return answer%mod;
        }
    }
}
