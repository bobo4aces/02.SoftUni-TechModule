using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Worm_Ipsum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input!= "Worm Ipsum")
            {

                bool isValid = true;
                if (65 <= input[0] && input[0] <= 90&&input[input.Length-1]=='.')
                {
                    for (int i = 0; i < input.Length-1; i++)
                    {
                        if (input[i]=='.')
                        {
                            isValid = false;
                            break;
                        }
                    }
                }
                else
                {
                    isValid = false;
                }
                if (isValid)
                {
                    string[] words = input
                        .Split(new[] { ' ','.' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
                    //List<string> newWords = new List<string>();
                    for (int i = 0; i < words.Length; i++)
                    {
                        int occurances = 0;
                        int maxOccurances = 0;
                        char character = '0';
                        for (int k = 0; k < words[i].Length; k++)
                        {
                            for (int j = k; j < words[i].Length; j++)
                            {
                                if (words[i][k] == words[i][j])
                                {
                                    occurances++;
                                }
                                else
                                {
                                    occurances = 0;
                                }
                                if (occurances > maxOccurances)
                                {
                                    maxOccurances = occurances;
                                    character = words[i][k];
                                }
                            }
                            
                        }
                        if (maxOccurances >= 2)
                        {
                            string newWord = new string(character, words[i].Length);
                            words[i]=newWord;
                        }
                    }
                    //foreach (var word in words)
                    //{
                    //    int occurances = 0;
                    //    int maxOccurances = 0;
                    //    char character = '0';
                    //    for (int i = 0; i < word.Length; i++)
                    //    {
                    //        for (int j = i; j < word.Length; j++)
                    //        {
                    //            if (word[i]==word[j])
                    //            {
                    //                occurances++;
                    //            }
                    //            if (occurances >= maxOccurances)
                    //            {
                    //                maxOccurances = occurances;
                    //                character = word[i];
                    //            }
                    //        }
                    //    }
                    //    if (maxOccurances>=2)
                    //    {
                    //        string newWord = new string(character, word.Length);
                    //        newWords.Add(newWord);
                    //        words..Replace(word,newWord);
                    //    }
                    //    else
                    //    {
                    //        newWords.Add(word);
                    //    }
                    //}
                    Console.WriteLine(string.Join(" ",words)+'.');
                }
                input = Console.ReadLine();
            }
        }
    }
}
