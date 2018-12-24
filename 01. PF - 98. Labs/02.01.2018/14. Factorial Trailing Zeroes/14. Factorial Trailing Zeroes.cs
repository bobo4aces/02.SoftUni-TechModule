using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _14.Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            BigInteger factorial = CalculateFactorial(number);
            Console.WriteLine(CalculateTrailingZeros(factorial));
        }

        static BigInteger CalculateFactorial(BigInteger number)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        static int CalculateTrailingZeros(BigInteger number)
        {
            int counter = 0;
            while (number!=0)
            {
                BigInteger digit = number % 10;
                if (digit==0)
                {
                    counter++;
                }
                else
                {
                    break;
                }
                number /= 10;
            }

            return counter;   
        }
    }
}
