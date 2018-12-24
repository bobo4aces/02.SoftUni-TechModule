using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double distancePer1000WingFlaps = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());
            double metersTraveled = (wingFlaps / 1000) * distancePer1000WingFlaps;
            int totalSecondsForFlapping = wingFlaps / 100;
            int totalSecondsForResting = (wingFlaps / endurance) * 5;
            int secondsPassed = totalSecondsForFlapping + totalSecondsForResting;
            Console.WriteLine($"{metersTraveled:f2} m.");
            Console.WriteLine($"{secondsPassed} s.");
        }
    }
}
