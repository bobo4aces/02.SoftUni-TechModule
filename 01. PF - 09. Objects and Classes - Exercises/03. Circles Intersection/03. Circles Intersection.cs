using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Circles_Intersection
{
    /// <summary>
    /// WRONG
    /// </summary>

    public class Circle
    {
        public double Center { get; set; }
        public double Radius { get; set; }
    }

    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }

    class Program
    {
        static bool Intersect(Circle c1, Circle c2)
        {
            return (c1.Radius+c2.Radius
        }

        static double CalcDistance(Point p1, Point p2)
        {
            double distance = Math.Sqrt((p2.X - p1.X) * (p2.X - p1.X) + (p2.Y - p1.Y) * (p2.Y - p1.Y));
            return distance;
        }

        static Point ReadPoint(double[] input)
        {
            Point point = new Point();
            point.X = input[0];
            point.Y = input[1];
            return point;
        }

        static Circle ReadCircle(double[] input)
        {
            Circle circle = new Circle();
            circle.Radius = input[2];
            return circle;
        }

        static void Main(string[] args)
        {
            double[] firstInput = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] secondInput = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Point firstPoint = ReadPoint(firstInput);
            Point secondPoint = ReadPoint(secondInput);
            Circle firstCircle = ReadCircle(firstInput);
            Circle secondCircle = ReadCircle(secondInput);
            double distance = CalcDistance(firstPoint, secondPoint);
        }
    }
}
