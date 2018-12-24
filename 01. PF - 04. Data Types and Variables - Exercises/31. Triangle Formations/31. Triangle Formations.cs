using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31.Triangle_Formations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a<b+c&&b<a+c&&c<a+b)
            {
                Console.WriteLine("Triangle is valid.");
            }
            else
            {
                Console.WriteLine("Invalid Triangle.");
                return;
            }
            if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
            {
                Console.WriteLine("Triangle has a right angle between sides a and b");
            }
            else if (Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2))
            {
                Console.WriteLine("Triangle has a right angle between sides a and c");
            }
            else if (Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2))
            {
                Console.WriteLine("Triangle has a right angle between sides b and c");
            }
            else if (a==b&&b==c&&c==a)
            {
                Console.WriteLine("Triangle has no right angles");
            }
        }
    }
}
