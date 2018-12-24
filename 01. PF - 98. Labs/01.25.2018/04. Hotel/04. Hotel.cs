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
            string month = Console.ReadLine();
            int nightsCount= int.Parse(Console.ReadLine());

            decimal studioPrice = 0m;
            decimal doublePrice = 0m;
            decimal suitePrice = 0m;

            int nightsCountOfStudio = 0;

            if ((month=="September"||month=="October")&&nightsCount>7)
            {
                nightsCount--;
            }

            if (month=="May"||month=="October")
            {
                doublePrice = 65m * nightsCount;
                suitePrice = 75m * nightsCount;
                if (nightsCount>7)
                {
                    studioPrice = (50m * 0.95m)* nightsCountOfStudio;
                }
                else
                {
                    studioPrice = 50m * nightsCountOfStudio;
                }
            }
            else if (month=="June"||month=="September")
            {
                studioPrice = 60m * nightsCountOfStudio;
                suitePrice = 82m * nightsCount;
                if (nightsCount>14)
                {
                    doublePrice = (72m * 0.90m)*nightsCount;
                }
                else
                {
                    doublePrice = 72m * nightsCount;
                }
            }
            else if (month=="July"||month=="August"||month=="December")
            {
                if (nightsCount>14)
                {
                    suitePrice = (89m * 0.85m) * nightsCount;
                }
                else
                {
                    suitePrice = 89m * nightsCount;
                }
                studioPrice = 68m * nightsCount;
                doublePrice = 77m * nightsCount;
            }
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
            Console.WriteLine($"Double: {doublePrice:f2} lv.");
            Console.WriteLine($"Suite: {suitePrice:f2} lv.");
        }
    }
}
