using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(' ').ToArray();
            string[] reversedText = new string[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                reversedText[(text.Length - 1) - i] = text[i];
            }
            for (int i = 0; i < reversedText.Length; i++)
            {
                Console.Write(reversedText[i]+" ");
            }
        }
    }
}
