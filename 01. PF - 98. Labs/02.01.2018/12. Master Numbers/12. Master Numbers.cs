using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Master_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int currentNumber = 1; currentNumber <= number; currentNumber++)
            {
                if (IsSymetric(currentNumber) && (SumOfDigits(currentNumber) % 7 == 0) && ContainsEvenDigit(currentNumber))
                {
                    Console.WriteLine(currentNumber);
                }
                Console.WriteLine(currentNumber);
            }
        }

        static bool IsSymetric(int number)
        {
            string currentNumber = number.ToString();
            int counter = 0;
            for (int i = currentNumber.Length - 1; i >= 0; i--)
            {
                if (currentNumber[i] != currentNumber[counter])
                {
                    return false;
                }
                counter++;
            }
            return true;
        }

        static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;
            }
            return sum;
        }

        static bool ContainsEvenDigit(int number)
        {
            while (number != 0)
            {
                int digit = number % 10;
                if (digit % 2 == 0)
                {
                    return true;
                }
                number /= 10;
            }
            return false;
        }
    }
}
