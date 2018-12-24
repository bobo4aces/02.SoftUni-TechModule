using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Spy_Gram
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] privateKey = Console.ReadLine().ToCharArray();
            string input = Console.ReadLine();
            Dictionary<string, string> messagesBySender = new Dictionary<string, string>();
            while (input!= "END")
            {
                string pattern = @"TO: (?<recipient>[A-Z]+); MESSAGE: (?<message>.+);";
                Regex regex = new Regex(pattern);
                if (regex.IsMatch(input))
                {
                    int messageCounter = 0;
                    int privateKeyCounter = 0;
                    string sender=regex.Match(input).Groups["recipient"].Value;
                    char[] message = input.ToCharArray();
                    while (messageCounter != input.Length)
                    {
                        if (privateKeyCounter == privateKey.Length)
                        {
                            privateKeyCounter = 0;
                        }
                        message[messageCounter] = (char)(message[messageCounter]+int.Parse(privateKey[privateKeyCounter].ToString()));
                        messageCounter++;
                        privateKeyCounter++;  
                    }
                    string encriptedMessage = "";
                    for (int i = 0; i < message.Length; i++)
                    {
                        encriptedMessage += message[i];
                    }
                    if (!messagesBySender.ContainsKey(sender))
                    {
                        messagesBySender.Add(sender, encriptedMessage);
                    }
                    else
                    {
                        messagesBySender[sender] = encriptedMessage;
                    }
                }


                input = Console.ReadLine();
            }
            foreach (var message in messagesBySender.OrderBy(s=>s.Key))
            {
                Console.WriteLine(message.Value);
            }
        }
    }
}
