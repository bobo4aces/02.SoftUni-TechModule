using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _29.From_Terabytes_to_Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal terabyte = decimal.Parse(Console.ReadLine());
            decimal bits = terabyte * (1024M * 1024M * 1024M * 1024M * 8M);
            Console.WriteLine($"{bits:f0}");
        }
    }
}
