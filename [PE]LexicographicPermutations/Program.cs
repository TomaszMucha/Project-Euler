using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PE_LexicographicPermutations
{
    class Program
    {
        static void Main(string[] args)
        {
            string InitalString = "0123456789";
            IEnumerable<string> Answers = Permutate(InitalString);
            Console.WriteLine("Working");
            List<string> SortAnswers = Answers.ToList();
            Console.WriteLine("Working");
            SortAnswers.Sort();
            Console.WriteLine(SortAnswers[999999]);
            Console.WriteLine(SortAnswers[1000000]);
            Console.WriteLine(SortAnswers[1000001]);
        }

        private static IEnumerable<string> Permutate(string source)
        {
            if (source.Length == 1) return new List<string> { source };

            var permutations = from c in source
                               from p in Permutate(new String(source.Where(x => x != c).ToArray()))
                               select c + p;

            return permutations;
        }
    }
}
