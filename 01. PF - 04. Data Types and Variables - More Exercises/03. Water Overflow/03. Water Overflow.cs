using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());
            int capacity = 255;
            int quantity = 0;
            int currentQuanity = 0;
            for (int i = 0; i < linesCount; i++)
            {
                quantity = int.Parse(Console.ReadLine());
                if (currentQuanity+ quantity<= capacity)
                {
                    currentQuanity += quantity;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(currentQuanity);
        }
    }
}
