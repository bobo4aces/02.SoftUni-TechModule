using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex surface = new Regex("[^a-zA-Z0-9_]+");
            Regex mantle = new Regex("[0-9_]+");
            Regex core = new Regex("[A-Za-z]+");
            int length = 0;
            bool isValidSnowFlake = true;
            for (int i = 0; i < 5; i++)
            {
                string input = Console.ReadLine();
                bool isValid = true;
                bool isValidInput = true;
                if (i==0||i==4)
                {
                    isValid=surface.IsMatch(input);
                    Match match = surface.Match(input);
                    isValidInput = match.ToString()==input;
                }
                else if (i == 1 || i == 3)
                {
                    isValid = mantle.IsMatch(input);
                    Match match = mantle.Match(input);
                    isValidInput = mantle.ToString() == input;
                }
                else
                {
                    isValid = surface.IsMatch(input);
                    isValid = mantle.IsMatch(input);
                    isValid = core.IsMatch(input);

                    Match match = core.Match(input);
                    isValidInput = match.ToString() == input;
                    length = match.Length;
                    
                }
                if (!isValid||!isValidInput)
                {
                    isValidSnowFlake = false;
                }
            }
            if (isValidSnowFlake)
            {
                Console.WriteLine("Valid");
                Console.WriteLine(length);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
