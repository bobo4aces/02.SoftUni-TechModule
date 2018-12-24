using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string text = Console.ReadLine();
            string pattern = @"\|<(.*?)(?:(?=\||$))";

            var matches = Regex.Matches(text, pattern);
            //Regex.Matches((string.Join(", ", Regex.Matches(@"\|<(.*?)(?:(?=\||$))").Cast<Match>().Select(e=>string.Concat(e.Groups[1].ToString().Skip(elements[0]).Take(elements[1]).ToArray()));
            List<string> camera = new List<string>();

            foreach (Match match in matches)
            {
                string element = string.Concat(match.Groups[1].ToString().Skip(elements[0]).Take(elements[1]).ToArray());
                camera.Add(element);
            }
            Console.WriteLine(string.Join(", ",camera));
            // \|<(.*?)(?:(?=\||$))
        }
    }
}
