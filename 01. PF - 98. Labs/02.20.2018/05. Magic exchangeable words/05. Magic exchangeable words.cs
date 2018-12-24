using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Magic_exchangeable_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            string firstWord = words[0];
            string secondWord = words[1];
            Dictionary<char, char> dictionary = new Dictionary<char, char>();
            int minLength = words.Min(w => w.Length);
            string longerWord;
            if (minLength == firstWord.Length)
            {
                longerWord = secondWord;
            }
            else
            {
                longerWord = firstWord;
            }
            for (int i = 0; i < minLength; i++)
            {
                char firstChar = firstWord[i];
                char secondChar = secondWord[i];

                if (dictionary.ContainsKey(firstChar) == false)
                {
                    dictionary.Add(firstChar, secondChar);
                    if (dictionary.Values.Count(ch=>ch==secondChar)>1)
                    {
                        Console.WriteLine("false");
                        return;
                    }
                    
                }
                else
                {
                    char oldValue = dictionary[firstChar];
                    if (secondChar != oldValue)
                    {
                        Console.WriteLine("false");
                        return;
                    }


                }
            }

            int maxLength = words.Max(w => w.Length);
            for (int i = minLength; i < maxLength; i++)
            {
                char symbol = longerWord[i];
                if (dictionary.ContainsValue(symbol) == false&&dictionary.ContainsKey(symbol)==false)
                {
                    Console.WriteLine("false");
                    return;
                }
            }
            Console.WriteLine("true");
        }
    }
}
