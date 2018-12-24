using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separatorsList = { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' };
            List<string> text = Console.ReadLine().Split(separatorsList).ToList();
            List<string> lowerCaseWords = new List<string>();
            List<string> upperCaseWords = new List<string>();
            List<string> mixedCaseWords = new List<string>();
            while (text.Contains(""))
            {
                text.Remove("");
            }

            for (int i = 0; i < text.Count; i++)
            {
                int lowerCaseLetter = 0;
                int upperCaseLetter = 0;
                foreach (var character in text[i])
                {
                    if ('A' <= character && character <= 'Z')
                    {
                        upperCaseLetter++;
                    }
                    else if ('a' <= character && character <= 'z')
                    {
                        lowerCaseLetter++;
                    }

                }

                if (text[i].Length == lowerCaseLetter)
                {
                    lowerCaseWords.Add(text[i]);
                }

                else if (text[i].Length == upperCaseLetter)
                {
                    upperCaseWords.Add(text[i]);
                }

                else
                {
                    mixedCaseWords.Add(text[i]);
                }

            }

            Console.WriteLine("Lower-case: " + string.Join(", ", lowerCaseWords));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixedCaseWords));
            Console.WriteLine("Upper-case: " + string.Join(", ", upperCaseWords));
        }
    }
}
