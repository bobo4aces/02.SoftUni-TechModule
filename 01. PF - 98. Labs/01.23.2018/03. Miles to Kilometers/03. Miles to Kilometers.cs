using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());
            double kilometersPerMile = 1.60934;
            double kilometers = miles * kilometersPerMile;
            Console.WriteLine($"{kilometers:F2}");
        }
    }
}
