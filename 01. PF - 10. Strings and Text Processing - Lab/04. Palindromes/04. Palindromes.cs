using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(new char[] { ' ','.',',','?','!'},StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<string> result = new List<string>();
            for (int i = 0; i < text.Length; i++)
            {
                char[] arr = text[i].ToArray();
                StringBuilder sb = new StringBuilder();
                for (int j = arr.Length - 1; j >= 0; j--)
                {
                    sb.Append(arr[j]);
                }
                string reversedText = sb.ToString();
                if (text[i]==reversedText)
                {
                    result.Add(text[i]);
                }
            }
            Console.WriteLine(string.Join(", ",result.Distinct().OrderBy(x=>x)));
        }
    }
}
