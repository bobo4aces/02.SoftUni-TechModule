using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string keys = Console.ReadLine();
            string text = Console.ReadLine();

            //([A-Za-z]+)([|<\\|](.*?)[|<\\|])([A-Za-z]+)
            var match = Regex.Match(keys, @"([A-Za-z]+)[|<\\](.*?)[|<\\]([A-Za-z]+)");
            string startKey = match.Groups[1].ToString();
            string endKey = match.Groups[3].ToString();

            string textPattern = $"{startKey}(.*?){endKey}";

            var matches = Regex.Matches(text, textPattern);
            StringBuilder sb = new StringBuilder();

            foreach (Match item in matches)
            {
                sb.Append(item.Groups[1].ToString());
            }
            var result = sb.Length!=0?sb.ToString():"Empty result";
            Console.WriteLine(result);
        }
    }
}
