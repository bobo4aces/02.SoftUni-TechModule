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
            string firstNumberAsText = Console.ReadLine();
            string secondNumberAsText = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            int maxLenght = Math.Max(firstNumberAsText.Length, secondNumberAsText.Length);
            int minLenght = Math.Min(firstNumberAsText.Length, secondNumberAsText.Length);
            int count = 0;
            for (int j = minLenght - 1; j >= 0; j--)
            {
                int firstNumber = int.Parse(firstNumberAsText[j].ToString());
                int secondNumber = int.Parse(secondNumberAsText[j].ToString());
                
                if (firstNumber+secondNumber+count>=10)
                {
                    result = result.Append((firstNumber + secondNumber) - 10);
                    count++;
                }
                else
                {
                    result = result.Append(firstNumber + secondNumber + count);
                    count = 0;
                }
            }
            if (maxLenght==minLenght&&count>1)
            {
                result = result.Append(count);
            }
            for (int i = maxLenght - 1; i > minLenght; i--)
            {
                if (firstNumberAsText.Length >= maxLenght)
                {
                    result = result.Append(int.Parse(firstNumberAsText[i].ToString())+count);
                }
                if (secondNumberAsText.Length >= maxLenght)
                {
                    result = result.Append(int.Parse(secondNumberAsText[i].ToString()) + count);
                }
            }
            Console.WriteLine(string.Concat(result.ToString().Reverse()));
        }
    }
}
