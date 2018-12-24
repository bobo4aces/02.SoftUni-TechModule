using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstSeries = int.Parse(Console.ReadLine());
            int secondSeries = int.Parse(Console.ReadLine());
            int thirdSeries = int.Parse(Console.ReadLine());
            int forthSeries = int.Parse(Console.ReadLine());
            Console.WriteLine($"{firstSeries:D4} {secondSeries:d4} {thirdSeries:D4} {forthSeries:D4}");
        }
    }
}
