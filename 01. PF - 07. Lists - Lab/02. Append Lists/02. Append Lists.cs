using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> list = new List<string>();
            string[] tokens = input.Split('|').ToArray();
            for (int i = 0; i < tokens.Length; i++)
            {
                List<string> listToList= new List<string>(tokens[i].Split(' '));
                for (int j = 0; j < listToList.Count; j++)
                {
                    if (listToList.Remove(""))
                    {
                        j--;
                    }
                    else
                    {
                        list.Insert(j, listToList[j]);
                    }
                }
            }
            Console.WriteLine(string.Join(" ",list));
        }
    }
}
