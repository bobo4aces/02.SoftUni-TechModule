using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            int shortestArrayLength = Math.Min(firstArray.Length, secondArray.Length) - 1;
            bool isItFirst = false;
            for (int i = 0; i <= shortestArrayLength; i++)
            {
                if (firstArray[i] <= secondArray[i])
                {
                    isItFirst = true;
                }
                else
                {
                    isItFirst = false;
                    break;
                }
            }
            if (isItFirst&& firstArray.Length == shortestArrayLength + 1)
            {
                Console.WriteLine(firstArray);
                Console.WriteLine(secondArray);
            }
            else
            {
                Console.WriteLine(secondArray);
                Console.WriteLine(firstArray);
            }
        }
    }
}
