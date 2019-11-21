using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PE_SmallestMultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsDivisible = false;
            int counter = 20;
            do
            {
                int conditionCounter = 0;
                for (int i = 11; i < 21; i++)
                {
                    if (counter%i==0)
                    {
                        conditionCounter++;
                    }   
                }
                counter++;
                if (conditionCounter==10)
                {
                    IsDivisible = true;
                }
                if (counter%1000000==0)
                {
                    Console.WriteLine("{0} {1}",counter, conditionCounter);
                }
            } while (!IsDivisible);

            Console.WriteLine(counter-1);
        }
    }
}
