using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assume 1 mile = 1609 meters.

            int distanceInMeters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            float timeInSeconds = hours * 3600 + minutes * 60 + seconds;
            float timeInHours = hours + (float)minutes / 60 + (float)seconds/3600;
            float metersPerSecond = distanceInMeters / timeInSeconds;
            float kilometersPerHour = (distanceInMeters/1000) / timeInHours;
            float miles = (float)distanceInMeters / 1609;
            float milesPerHour = miles / timeInHours;

            Console.WriteLine(metersPerSecond);
            Console.WriteLine(kilometersPerHour);
            Console.WriteLine(milesPerHour);
        }
    }
}
