using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _PE_ConcealedSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BigInteger> Numbers = new List<BigInteger>();
            for (BigInteger i = 1000000000; i < 1414213562; i++)
            {
                if (i% 10==0)
                {
                    Numbers.Add(i * i);
                }
            }
            Numbers = Numbers.Where(x=>(x.ToString())[0]=='1').ToList();
            Numbers = Numbers.Where(x=>(x.ToString())[2]=='2').ToList();
            Numbers = Numbers.Where(x=>(x.ToString())[4]=='3').ToList();
            Numbers = Numbers.Where(x=>(x.ToString())[6]=='4').ToList();
            Numbers = Numbers.Where(x=>(x.ToString())[8]=='5').ToList();
            Numbers = Numbers.Where(x=>(x.ToString())[10]=='6').ToList();
            Numbers = Numbers.Where(x=>(x.ToString())[12]=='7').ToList();
            Numbers = Numbers.Where(x=>(x.ToString())[14]=='8').ToList();
            Numbers = Numbers.Where(x=>(x.ToString())[16]=='9').ToList();
            Numbers = Numbers.Where(x=>(x.ToString())[18]=='0').ToList();
            Console.WriteLine(Numbers.First());
        }
    }
}
