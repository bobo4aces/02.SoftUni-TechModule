using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _14.Factorial_Trailing_Zero
{
    class Program
    {
        static BigInteger GetFactorial(int number)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        static int GetTrailingZerosCount(BigInteger factoral)
        {
            int trailingZerosCount = 0;
            while (true)
            {
                BigInteger lastNumber =factoral % 10;
                if (lastNumber!=0)
                {
                    return trailingZerosCount;
                }
                trailingZerosCount++;
                factoral = factoral / 10;
            }
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger factoral=GetFactorial(number);
            int trailingZerosCount = GetTrailingZerosCount(factoral);
            Console.WriteLine(trailingZerosCount);
        }
    }
}
