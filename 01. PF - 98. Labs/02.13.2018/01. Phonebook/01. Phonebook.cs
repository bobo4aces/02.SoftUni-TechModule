using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            string line;
            while ((line=Console.ReadLine())!="END")
            {
                string[] tokens = line.Split();

                string command = tokens[0];
                string name = tokens[0];

                switch (command)
                {
                    case "A":
                        string number = tokens[2];
                        if (phonebook.ContainsKey(name))
                        {
                            phonebook[name] = number;
                        }
                        else
                        {
                            phonebook.Add(name, number);
                        }
                        break;
                    //
                    //
                    //
                    //
                    //
                    //
                    //
                    default:
                        break;
                }
            }
        }
    }
}
