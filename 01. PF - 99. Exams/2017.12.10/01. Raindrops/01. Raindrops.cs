using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp232
{
    class Program
    {
        static void Main(string[] args)
        {
            int regionsNum = int.Parse(Console.ReadLine());
            decimal density = decimal.Parse(Console.ReadLine());

            decimal totalSum = 0M;

            for (int i = 0; i < regionsNum; i++)
            {
                string[] info = Console.ReadLine().Split(' ').ToArray();
                long raindropsCount = long.Parse(info[0]);
                int squareMeters = int.Parse(info[1]);

                decimal coef = raindropsCount / squareMeters;
                totalSum += (raindropsCount / (decimal)squareMeters);
            }

            if (density != 0)
            {
                totalSum = totalSum / density;
            }
            Console.WriteLine($"{totalSum:f3}");
        }
    }
}