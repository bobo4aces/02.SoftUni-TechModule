using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Wormtest
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthInMeters = int.Parse(Console.ReadLine());
            double widthInCentimeters = double.Parse(Console.ReadLine());
            int lengthInCentimeters = lengthInMeters * 100;
            double remainder = lengthInCentimeters % widthInCentimeters;
            if (remainder==0||lengthInMeters==0||widthInCentimeters==0)
            {
                Console.WriteLine($"{(lengthInCentimeters*widthInCentimeters):f2}");
            }
            else
            {
                Console.WriteLine($"{((lengthInCentimeters / widthInCentimeters)*100):f2}%");

            }
        }
    }
}
