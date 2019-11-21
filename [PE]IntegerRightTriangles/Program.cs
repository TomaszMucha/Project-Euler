using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PE_IntegerRightTriangles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetPythagoreanTriplesSequencesMaxLength(1000));
        }

        public static List<PythagoreanTriple> SearchPythagoreanTripleByBrutalForce(int perimeter)
        {
            List<PythagoreanTriple> PythagoreanTriples = new List<PythagoreanTriple>();
            for (int i = 1; i < perimeter; i++)
            {
                for (int j = 1; j < perimeter-i; j++)
                {
                    if (Math.Sqrt(i*i+j*j)== (double)((int)Math.Sqrt(i * i + j * j)))
                    {
                        if (i + j + Math.Sqrt(i * i + j * j)==perimeter)
                        {
                            PythagoreanTriples.Add(new PythagoreanTriple(i, j, (int)Math.Sqrt(i * i + j * j)));
                        }
                    }
                }
            }
            return PythagoreanTriples;
        }

        public static int GetPythagoreanTriplesSequencesMaxLength(int maxPerimeter)
        {
            List<int> Answers = new List<int>();
            int maxLength = 0;
            int perimeterWithMaxLengthSolution = 0;
            for (int i = 3; i < maxPerimeter+1; i++)
            {
                int answer = SearchPythagoreanTripleByBrutalForce(i).Count/2;
                Answers.Add(answer);
                if (answer>maxLength)
                {
                    maxLength = answer;
                    perimeterWithMaxLengthSolution = i;
                }
            }
            return perimeterWithMaxLengthSolution;
        }
    }
}
