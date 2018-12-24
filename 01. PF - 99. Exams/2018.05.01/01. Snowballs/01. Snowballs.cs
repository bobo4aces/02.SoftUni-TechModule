using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            long snowballsCount = long.Parse(Console.ReadLine());
            long snowballSnowMax = long.MinValue;
            long snowballTimeMax = long.MinValue;
            BigInteger snowballValueMax = long.MinValue;
            long snowballQualityMax = long.MinValue;
            for (int i = 0; i < snowballsCount; i++)
            {
                long snowballSnow = long.Parse(Console.ReadLine());
                long snowballTime = long.Parse(Console.ReadLine());
                long snowballQuality = long.Parse(Console.ReadLine());
                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), (int)snowballQuality);
                if (snowballValue >= snowballValueMax)
                {
                    snowballSnowMax = snowballSnow;
                    snowballTimeMax = snowballTime;
                    snowballValueMax = snowballValue;
                    snowballQualityMax = snowballQuality;
                }
            }
            Console.WriteLine($"{snowballSnowMax} : {snowballTimeMax} = {snowballValueMax} ({snowballQualityMax})");
        }
    }
}
