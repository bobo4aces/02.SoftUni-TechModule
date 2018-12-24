using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Real_Number_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            byte countOfDigitsAfterDecimalPoint = byte.Parse(Console.ReadLine());
            decimal number = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"{Math.Round(number,countOfDigitsAfterDecimalPoint)}");
        }
    }
}
