using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            foreach (var letter in input)
            {
                string result = string.Format("{0:x4}", (int)letter);
                Console.Write("\\u" + result);
            }
        }
    }
}
