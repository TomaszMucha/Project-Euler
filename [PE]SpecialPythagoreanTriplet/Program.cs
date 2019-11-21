using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PE_SpecialPythagoreanTriplet
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Answer = new List<int>();
            List<List<int>> Triples = new List<List<int>>();
            for (int i = 1; i < 1000; i++)
            {
                for (int j = 1; j < 1000; j++)
                {
                    for (int k = 1; k < 1000; k++)
                    {
                        if (i+j+k==1000)
                        {
                            List<int> Triple = new List<int>();
                            Triple.Add(i);
                            Triple.Add(j);
                            Triple.Add(k);
                            Triples.Add(Triple);
                        }
                    }
                }
            }
            foreach (var item in Triples)
            {
                if (item[0]* item[0] + item[1]* item[1] == item[2]* item[2])
                {
                    Answer = item;
                }
            }
            foreach (var item in Answer)
            {
                Console.WriteLine(item);
            }
        }
    }
}
