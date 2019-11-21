using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _PE_PowerfulDigitCounts
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BigInteger> Answers = new List<BigInteger>();
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 40; j++)
                {
                    if (PowOnBigInteger(i, j).ToString().Count()==j)
                    {
                        BigInteger Answer = PowOnBigInteger(i, j);
                        Answers.Add(Answer);
                    }
                }
            }
            Console.WriteLine(Answers.Count());
        }

        public static BigInteger PowOnBigInteger(int number, int pow)
        {
            BigInteger Answer = 1;
            for (int i = 0; i < pow; i++)
            {
                Answer*= number;
            }
            return Answer;
        }
    }
}
