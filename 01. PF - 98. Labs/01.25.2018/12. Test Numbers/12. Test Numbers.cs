using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());

            int sum = 0;

            int counter = 0;

            bool isFound = false;

            for (int i = firstNumber; i >= 1; i--)
            {
                if (isFound)
                {
                    break;
                }
                for (int j = 1; j <= secondNumber; j++)
                {
                    counter++;
                    int currentNumber = (i * j) * 3;
                    sum += currentNumber;

                    if (sum>=maxSum)
                    {
                        Console.WriteLine($"{counter} combinations");
                        Console.WriteLine($"Sum: {sum} >= {maxSum}");
                        isFound = true;
                        break;
                    }
                }
            }
            if (!isFound)
            {
                Console.WriteLine($"{counter} combinations");
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}
