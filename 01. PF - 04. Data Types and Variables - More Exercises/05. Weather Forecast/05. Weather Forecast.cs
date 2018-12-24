using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Weather_Forecast
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());
            if (number != Math.Round(number, 0))
            {
                Console.WriteLine("Rainy");
            }
            else if (sbyte.MinValue<=number&&number<=sbyte.MaxValue)
            {
                Console.WriteLine("Sunny");
            }
            else if (int.MinValue <= number && number <= int.MaxValue)
            {
                Console.WriteLine("Cloudy");
            }
            else if (long.MinValue <= number && number <= long.MaxValue)
            {
                Console.WriteLine("Windy");
            }
        }
    }
}
