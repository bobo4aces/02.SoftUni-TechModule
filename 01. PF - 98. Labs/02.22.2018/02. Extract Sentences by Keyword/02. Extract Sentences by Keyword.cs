using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string[] text = Console.ReadLine().Split(".!?".ToCharArray(),StringSplitOptions.RemoveEmptyEntries).ToArray();
            foreach (var sentence in text)
            {
                var words = Regex.Split(sentence, @"[^A-Za-z0-9]+");

                foreach (var word in words)
                {
                    if (word==key)
                    {
                        Console.WriteLine(sentence.Trim());
                        break;
                    }
                }
            }
        }
    }
}
