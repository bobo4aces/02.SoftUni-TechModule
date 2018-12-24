using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabetArray = new char[26];
            for (int i = 0; i < alphabetArray.Length; i++)
            {
                int letter = 'a' + i;
                alphabetArray[i] = (char)letter;
            }
            string word = Console.ReadLine();
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < alphabetArray.Length; j++)
                {
                    if (word[i]==alphabetArray[j])
                    {
                        Console.WriteLine($"{word[i]} -> {j}");
                    }
                }
            }
        }
    }
}
