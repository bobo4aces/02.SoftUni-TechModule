using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, string> ipAndUser = new Dictionary<string, string>();
            Dictionary<string, int> ipAndMessageCount = new Dictionary<string, int>();
            while (input!="end")
            {
                List<string> inputList = input.Split(new char[] { '=', ' ' }).ToList();
                string ip = inputList[1];
                string message = inputList[3];
                string user = inputList[5];

                //Same IP for different users?
                if (!ipAndUser.ContainsKey(ip))
                {
                    ipAndUser.Add(ip, user);
                }
                //else
                //{
                //    string oldIP = ip;
                //    ipAndUser.Remove(ip);
                //    ipAndUser.Add(ip+"|"+oldIP, user);
                //}
                if (ipAndMessageCount.ContainsKey(ip))
                {
                    ipAndMessageCount[ip]++;
                }
                else
                {
                    ipAndMessageCount[ip]=1;
                }
                input = Console.ReadLine();
            }
            List<string> users = new List<string>();
            foreach (var ip in ipAndUser)
            {
                //if (ip.Key.Contains("|"))
                //{
                //    string[] differentIPs=ip.Key.Split('|');
                //    for (int i = 0; i < differentIPs.Length; i++)
                //    {
                //        if (!users.Contains(differentIPs[i]))
                //        {
                //            users.Add(differentIPs[i]);
                //        }
                //    }
                //}
                if (!users.Contains(ip.Value))
                {
                    users.Add(ip.Value);
                }
                users.Distinct();
                users.Sort();
            }
            foreach (var user in users)
            {
                Console.WriteLine($"{user}: ");
                List<string> output = new List<string>();
                foreach (var address in ipAndUser)
                {
                    foreach (var ip in ipAndMessageCount)
                    {
                        if (address.Key == ip.Key&&user==address.Value)
                        {
                            output.Add($"{ip.Key} => {ip.Value}");
                        }
                    }
                }
                Console.Write(string.Join(", ",output));
                Console.WriteLine(".");
            }
        }
    }
}
