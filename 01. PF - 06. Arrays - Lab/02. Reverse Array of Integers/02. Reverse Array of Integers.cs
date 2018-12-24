using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Reverse_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int elementsCount = int.Parse(Console.ReadLine());
            int[] elementsArray = new int[elementsCount];
            for (int i = 0; i < elementsCount; i++)
            {
                elementsArray[i] = int.Parse(Console.ReadLine());  
            }
            for (int i = elementsCount-1; i >= 0; i--)
            {
                Console.Write(elementsArray[i]+" ");
            }
        }
    }
}
