using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int nightsCount = int.Parse(Console.ReadLine());
            double studioPrice = 0;
            double doublePrice = 0;
            double suitePrice = 0;
            if (month=="may"||month== "october")
            {
                studioPrice = nightsCount*50.0;
                doublePrice = nightsCount * 65.0;
                suitePrice = nightsCount * 75.0;
                if (nightsCount >= 8 && month == "october")
                {
                    studioPrice = studioPrice - 50.0;
                }
                if (nightsCount>=8)
                {
                    studioPrice = studioPrice -(studioPrice * 0.05);
                }
                
            }
            else if (month == "june" || month == "september")
            {
                studioPrice = nightsCount * 60.0;
                doublePrice = nightsCount * 72.0;
                suitePrice = nightsCount * 82.0;
                if (nightsCount >= 8 && month == "september")
                {
                    studioPrice = studioPrice - 60.0;
                }
                if (nightsCount >= 15)
                {
                    doublePrice = doublePrice - (doublePrice * 0.10);   
                }
                
            }
            else if (month == "july" || month == "august" || month == "december")
            {
                studioPrice = nightsCount * 68.0;
                doublePrice = nightsCount * 77.0;
                suitePrice = nightsCount * 89.0;
                if (nightsCount >= 15)
                {
                    suitePrice = suitePrice - (suitePrice * 0.15);
                }
            }
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
            Console.WriteLine($"Double: {doublePrice:f2} lv.");
            Console.WriteLine($"Suite: {suitePrice:f2} lv.");
        }
    }
}
