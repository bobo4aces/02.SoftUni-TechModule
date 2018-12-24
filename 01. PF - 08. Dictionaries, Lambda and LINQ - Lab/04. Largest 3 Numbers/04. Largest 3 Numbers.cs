using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            List<double> result = new List<double>();
            result.AddRange(numbers.OrderByDescending(x => x).Take(3));
            Console.WriteLine(string.Join(" ", result)); 
        }
    }
}
