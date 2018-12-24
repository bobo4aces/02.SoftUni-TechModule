using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _27.Distance_of_The_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal lightYear = 9450000000000;
            decimal distanceToNearestStar = lightYear * 4.22M;
            decimal distanceToMilkyWay = lightYear * 26000;
            decimal MilkyWayDiameter = lightYear * 100000;
            decimal distanceToObservableUniverseEdge = lightYear * 46500000000;
            Console.WriteLine(distanceToNearestStar.ToString("0.00e+000"));
            Console.WriteLine(distanceToMilkyWay.ToString("0.00e+000"));
            Console.WriteLine(MilkyWayDiameter.ToString("0.00e+000"));
            Console.WriteLine(distanceToObservableUniverseEdge.ToString("0.00e+000"));
        }
    }
}
