using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] array = Console.ReadLine()
                .Split(new char[] {' ' },StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

            string[] command = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            while (command[0]!="end")
            {
                if (command[0]=="swap")
                {
                    array = SwapArray(array,command[1], command[2]);
                }
                else if (command[0] == "multiply")
                {
                    array = MultiplyArray(array, command[1], command[2]);
                }
                else if (command[0] == "decrease")
                {
                    array = DecreaseArray(array);
                }
                command = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }
            Console.WriteLine(string.Join(", ",array));
        }

        static long[] DecreaseArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i]-1;
            }
            return array;
        }

        static long[] MultiplyArray(long[] array, string firstIndex, string secondIndex)
        {
            long index1 = long.Parse(firstIndex);
            long index2 = long.Parse(secondIndex);
            array[index1] *= array[index2];
            return array;

        }

        static long[] SwapArray(long[] array,string firstIndex, string secondIndex)
        {
            long index1 = long.Parse(firstIndex);
            long index2 = long.Parse(secondIndex);
            long oldIndex = array[index1];
            array[index1] = array[index2];
            array[index2] = oldIndex;
            return array;
        }
    }
}
