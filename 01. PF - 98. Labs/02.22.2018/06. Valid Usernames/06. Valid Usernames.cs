using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            //[A-Za-z]\w{2,24}\b
            string[] usernames=Regex.Matches(Console.ReadLine(), @"[A-Za-z]\w{2,24}\b").Cast<Match>().Select(e => e.Value).ToArray();
            string usernamesWithMaxValue = "";
            int maxSum = 0;
            for (int i = 0; i < usernames.Length-1; i++)
            {
                string firstUsername = usernames[i];
                string secondUsername = usernames[i+1];
                int currentSum = firstUsername.Length+ secondUsername.Length;
                if (currentSum>maxSum)
                {
                    maxSum = currentSum;
                    usernamesWithMaxValue = firstUsername + "\n" + secondUsername;
                }

            }
            Console.WriteLine(usernamesWithMaxValue);
        }
    }
}
