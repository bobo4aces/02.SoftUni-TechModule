using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rotate_and_Sum
{
    class Program
    {
        static int[] GetReversedArrayByPosition(int[] array, int position=1)
        {
            int arrayElementsCount = array.Length - 1;
            int[] reversedArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (i > arrayElementsCount - position)
                {
                    reversedArray[--position] = array[i];
                }
                else
                {
                    reversedArray[i + position] = array[i];
                }
            }
            return reversedArray;
        }

        static int[] GetArrayElementsSum(int[] firstArray, int[] secondArray)
        {
            //For Arrays With Equal Length
            int[] sumArray = new int[firstArray.Length];
            for (int i = 0; i < firstArray.Length; i++)
            {
                sumArray[i] += firstArray[i] + secondArray[i];
            }
            return sumArray;
        }

        static void Main(string[] args)
        {
            int[] integerArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            int[] sumArray = new int[integerArray.Length];
            for (int i = 0; i < k; i++)
            {

                int[] reversedArray = GetReversedArrayByPosition(integerArray);
                sumArray = GetArrayElementsSum(sumArray, reversedArray);
                integerArray = reversedArray;
            }
            for (int i = 0; i < sumArray.Length; i++)
            {
                Console.Write(sumArray[i] + " ");
            }
        }
    }
}
