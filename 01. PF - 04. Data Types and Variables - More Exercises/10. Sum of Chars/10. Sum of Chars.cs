using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());
            int totalSum = 0;
            for (int i = 0; i < linesCount; i++)
            {
                char characters = char.Parse(Console.ReadLine());
                totalSum += (int)characters;
            }
            Console.WriteLine($"The sum equals: {totalSum}");
        }
    }
}
