using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Prime_Checker
{
    class Program
    {
        static bool GetIsPrime(long number)
        {
            bool isPrime = true;
            if (number == 0||number==1)
            {
                isPrime = false;
            }
            for (long i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number%i==0)
                {
                    isPrime = false;
                    return isPrime;
                }
            }
            return isPrime;
        }
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(GetIsPrime(number));
        }
    }
}
