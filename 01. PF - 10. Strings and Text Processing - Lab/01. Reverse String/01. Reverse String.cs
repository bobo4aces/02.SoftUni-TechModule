﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] arr = input.ToCharArray();
            StringBuilder sb = new StringBuilder();
            for (int i = input.Length-1; i >= 0; i--)
            {
                sb.Append(input[i]);
            }
            Console.WriteLine(sb);
        }
    }
}
