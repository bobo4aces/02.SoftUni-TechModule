using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Geometry_Calculator
{
    class Program
    {
        static double GetTriangleArea(double side, double height)
        {
            double triangleArea = 0.5 * (side * height);
            return triangleArea;
        }

        static double GetSquareArea(double side)
        {
            double squareArea = Math.Pow(side,2);
            return squareArea;
        }

        static double GetRectangleArea(double width, double height)
        {
            double rectangleArea = width* height;
            return rectangleArea;
        }

        static double GetCircleArea(double radius)
        {
            double circleArea = Math.PI*Math.Pow(radius, 2);
            return circleArea;
        }

        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();

            double side = 0;
            double height = 0;
            double width = 0;
            double radius = 0;

            switch (figureType)
            {
                case "triangle":
                    side = double.Parse(Console.ReadLine());
                    height = double.Parse(Console.ReadLine());
                    double triangleArea = GetTriangleArea(side, height);
                    Console.WriteLine($"{triangleArea:f2}");
                    break;
                case "square":
                    side = double.Parse(Console.ReadLine());
                    double squareArea = GetSquareArea(side);
                    Console.WriteLine($"{squareArea:f2}");
                    break;
                case "rectangle":
                    width = double.Parse(Console.ReadLine());
                    height = double.Parse(Console.ReadLine());
                    double rectangleArea = GetRectangleArea(width, height);
                    Console.WriteLine($"{rectangleArea:f2}");
                    break;
                case "circle":
                    radius = double.Parse(Console.ReadLine());
                    double circleArea = GetCircleArea(radius);
                    Console.WriteLine($"{circleArea:f2}");
                    break;
                default:
                    break;
            }
        }
    }
}
