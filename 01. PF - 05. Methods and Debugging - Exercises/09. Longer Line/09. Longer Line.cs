using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Longer_Line
{
    class Program
    {
        static double GetDistance(double x1, double x2, double y1, double y2)
        {
            double distance = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2));
            return distance;
        }
        static bool GetClosestPoints(double x1, double x2, double y1, double y2)
        {
            double firstClosestPoint = Math.Sqrt(Math.Pow(x1, 2)) + Math.Sqrt(Math.Pow(y1, 2));
            double secondClosestPoint = Math.Sqrt(Math.Pow(x2, 2)) + Math.Sqrt(Math.Pow(y2, 2));
            if (firstClosestPoint>secondClosestPoint)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());
            double firstLineDistance = GetDistance(x1, x2, y1, y2);
            double secondLineDistance = GetDistance(x3, x4, y3, y4);
            string formattedOutput = "({0}, {1})({2}, {3})";
            if (firstLineDistance>= secondLineDistance)
            {
                if (GetClosestPoints(x1,x2,y1,y2))
                {
                    Console.WriteLine(formattedOutput,x1, y1, x2, y2);
                }
                else
                {
                    Console.WriteLine(formattedOutput, x2, y2, x1, y1);
                }
            }
            else
            {
                if (GetClosestPoints(x3, x4, y3, y4))
                {
                    Console.WriteLine(formattedOutput, x3, y3, x4, y4);
                }
                else
                {
                    Console.WriteLine(formattedOutput, x4, y4, x3, y3);
                }
            }
        }
    }
}
