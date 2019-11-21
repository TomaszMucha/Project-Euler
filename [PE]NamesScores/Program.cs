using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace _PE_NamesScores
{
    class Program
    {
        static void Main(string[] args)
        {
            string Names = File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "..", "..", "p022_names.txt"));
            string[] SplitedNames = Names.Split(',');
            List<string> NamesAsList = SplitedNames.ToList();
            List<string> TempNames = new List<string>();
            foreach (var item in SplitedNames)
            {
                string s = item;
                s = s.Remove(0, 1);
                s = s.Remove(s.Length-1, 1);
                TempNames.Add(s);
            }
            NamesAsList = new List<string>(TempNames);
            NamesAsList.Sort();
            int SumOfNames = 0;
            for (int i = 0; i < NamesAsList.Count; i++)
            {
                    SumOfNames += (i + 1) * CountStringValue(NamesAsList[i]);
            }
            Console.WriteLine(SumOfNames);
        }

        public static int CountStringValue (string s)
        {
            int value = 0;
            foreach (var item in s)
            {
                value += (int)item - 64;
            }
            return value;
        }
    }
}
