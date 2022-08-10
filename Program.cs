using System;

namespace ArchitectArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RectangleArea(4,5));
            Console.WriteLine(CircleArea(4));
            Console.WriteLine(TriangleArea(10,9));
        }

        static double RectangleArea( double length, double width)
        {
            return length * width;
        }

        static double CircleArea(double radius)
        {
            double pi = Math.PI;
            return pi * Math.Pow(radius, 2);
        }

        static double TriangleArea(double bottom, double height)
        {
            return .5 * bottom * height;
        }
    }
}
