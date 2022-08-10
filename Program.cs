using System;

namespace ArchitectArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            double triangleArea = TriangleArea(500, 750);
            double squareArea = RectangleArea(2500,1500);
            double circleArea = CircleArea(375)/2;

            double totalArea = triangleArea + squareArea + circleArea;
            double flooringCost = 180.00;
            
            double totalCost = totalArea * flooringCost;

            Console.WriteLine($"The total cost of flooring Teotihuacan is {Math.Round(totalCost)} pesos. Which has and area of {Math.Round(totalArea)} square feet at a cost of {flooringCost} per square meter.");

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
