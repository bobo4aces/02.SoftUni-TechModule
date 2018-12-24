using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} => ");
                array[i] = Math.Round(array[i], 0, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{array[i]}");
            }
        }
    }
}
