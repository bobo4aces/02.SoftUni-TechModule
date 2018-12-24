using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Circle_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double raduis = double.Parse(Console.ReadLine());
            double circlePerimeter = 2 * Math.PI * raduis;
            Console.WriteLine($"{circlePerimeter:f12}");
        }
    }
}
