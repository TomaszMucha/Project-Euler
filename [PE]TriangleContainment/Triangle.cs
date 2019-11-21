using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PE_TriangleContainment
{
    class Triangle
    {
        public Point P1 { get; set; }
        public Point P2 { get; set; }
        public Point P3 { get; set; }
        public double Field { get; set; }

        public Triangle(Point p1, Point p2, Point p3)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;

            Field = 0.5 * Math.Abs((P2.X-P1.X)*(P3.Y-P1.Y)-(P2.Y-P1.Y)*(P3.X-P1.X));
        }
    }
}
