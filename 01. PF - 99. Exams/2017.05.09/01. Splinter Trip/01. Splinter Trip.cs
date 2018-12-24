using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Splinter_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal tripDistanceInMiles = decimal.Parse(Console.ReadLine());
            decimal fuelTankCapacityInLiters = decimal.Parse(Console.ReadLine());
            decimal milesInHeavyWinds = decimal.Parse(Console.ReadLine());
            decimal totalFuelNeeded=((tripDistanceInMiles-milesInHeavyWinds)*25M+milesInHeavyWinds*25M*1.5M)*1.05M;
            Console.WriteLine($"Fuel needed: {totalFuelNeeded:f2}L");
            if (totalFuelNeeded<=fuelTankCapacityInLiters)
            {
                Console.WriteLine($"Enough with {(fuelTankCapacityInLiters- totalFuelNeeded):f2}L to spare!");
            }
            else
            {
                Console.WriteLine($"We need {Math.Abs(fuelTankCapacityInLiters - totalFuelNeeded):f2}L more fuel.");
            }
        }
    }
}
