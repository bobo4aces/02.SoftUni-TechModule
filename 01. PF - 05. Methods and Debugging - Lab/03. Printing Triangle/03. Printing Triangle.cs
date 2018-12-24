using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Printing_Triangle
{
    class Program
    {
        static void PrintLine(int start,int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }

        static void PrintTopTriangle(int number)
        {
            for (int i = 1; i < number; i++)
            {
                PrintLine(1,i);
            }
        }

        static void PrintBottomTriangle(int number)
        {
            for (int i = number-1; i >= 1; i--)
            {
                PrintLine(1, i);
            }
        }

        static void Main(string[] args)
        {
            int number=int.Parse(Console.ReadLine());
            PrintTopTriangle(number);
            PrintLine(1,number);
            PrintBottomTriangle(number);
        }
    }
}
