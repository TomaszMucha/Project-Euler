using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PE_ChampernownesConstant
{
    class Program
    {
        static void Main(string[] args)
        {
            string ChampernownesSequence = GenerateChampernownesSequence();
            int answer = GetDigitProduct(ChampernownesSequence);
            Console.WriteLine("Answer is: {0}", answer);
        }

        public static string GenerateChampernownesSequence()
        {
            string ChampernowesSequence = "";
            int counter = 0;
            while (ChampernowesSequence.Length<1000000)
            {
                counter++;
                if (counter%1000==0)
                {
                    Console.WriteLine(counter);
                }
                ChampernowesSequence += counter.ToString();
            }
            return ChampernowesSequence;
        }

        public static int GetDigitProduct(string ChampernowesSequence)
        {
            return (Int32.Parse(ChampernowesSequence[0].ToString()) * 
                    Int32.Parse(ChampernowesSequence[9].ToString()) * 
                    Int32.Parse(ChampernowesSequence[99].ToString()) * 
                    Int32.Parse(ChampernowesSequence[999].ToString()) *
                    Int32.Parse(ChampernowesSequence[9999].ToString()) *
                    Int32.Parse(ChampernowesSequence[99999].ToString()) *
                    Int32.Parse(ChampernowesSequence[999999].ToString()));
        }
    }
}
