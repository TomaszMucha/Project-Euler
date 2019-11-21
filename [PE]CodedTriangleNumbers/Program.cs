using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PE_CodedTriangleNumbers
{
    class Program
    {

        public static List<int> TriangleNumbers = GenerateTriangleNumberUnder(32);

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "p042_words.txt"));
            string[] words = GetWordsFromFile(sr);
            Console.WriteLine(SearchNumberOfTriangleWords(words));
        }

        public static List<int> GenerateTriangleNumberUnder(int number)
        {
            List<int> TriangleNumbers = new List<int>();
            for (int i = 1; i < 33; i++)
            {
                TriangleNumbers.Add((i * (i + 1)) / 2);
            }
            return TriangleNumbers;
        }

        public static string[] GetWordsFromFile(StreamReader stream)
        {
            string text = stream.ReadToEnd();
            string[] words = text.Split(',');
            words = words.Select(x => x.Remove(0, 1)).ToArray<string>();
            words = words.Select(x => String.Concat(x.Reverse())).ToArray<string>();
            words = words.Select(x => x.Remove(0, 1)).ToArray<string>();
            words = words.Select(x => String.Concat(x.Reverse())).ToArray<string>();
            return words;
        }

        public static int CountWordValue(string word)
        {
            int answer = 0;
            foreach (var item in word)
            {
                answer += (int)item - 64;
            }
            return answer;
        }

        public static List<int> ConvertWordsToIntValue(string[] words)
        {
            List<int> wordsList = new List<int>();
            foreach (var item in words)
            {
                wordsList.Add(CountWordValue(item));
            }
            return wordsList;
        }

        public static int SearchNumberOfTriangleWords(string[] words)
        {
            List<int> TriangleWordsIntValue = ConvertWordsToIntValue(words);
            int triangleWordsCounter = 0;
            foreach (var wordIntValue in TriangleWordsIntValue)
            {
                foreach (var triangleNumber in TriangleNumbers)
                {
                    if (wordIntValue==triangleNumber)
                    {
                        triangleWordsCounter++;
                    }
                }
            }
            return triangleWordsCounter;
        }
    }
}
