using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37.Cypher_Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentN = 0;
            string word = "";
            string currentWord = "";
            string lastEnteredWord = "";
            int countSpins = 0;
            while (currentN<n)
            {
                currentWord = Console.ReadLine();
                if (lastEnteredWord == currentWord)
                {
                    word = "";
                    if (currentWord!="spin")
                    {
                        currentN++;
                    }
                }
                else
                {
                    lastEnteredWord = currentWord;
                    if (currentWord == "spin")
                    {
                        countSpins++;
                    }
                    else if (countSpins % 2 == 0)
                    {
                        word += currentWord;
                        currentN++;
                    }
                    else
                    {
                        word = currentWord + word;
                        currentN++;
                    }
                }
                
            }
            Console.WriteLine(word);
        }
    }
}
