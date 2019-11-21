//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.IO;
//using System.Numerics;

//namespace _PE_LargestExponential
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                using (StreamReader sr = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "p099_base_exp.txt")))
//                {
//                    String numbers = sr.ReadToEnd();
//                    string[] numbersTab = numbers.Split(new char[] { ',', (char)10 });
//                    List<double[]> SeparatedNumbers = new List<double[]>();
//                    int counter = 1;
//                    double[] number = new double[2];
//                    foreach (var item in numbersTab)
//                    {
//                        if (counter%2==1)
//                        {
//                            number[0] = Double.Parse(item);
//                            counter++;
//                        }
//                        else
//                        {
//                            number[1] = Double.Parse(item);
//                            SeparatedNumbers.Add(number);
//                            number = new double[2];
//                            counter++;
//                        }
//                    }

//                    foreach (var item in SeparatedNumbers)
//                    {
//                        Console.WriteLine(item[0] + " " + item[1]);
//                    }
//                    double baseNumber = SeparatedNumbers.First()[0];
//                    for (int i = 0; i < SeparatedNumbers.Count; i++)
//                    {
//                        SeparatedNumbers[i][1] = Math.Floor(Math.Log(baseNumber, SeparatedNumbers[i][0])* SeparatedNumbers[i][1]);
//                        SeparatedNumbers[i][0] = baseNumber;
//                    }
//                    int counter2 = 0;
//                    double maxValue = 0;
//                    int answer = 0;
//                    foreach (var item in SeparatedNumbers)
//                    {
//                        counter2++;
//                        if (item[1]>maxValue)
//                        {
//                            maxValue = item[1];
//                            answer = counter2;
//                        }
//                    }
//                    Console.WriteLine("---------");
//                    int counter3 = 0;
//                    foreach (var item in SeparatedNumbers)
//                    {
//                        counter3++;
//                        Console.WriteLine(item[0] + " " + item[1] + " " + counter3);
//                    }
//                    SeparatedNumbers.Sort( (x,y) => x[1].CompareTo(y[1]));
//                    Console.WriteLine("--------------------------");
//                    foreach (var item in SeparatedNumbers)
//                    {
//                        Console.WriteLine(item[0]);
//                        Console.WriteLine(item[1]);
//                    }
//                Console.WriteLine(answer);
//                }

//            }
//            catch (IOException e)
//            {
//                Console.WriteLine("The file could not be read:");
//                Console.WriteLine(e.Message);
//            }

//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Numerics;
using System.Reflection;

namespace euler
{
    class Problem099
    {

        public static void Main(string[] args)
        {
            List<double[]> NumbersAndExponencial = GetNumbersAndExponencial();
            List<double> Values = LogarithmNumbersAndExponencials(NumbersAndExponencial);
            int MaxValueIndex = SearchForLineWithBiggestValue(Values);
            Console.WriteLine(MaxValueIndex);
        }

        public static List<double[]> GetNumbersAndExponencial()
        {
            string numbers = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory.ToString(), "..", "..", "p099_base_exp.txt"));
            string[] SplitNumbers = numbers.Split(',', '\n');
            List<double[]> NumbersAndExponencial = new List<double[]>();
            for (int i = 0; i < SplitNumbers.Length; i += 2)
            {
                NumbersAndExponencial.Add(new double[2] { Double.Parse(SplitNumbers[i]), Double.Parse(SplitNumbers[i + 1]) });
            }
            return NumbersAndExponencial;
        }

        public static List<double> LogarithmNumbersAndExponencials(List<double[]> NumbersAndExponencials)
        {
            List<double> Values = new List<double>();
            foreach (var item in NumbersAndExponencials)
            {
                Values.Add(item[1] * Math.Log10(item[0]));
            }
            return Values;
        }

        public static int SearchForLineWithBiggestValue(List<double> Numbers)
        {
            double maxValue = 0;
            int maxValueIndex = 0;
            for (int i = 0; i < Numbers.Count; i++)
            {
                if (Numbers[i]>maxValue)
                {
                    maxValue = Numbers[i];
                    maxValueIndex = i+1;
                }
            }
            return maxValueIndex;
        }
    }
}
