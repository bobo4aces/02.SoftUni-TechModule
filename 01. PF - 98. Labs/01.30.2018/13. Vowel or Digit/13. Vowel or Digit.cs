using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());
            //aouei
            if (symbol=='a'||symbol=='o'||symbol=='u'||symbol=='e'||symbol=='i')
            {
                Console.WriteLine("vowel");
            }
            else if ('1'<=symbol||symbol<='0')
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
