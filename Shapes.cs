using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentInheritance
{
    internal class Shapes
    {
        static double Area(int side)
        {
            return side * side;
        }

        static double Area(int l, int b)
        {
            return l * b;
        }

        static double Area(double radius)
        {
            return 3.14 * radius * radius;
        }

        static double Area(double l,double h)
        {
            return .5*l*h;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Area of Square = " + Shapes.Area(5));
            Console.WriteLine("Area of Rectangle = " + Shapes.Area(5,2));
            Console.WriteLine("Area of Circle = " + Shapes.Area(5.2));
            Console.WriteLine("Area of Triangle = " + Shapes.Area(5.0,2.0));
        }
    }
}
