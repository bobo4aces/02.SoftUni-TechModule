using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Master_Number
{
    class Program
    {
        static bool isPalindromeNumber(int number)
        {
            bool isPalindromeNumber = false;
            string numberAsText = number.ToString();
            if (numberAsText.Length==1)
            {
                return false;
            }
            int startNumber = 0;
            int endNumber = numberAsText.Length-1;
            while (startNumber<= endNumber&&endNumber>=startNumber)
            {
                if (numberAsText[startNumber]==numberAsText[endNumber])
                {
                    isPalindromeNumber = true;
                }
                else
                {
                    return false;
                }
                startNumber++;
                endNumber--;
            }
            
            return isPalindromeNumber;
        }

        static bool isDivisibleBySeven(int number)
        {
            int digitSum = 0;
            while (number > 0)
            {
                int currentNumber = number % 10;
                digitSum += currentNumber;
                number = number / 10;
            }
            if (digitSum % 7==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool isHoldingOneEvenDigit(int number)
        {
            while (number>0)
            {
                int currentNumber = number % 10;
                if (currentNumber%2==0)
                {
                    return true;
                }
                else
                {
                    number = number / 10;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (isPalindromeNumber(i)&&isDivisibleBySeven(i)&&isHoldingOneEvenDigit(i))
                {
                    Console.WriteLine($"{i}");
                }
            }
        }
    }
}
