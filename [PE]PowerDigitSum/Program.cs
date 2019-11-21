using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PE_PowerDigitSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[1000];
            for (int i = 0; i < 1000; i++)
            {
                number[i] = 0;
            }
            number[0] = 1;
            for (int i = 0; i < 1000; i++)
            {
                if (i%100==0)
                {
                    Console.WriteLine("Control");
                }
                for (int j = 0; j < 1000; j++)
                {
                    number[j]=number[j]*2;
                }
                for (int j = 0; j < 1000; j++)
                {
                    if (number[j] > 9)
                    {
                        number[j] = number[j] - 10;
                        number[j + 1] = number[j + 1] + 1;
                    }
                }
            }
            Console.WriteLine(number.Sum());
        }
    }
}
