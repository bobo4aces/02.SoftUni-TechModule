using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Hornet_Comm
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            List<string> privateMessages = new List<string>();
            List<string> broadcasts = new List<string>();
            while (input != "Hornet is Green")
            {
                string privateMessagePattern = @"^(?<firstPart>\d+) <-> (?<secondPart>[A-Za-z\d]+|[A-Za-z]+|[\d+])$";
                string broadcastPattern = @"^(?<firstPart>\D+) <-> (?<secondPart>[A-Za-z\d]+|[A-Za-z]+|[\d+])$";

                Regex privateMessageRegex = new Regex(privateMessagePattern);
                Regex broadcastRegex = new Regex(broadcastPattern);
                Match privateMessageMatch = privateMessageRegex.Match(input);
                Match broadcastMatch = broadcastRegex.Match(input);

                if (privateMessageRegex.IsMatch(input))
                {
                    string recipientCode = string.Join("", privateMessageMatch.Groups["firstPart"].Value.Reverse());
                    string message = privateMessageMatch.Groups["secondPart"].Value;
                    privateMessages.Add($"{recipientCode} -> {message}");
                }

                if (broadcastRegex.IsMatch(input))
                {
                    string message = broadcastMatch.Groups["firstPart"].Value;
                    string frequency = broadcastMatch.Groups["secondPart"].Value;
                    string resultFrequency = "";
                    foreach (var character in frequency)
                    {
                        if (65 <= character && character <= 90)
                        {
                            resultFrequency += (char)(character + 32);
                        }
                        else if (97 <= character && character <= 122)
                        {
                            resultFrequency += (char)(character - 32);
                        }
                        else
                        {
                            resultFrequency += character;
                        }

                    }
                    broadcasts.Add($"{resultFrequency} -> {message}");
                }
                input = Console.ReadLine();
            }


            Console.WriteLine($"Broadcasts:");
            if (broadcasts.Count() == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                Console.WriteLine(string.Join("\n", broadcasts));
            }
            Console.WriteLine($"Messages:");
            if (privateMessages.Count() == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                Console.WriteLine(string.Join("\n", privateMessages));
            }
        }
    }
}
