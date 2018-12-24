using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?',' ' };
            string[] sentence = Console.ReadLine().ToLower().Split(separators).ToArray();
            var result = sentence.Where(x=>x!="").Where(x => x.Length < 5).OrderBy(x => x).Distinct();
            Console.WriteLine(string.Join(", ",result));
        }
    }
}
