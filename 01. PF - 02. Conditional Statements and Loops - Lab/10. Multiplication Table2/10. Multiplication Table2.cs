using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Multiplication_Table2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int startingMultiplier = int.Parse(Console.ReadLine());
            for (int i = startingMultiplier; i <= 10; i++)
            {
                Console.WriteLine($"{number} X {i} = {number * i}");
            }
            if (startingMultiplier>=11)
            {
                Console.WriteLine($"{number} X {startingMultiplier} = {number * startingMultiplier}");
            }
        }
    }
}
