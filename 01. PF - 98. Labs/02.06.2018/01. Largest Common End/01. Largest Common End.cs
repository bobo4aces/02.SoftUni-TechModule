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
            string[] firstArr = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] secondArr = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).ToArray();

            int length = Math.Max(firstArr.Length, secondArr.Length);

            int equalElements = 0;

            for (int i = 0; i < length; i++)
            {
                if (firstArr[i]==secondArr[i])
                {
                    equalElements++;
                }
            }

            Array.Reverse(firstArr);

            secondArr = secondArr.Reverse().ToArray();

            int reversedCounter = 0;

            for (int i = 0; i < length; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    equalElements++;
                }
            }

            if (equalElements>reversedCounter)
            {
                Console.WriteLine(equalElements);
            }
            else
            {
                Console.WriteLine(reversedCounter);
            }
        }
    }
}
