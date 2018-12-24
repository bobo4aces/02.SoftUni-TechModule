using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30.Travel_at_Light_Speed
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal lightYear= 9450000000000;
            decimal lightSpeedKmPerSecond = 300000;
            decimal lightYearsCount = decimal.Parse(Console.ReadLine());
            decimal totalKm = lightYearsCount * lightYear;
            decimal totalSeconds = totalKm / lightSpeedKmPerSecond;
            decimal weeks = totalSeconds / (3600 * 24 * 7);
            decimal days = (totalSeconds / (3600 * 24))%7;
            decimal hours = (totalSeconds/3600)%24;
            decimal minutes = (totalSeconds/60)%60;
            decimal seconds = totalSeconds %60;
            Console.WriteLine($"{Math.Floor(weeks)} weeks");
            Console.WriteLine($"{Math.Floor(days)} days");
            Console.WriteLine($"{Math.Floor(hours)} hours");
            Console.WriteLine($"{Math.Floor(minutes)} minutes");
            Console.WriteLine($"{Math.Floor(seconds)} seconds");
        }
    }
}
