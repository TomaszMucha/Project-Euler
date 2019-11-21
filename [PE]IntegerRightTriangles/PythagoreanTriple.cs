using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PE_IntegerRightTriangles
{
    class PythagoreanTriple
    {
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }
        public bool IsPythagoreanTriple { get; set; }

        public PythagoreanTriple(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            IsPythagoreanTriple = a * a + b * b == c * c;
        }
    }
}
