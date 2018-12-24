using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _03.Eng_Name_of_Last_Digit
{
    class Program
    {
        static string GetDigitName(decimal number)
        {
            string numberAsText = number.ToString();
            char lastDigitAsChar = numberAsText.Last();
            string lastDigitResult = "";
            switch (lastDigitAsChar)
            {
                case '1':
                    lastDigitResult = "one";
                    break;
                case '2':
                    lastDigitResult = "two";
                    break;
                case '3':
                    lastDigitResult = "three";
                    break;
                case '4':
                    lastDigitResult = "four";
                    break;
                case '5':
                    lastDigitResult = "five";
                    break;
                case '6':
                    lastDigitResult = "six";
                    break;
                case '7':
                    lastDigitResult = "seven";
                    break;
                case '8':
                    lastDigitResult = "eight";
                    break;
                case '9':
                    lastDigitResult = "nine";
                    break;
                case '0':
                    lastDigitResult = "zero";
                    break;
                default:
                    break;
            }
            return lastDigitResult;
        }
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());
            Console.WriteLine(GetDigitName(number));
        }
    }
}
