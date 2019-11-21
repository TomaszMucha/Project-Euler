using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.IO;
using System.Reflection;

namespace _PE_LargeSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            List<string> Numbers = new List<string>();
            string line = "start";
            try
            {
                StreamReader sr = new StreamReader("Numbers.txt");
                while (line!=null)
                {
                    line = sr.ReadLine();
                    if (line!=null)
                    {
                        Numbers.Add(line);
                        counter++;
                    }
                }
                Console.WriteLine("You have {0} numbers", counter);
            }

            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            foreach (var item in Numbers)
            {
                Console.WriteLine(item);
            }

            BigInteger sum = new BigInteger(0);

            for (int i = 0; i < 100; i++)
            {
                sum += BigInteger.Parse(Numbers[i]);
            }

            Console.WriteLine(sum);
        }
    }
}
