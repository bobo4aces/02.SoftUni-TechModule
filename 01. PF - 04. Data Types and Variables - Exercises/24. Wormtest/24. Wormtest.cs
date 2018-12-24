using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.Wormtest
{
    class Program
    {
        static void Main(string[] args)
        {
            int wormLengthInMeters = int.Parse(Console.ReadLine());
            double wormWidthInCentimeters = double.Parse(Console.ReadLine());
            int wormLengthInCentimeters = wormLengthInMeters * 100;
            if (wormLengthInCentimeters% wormWidthInCentimeters==0||wormLengthInMeters==0||wormWidthInCentimeters==0)
            {
                Console.WriteLine($"{(wormLengthInCentimeters * wormWidthInCentimeters):f2}");
            }
            else
            {
                Console.WriteLine($"{((wormLengthInCentimeters/wormWidthInCentimeters)*100):f2}%");
            }
        }
    }
}
