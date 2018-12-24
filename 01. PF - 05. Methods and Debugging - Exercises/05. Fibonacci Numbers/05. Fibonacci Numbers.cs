using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fibonacci_Numbers
{
    class Program
    {
        static int GetFibonacciNumber(int number)
        {
            int f0 = 1;
            int f1 = 1;
            int fibonacciNumber = 1;
            if (number>=2)
            {
                for (int i = 2; i <= number; i++)
                {
                    fibonacciNumber = f0 + f1;
                    f1 = f0;
                    f0 = fibonacciNumber;
                }
            }
            return fibonacciNumber;
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(GetFibonacciNumber(number));
        }
    }
}
