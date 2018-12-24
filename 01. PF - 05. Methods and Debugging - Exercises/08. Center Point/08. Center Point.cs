using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Center_Point
{
    class Program
    {
        static string GetClosestPoints(decimal x1, decimal x2, decimal y1, decimal y2)
        {
            decimal closestXPoint = 0;
            decimal closestYPoint = 0;
            if (Math.Abs(x1)<=Math.Abs(x2)&& Math.Abs(y1) <= Math.Abs(y2))
            {
                closestXPoint = x1;
                closestYPoint = y1;
            }
            else
            {
                closestXPoint = x2;
                closestYPoint = y2;
            }
            string closestPoints = $"({closestXPoint}, {closestYPoint})";
            return closestPoints;
        }

        static void Main(string[] args)
        {
            decimal x1 = decimal.Parse(Console.ReadLine());//2
            decimal y1 = decimal.Parse(Console.ReadLine());//4
            decimal x2 = decimal.Parse(Console.ReadLine());//-1
            decimal y2 = decimal.Parse(Console.ReadLine());//2
            string closestPoints = GetClosestPoints(x1, x2, y1, y2);
            Console.WriteLine(closestPoints);
        }
    }
}
