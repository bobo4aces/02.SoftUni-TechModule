using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine();
            string secondNumber = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            int reminder = 0;
            int firstNumberLength = firstNumber.Length-1;
            int secondNumberLength = secondNumber.Length-1;
            while (firstNumberLength >=0|| secondNumberLength >= 0)
            {
                int currentDigitFirstNumber = 0;
                int currentDigitSecondNumber = 0;
                if (firstNumberLength>=0)
                {
                    currentDigitFirstNumber = int.Parse(firstNumber[firstNumberLength--].ToString());
                }
                if (secondNumberLength>=0)
                {
                    currentDigitSecondNumber = int.Parse(secondNumber[secondNumberLength--].ToString());
                }
                int currentResult = currentDigitFirstNumber + currentDigitSecondNumber + reminder;
                sb.Append(currentResult % 10);
                reminder = currentResult / 10;
            }
            sb.Append(reminder);
            Console.WriteLine(string.Concat(sb.ToString().TrimEnd('0').Reverse()));
        }
    }
}
