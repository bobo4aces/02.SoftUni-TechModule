using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Integer_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number1 = byte.Parse(Console.ReadLine());
            uint number2 = uint.Parse(Console.ReadLine());
            long number3 = long.Parse(Console.ReadLine());
            decimal number4 = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"{number1} {number2} {number3} {number4}");
        }
    }
}
