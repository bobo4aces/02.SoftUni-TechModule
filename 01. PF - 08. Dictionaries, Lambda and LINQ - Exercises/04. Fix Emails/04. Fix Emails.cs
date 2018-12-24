using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int counter = 1;
            string name = "";
            Dictionary<string, string> contactInformation = new Dictionary<string, string>();
            while (input!="stop")
            {
                if (counter % 2 != 0)
                {
                    name = input;
                }
                else
                {
                    string email = input;
                    contactInformation.Add(name, email);
                }
                input = Console.ReadLine();
                counter++;
            }
            foreach (var entry in contactInformation)
            {
                if (!entry.Value.EndsWith("us")&& !entry.Value.EndsWith("uk"))
                {
                    Console.WriteLine($"{entry.Key} -> {entry.Value}");
                }
            }

        }
    }
}
