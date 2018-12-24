using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Magic_exchange_words
{
    class Program
    {
        static bool AreExchangeable(string firstString, string secondString)
        {
            int longestLength = Math.Max(firstString.Length, secondString.Length);
            int shortestLength = Math.Min(firstString.Length, secondString.Length);
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < shortestLength; i++)
            {

                string tempWord = secondString.Replace(secondString[i], firstString[i]);
                result=result.Append(tempWord[i]);
            }
            string resultAsText = result.ToString();
            bool isExchangeable = true;
            for (int i = shortestLength; i < longestLength; i++)
            {
                if (firstString.Length>secondString.Length)
                {
                    if (!resultAsText.Contains(firstString[i]))
                    {
                        isExchangeable = false;
                    }
                }
                else
                {
                    if (!resultAsText.Contains(secondString[i]))
                    {
                        isExchangeable = false;
                    }
                }
            }
            if (firstString== resultAsText&&isExchangeable)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            bool areExchangeable = AreExchangeable(input[0], input[1]);
            Console.WriteLine(areExchangeable);
        }
    }
}
