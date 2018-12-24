using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Circles_Intersection
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        // constructor
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        //(static)Point.someMethod
        public static int CalculateDistanceBetweenTwoPoints(Point p1,Point p2)
        {
            return (int)Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
        }
    }

    class Circle
    {
        public int Radius { get; set; }
        public Point Center { get; set; }

        public Circle(Point center,int radius)
        {
            Center = center;
            Radius = radius;
        }

        public static bool Intersect(Circle c1,Circle c2)
        {
            int distance = Point.CalculateDistanceBetweenTwoPoints(c1.Center, c2.Center);
            if (distance<=c1.Radius+c2.Radius)
            {
                return true;
            }
            return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] firstCircleCoordinate = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondCircleCoordinate = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Point firstPoint = new Point(firstCircleCoordinate[0], firstCircleCoordinate[1]);
            Point secondPoint = new Point(secondCircleCoordinate[0], secondCircleCoordinate[1]);

            Circle firstCircle = new Circle(firstPoint, firstCircleCoordinate[2]);
            Circle secondCircle = new Circle(secondPoint, secondCircleCoordinate[2]);

            //Console.WriteLine(Circle.Intersect(firstCircle, secondCircle) ? "Yes" : "No");

            if (Circle.Intersect(firstCircle,secondCircle))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");

            }
        }
    }
}
