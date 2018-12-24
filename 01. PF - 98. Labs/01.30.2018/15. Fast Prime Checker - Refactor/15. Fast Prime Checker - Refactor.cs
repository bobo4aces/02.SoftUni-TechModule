using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Fast_Prime_Checker___Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            for (int currentNumber = 2; currentNumber <= numbersCount; currentNumber++)
            {
                bool isPrime = true;
                for (int deviser = 2; deviser <= Math.Sqrt(currentNumber); deviser++)
                {
                    if (currentNumber % deviser == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{currentNumber} -> {isPrime}");
            }

        }
    }
}
