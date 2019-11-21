using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PE_PentagonNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> PentagonalNumbers = new List<int>();
            List<PentagonalPair> PentagonalPairs = new List<PentagonalPair>();
            for (int i = 1; i < 10001; i++)
            {
                PentagonalNumbers.Add((3 * i * i - i) / 2);
            }
            Console.WriteLine("----");
            for (int i = 0; i < PentagonalNumbers.Count; i++)
            {
                for (int j = 0; j < PentagonalNumbers.Count; j++)
                {
                    if (i<j)
                    {
                        if (IsPentagonal(PentagonalNumbers[j] - PentagonalNumbers[i], PentagonalNumbers) && IsPentagonal(PentagonalNumbers[i] + PentagonalNumbers[j], PentagonalNumbers))
                        {
                            PentagonalPairs.Add(new PentagonalPair(PentagonalNumbers[i], PentagonalNumbers[j]));
                        } 
                    }
                }
            }
            Console.WriteLine((PentagonalPairs.Max(x=>x.PentagonalB-x.PentagonalA)));
        }

        public static bool IsPentagonal(int a, List<int> PentagonalNumbers)
        {
            double resoult = (Math.Sqrt(24 * a + 1) + 1) / 6;
            return (double)(int)resoult == resoult;
        }
    
    }
}
