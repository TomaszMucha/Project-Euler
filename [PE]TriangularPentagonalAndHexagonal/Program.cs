using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PE_TriangularPentagonalAndHexagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<double>> Numbers = new List<List<double>>() { new List<double>(), new List<double>(), new List<double>() };
            Numbers = NumbersInit(Numbers);
            do
            {
                Numbers = AddNextNumber(Numbers);
                if (Numbers[0].Count%1000==0)
                {
                    Console.WriteLine(Numbers[0].Count);
                }
            } while (!IsAnswer(Numbers));

            Console.WriteLine(Numbers[0]);
        }

        public static List<List<double>> NumbersInit(List<List<double>> Numbers)
        {
            Numbers[0].Add(1);
            Numbers[0].Add(3);
            Numbers[1].Add(1);
            Numbers[1].Add(5);
            Numbers[2].Add(1);
            Numbers[2].Add(6);
            return Numbers;
        }


        public static bool IsFirstSolution(List<List<double>> Numbers)
        {
            if (Numbers[0].Count==285)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static List<List<double>> AddNextTriangleNumber(List<List<double>> Numbers)
        {
            double index = Numbers[0].Count;
            Numbers[0].Add(((index + 1) * (index + 2)) / 2);
            return Numbers;
        }

        public static List<List<double>> AddNextPentagonalNumber(List<List<double>> Numbers)
        {
            double index = Numbers[1].Count;
            Numbers[1].Add(((index + 1) * (3*(index+1)-1 )) / 2);
            return Numbers;
        }

        public static List<List<double>> AddNextHexagonalNumber(List<List<double>> Numbers)
        {
            double index = Numbers[2].Count;
            Numbers[2].Add((index + 1) * (2*(index+1) - 1));
            return Numbers;
        }

        public static double SearchForSequenceIndexWithLowestNumber(List<List<double>> Numbers)
        {
            if (Numbers[0].Last()<Numbers[1].Last() && Numbers[0].Last() < Numbers[2].Last())
            {
                return 0;
            }
            else
            {
                if (Numbers[1].Last() < Numbers[2].Last())
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
        
        public static bool IsAnswer(List<List<double>> Numbers)
        {
            if (IsFirstSolution(Numbers))
            {
                return false;
            }
            if (Numbers[0].Last()== Numbers[1].Last() && Numbers[1].Last() == Numbers[2].Last())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static List<List<double>> AddNextNumber(List<List<double>> Numbers)
        {
            double index = SearchForSequenceIndexWithLowestNumber(Numbers);
            if (index == 0)
            {
                Numbers = AddNextTriangleNumber(Numbers);
            }
            else
            {
                if (index==1)
                {
                    Numbers = AddNextPentagonalNumber(Numbers);
                }
                else
                {
                    Numbers = AddNextHexagonalNumber(Numbers);
                }
            }
            return Numbers;
        }
    }
}
