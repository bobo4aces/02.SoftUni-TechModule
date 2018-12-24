﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int startIndex = 0;
            int currentLength = 1;
            int maxStart = 0;
            int maxLength = 1;

            for (int index = 1; index < numbers.Length; index++)
            {
                if (numbers[index] == numbers[index - 1])
                {
                    currentLength++;
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        maxStart = startIndex;
                    }
                }
                else
                {
                    currentLength = 1;
                    startIndex = index;
                }
            }

            for (int index = maxStart; index < maxStart + maxLength; index++)
            {
                Console.Write(numbers[index] + " ");
            }
        }
    }
}
