using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            string pluralWord = "";

            if (word.EndsWith("y"))
            {
                string currentWord = word.Remove(word.Length - 1);
                pluralWord = currentWord + "ies";
            }
            //o, ch, s, sh, x or z
            else if (word.EndsWith("o")|| word.EndsWith("ch") || word.EndsWith("s") || word.EndsWith("sh") || word.EndsWith("x") || word.EndsWith("z"))
            {
                pluralWord = word + "es";
            }
            else
            {
                pluralWord = word + "s";
            }
            Console.WriteLine($"{pluralWord}");
        }
    }
}
