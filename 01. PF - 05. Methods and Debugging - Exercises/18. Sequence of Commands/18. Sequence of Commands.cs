using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Sequence_of_Commands
{
    class Program
    {
        private const char ArgumentsDelimiter = ' ';

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

            string command = "";

            while (!command.Equals("stop"))
            {
                command = Console.ReadLine();
                string line = command.Trim();
                int[] args = new int[2];
                string[] stringParams = line.Split(ArgumentsDelimiter);
                command = stringParams[0];
                if (command.Equals("add") ||
                    command.Equals("subtract") ||
                    command.Equals("multiply"))
                {
                    args[0] = int.Parse(stringParams[1]);
                    args[1] = int.Parse(stringParams[2]);

                    PerformAction(array, command, args);
                }
                else
                {
                    PerformAction(array, command, args);
                }

                if (!command.Equals("stop"))
                {
                    PrintArray(array);
                    Console.WriteLine();
                }
            }
        }

        static void PerformAction(long[] arr, string action, int[] args)
        {
            long[] array = arr.Clone() as long[];
            int pos = args[0];
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    arr[pos-1] *= value;
                    break;
                case "add":
                    arr[pos-1] += value;
                    break;
                case "subtract":
                    arr[pos-1] -= value;
                    break;
                case "lshift":
                    ArrayShiftLeft(arr);
                    break;
                case "rshift":
                    ArrayShiftRight(arr);
                    break;
            }
        }

        private static void ArrayShiftRight(long[] array)
        {
            long lastArray = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
                if (i==1)
                {
                    array[0] = lastArray;
                }
            }
        }

        private static void ArrayShiftLeft(long[] array)
        {
            long firstArray = array[0];
            for (int i = 0; i < array.Length-1; i++)
            {
                array[i] = array[i + 1];
                if (i == array.Length-2)
                {
                    array[array.Length - 1] = firstArray;
                }
            }
        }

        private static void PrintArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}