using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Make_a_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());
            string word = "";
            for (int i = 0; i < linesCount; i++)
            {
                char characters = char.Parse(Console.ReadLine());
                word += characters;
            }
            Console.WriteLine($"The word is: {word}");
        }
    }
}
