using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            //(^| )[A-Za-z][A-Za-z0-9.\-_]*@[A-Z-a-z-]+(\.[a-z]+)+
            //

            string text = Console.ReadLine();

            Regex pattern = new Regex(@"(^| )[A-Za-z][A-Za-z0-9.\-_]*@[A-Z-a-z-]+(\.[a-z]+)+");
            MatchCollection matches = pattern.Matches(text);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
            /*string text = Console.ReadLine();
            string pattern = @" ([A-Za-z]+(\-\w+|\.\w+|)@\w+(\w+|\-)\w+\.(\w+\.\w+|\w+))";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[1]);
            }*/

        }
    }
}
