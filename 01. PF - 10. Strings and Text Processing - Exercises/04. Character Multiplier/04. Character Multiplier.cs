using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Character_Multiplier
{
    class Program
    {
        static int GetCalcCharCodes(string firstString,string secondString)
        {
            int shortestString = Math.Min(firstString.Length, secondString.Length);
            int longestString = Math.Max(firstString.Length, secondString.Length);
            int sum = 0;
            for (int i = 0; i < shortestString; i++)
            {
                sum += firstString[i] * secondString[i];
            }
            for (int i = longestString - 1; i >= shortestString; i--)
            {
                if (firstString.Length>secondString.Length)
                {
                    sum += firstString[i];
                }
                else
                {
                    sum += secondString[i];
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(' ').ToArray();
            Console.WriteLine(GetCalcCharCodes(text[0],text[1]));
        }
    }
}
