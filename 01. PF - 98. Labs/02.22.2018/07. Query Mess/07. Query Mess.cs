using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07.Query_Mess
{
    class Program
    {
        static void Main(string[] args)
        {
            //([^=&?\n]+)=([^=&?\n]+)
            //(%20|\+)+
            string input = Console.ReadLine();
            string spacePattern = @"(%20|\+)+";
            var pattern = new Regex(@"([^=&?\n]+)=([^=&?\n]+)");
            while (input!="end")
            {
                var data = pattern.Matches(input);
                Dictionary<string, List<string>> queries = new Dictionary<string, List<string>>();
                foreach (Match item in data)
                {
                    string field = item.Groups[1].ToString();
                    field = Regex.Replace(field, spacePattern, " ").Trim();
                    string value = item.Groups[2].ToString();
                    value = Regex.Replace(value, spacePattern, " ").Trim();
                    if (!queries.ContainsKey(field))
                    {
                        queries.Add(field, new List<string>());
                    }
                    queries[field].Add(value);
                }
                foreach (var query in queries)
                {
                    Console.Write($"{query.Key}=[{string.Join(" ",query.Value)}]");
                }
                Console.WriteLine();
                input = Console.ReadLine();
            }
        }
    }
}
