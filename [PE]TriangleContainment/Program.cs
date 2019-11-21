using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PE_TriangleContainment
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "p102_triangles.txt"));
            Console.WriteLine(NumberOfTriangleContainingOrgin(GetAllTriangle(sr)));
        }

        public static bool IsContainOrgin(Triangle T)
        {
            List<Triangle> TriangleList = GenerateSubTriangle(T);
            double SubTriangleFieldSum = 0;
            foreach (var triangle in TriangleList)
            {
                SubTriangleFieldSum += triangle.Field;
            }
            return SubTriangleFieldSum == T.Field;
        }

        public static List<Triangle> GenerateSubTriangle(Triangle T)
        {
            List<Triangle> TriangleList = new List<Triangle>();
            TriangleList.Add(new Triangle(T.P1, T.P2, new Point(0, 0)));
            TriangleList.Add(new Triangle(T.P2, T.P3, new Point(0, 0)));
            TriangleList.Add(new Triangle(T.P3, T.P1, new Point(0, 0)));
            return TriangleList;
        }

        public static List<Triangle> GetAllTriangle(StreamReader sr)
        {
            string text = sr.ReadToEnd();
            string[] Coordinates = text.Split(new[] { "\r\n", "\n", "," }, StringSplitOptions.None);
            
            List<Triangle> Triangles = new List<Triangle>();
            for (int i = 0; i < Coordinates.Length-1; i+=6)
            {
                Triangles.Add(new Triangle(new Point(Double.Parse(Coordinates[i]), Double.Parse(Coordinates[i+1])), 
                                           new Point(Double.Parse(Coordinates[i+2]), Double.Parse(Coordinates[i+3])), 
                                           new Point(Double.Parse(Coordinates[i+4]), Double.Parse(Coordinates[i+5]))));
            }
            return Triangles;
        }

        public static int NumberOfTriangleContainingOrgin(List<Triangle> Triangles)
        {
            int answer = 0;
            foreach (var triangle in Triangles)
            {
                if (IsContainOrgin(triangle))
                {
                    answer++;
                }
            }
            return answer;
        }
    }
}
