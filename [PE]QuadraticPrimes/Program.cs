using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PE_QuadraticPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<QuadricExpression> quadricExpressions = new List<QuadricExpression>();
            quadricExpressions = GetQuadricExpressionList(quadricExpressions);
            Console.WriteLine(SearchCoefficientsOfQuadricExpressionContainLongestPrimeSequence(quadricExpressions));
        }

        public static bool IsPrime(long number)
        {
            bool isPrime = true;
            number = Math.Abs(number);
            for (int i = 2; i <= number / 2; i++)
            {
                if (number%i==0 )
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }

        public static long CalculateExpression(QuadricExpression QE, int n)
        {
            return (n*n+QE.A*n+QE.B);
        }

        public static List<QuadricExpression> GetQuadricExpressionList(List<QuadricExpression> quadricExpressions)
        {
            for (int i = -999; i < 1000; i++)
            {
                for (int j = -999; j < 1000; j++)
                {
                    quadricExpressions.Add(new QuadricExpression(i, j));
                }
            }
            return quadricExpressions;
        }

        public static int SearchCoefficientsOfQuadricExpressionContainLongestPrimeSequence(List<QuadricExpression> quadricExpressions)
        {
            int counter = 0;
            int longestPrimeSequenceCount = 0;
            QuadricExpression BestQuadricExpression = new QuadricExpression(1, 1);
            foreach (var quadricExpression in quadricExpressions)
            {
                counter = 0;
                while (IsPrime(CalculateExpression(quadricExpression, counter)))
                {
                    counter++;
                }
                if (counter>longestPrimeSequenceCount)
                {
                    longestPrimeSequenceCount = counter;
                    BestQuadricExpression = quadricExpression;
                }
            }
            return BestQuadricExpression.A*BestQuadricExpression.B;
        }

    }
}
