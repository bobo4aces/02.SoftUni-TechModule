using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Primes_in_Given_Range
{
    class Program
    {
        static bool GetIsPrime(long number)
        {
            bool isPrime = true;
            if (number == 0 || number == 1)
            {
                isPrime = false;
            }
            for (long i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    return isPrime;
                }
            }
            return isPrime;
        }

        static List<int> FindPrimesInRange(int startNumber, int lastNumber)
        {
            List<int> primeNumbers = new List<int>();
            for (int i = startNumber; i <= lastNumber; i++)
            {
                if (GetIsPrime(i))
                {
                    primeNumbers.Add(i);
                }
            }
            return primeNumbers;
        }

        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int lastNumber = int.Parse(Console.ReadLine());
            List<int> primeNumbers = new List<int>(FindPrimesInRange(startNumber, lastNumber));
            Console.WriteLine(string.Join(", ",primeNumbers));
        }
    }
}
