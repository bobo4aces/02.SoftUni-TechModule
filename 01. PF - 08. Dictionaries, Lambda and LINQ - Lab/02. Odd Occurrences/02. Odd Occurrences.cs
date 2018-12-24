using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().ToLower().Split().ToArray();
            Dictionary<string, int> occurences = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (occurences.ContainsKey(word))
                {
                    occurences[word]++;
                }
                else
                {
                    occurences[word] = 1;
                }
            }

            List<string> result = new List<string>();
            foreach (var word in occurences.Keys)
            {
                if (occurences[word]%2!=0)
                {
                    result.Add(word);
                }
            }
            Console.Write(string.Join(", ", result));
            Console.WriteLine();
        }
    }
}
