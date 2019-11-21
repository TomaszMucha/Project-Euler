using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PE_CoinSums
{
    class Program
    {
        //Find Coin Change Article on Wikipedia + PDF in solution
        public static List<int> Coins = new List<int>() { 200, 100, 50, 20, 10, 5, 2, 1};

        static void Main(string[] args)
        {
            Console.WriteLine(CalculateStep(200,7));
        }

        public static int CalculateStep(int N, int m)
        {
            if (N<0 || m<0)
            {
                return 0;
            }
            else
            {
                if (N==0)
                {
                    return 1;
                }
                else
                {
                    return CalculateStep(N, m - 1) + CalculateStep(N - Coins[m], m);
                }
            }
        }
        
    }
}
