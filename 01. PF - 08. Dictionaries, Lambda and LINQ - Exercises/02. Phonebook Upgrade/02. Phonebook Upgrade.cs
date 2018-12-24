using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(' ').ToArray();
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();
            while (command[0]!="END")
            {
                if (command[0]=="A")
                {
                    if (phonebook.ContainsKey(command[1]))
                    {
                        phonebook.Remove(command[1]);
                    }

                    phonebook.Add(command[1], command[2]);
                }
                else if (command[0]=="S")
                {
                    string phoneNumber = "";
                    bool isFound = phonebook.TryGetValue(command[1], out phoneNumber);
                    if (isFound)
                    {
                        Console.WriteLine($"{command[1]} -> {phoneNumber}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {command[1]} does not exist.");
                    }
                }
                else if (command[0]=="ListAll")
                {
                    foreach (var contact in phonebook)
                    {
                        Console.WriteLine($"{contact.Key} -> {contact.Value}");
                    }
                }
                command = Console.ReadLine().Split(' ').ToArray();
            }
        }
    }
}
