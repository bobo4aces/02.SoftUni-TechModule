using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Draw_a_Filled_Square
{
    class Program
    {
        static void PrintTopOrBottomLines(int number)
        {
            Console.WriteLine(new string('-',2* number));
        }
        static void PrintMiddleLines(int number)
        {
            Console.Write("-");
            for (int i = 0; i < number-1; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintTopOrBottomLines(number);
            for (int i = 0; i < number-2; i++)
            {
                PrintMiddleLines(number);
            }
            PrintTopOrBottomLines(number);
        }
    }
}
