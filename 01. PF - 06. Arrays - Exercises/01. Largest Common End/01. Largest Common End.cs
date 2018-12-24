using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Largest_Common_End
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ').ToArray();
            string[] secondArray = Console.ReadLine().Split(' ').ToArray();
            int shortestArrayLength = Math.Min(firstArray.Length, secondArray.Length);
            int forwardCounter = 0;
            int backwardCounter = 0;
            for (int i = 0; i < shortestArrayLength; i++)
            {
                if (firstArray[i]==secondArray[i])
                {
                    forwardCounter++;
                }
                else
                {
                    break;
                }
            }
            for (int i = 0; i < shortestArrayLength; i++)
            {
                if (firstArray[(firstArray.Length - 1) -i] == secondArray[(secondArray.Length-1) - i])
                {
                    backwardCounter++;
                }
                else
                {
                    break;
                }
            }
            if (forwardCounter> backwardCounter)
            {
                Console.WriteLine(forwardCounter);
            }
            else
            {
                Console.WriteLine(backwardCounter);
            }
        }
    }
}
