using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SMS_Typing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int length = 0;
            char character = 'a';
            int typedLetter = 'a';
            string message = "";
            for (int i = 0; i < n; i++)
            {
                string letter = Console.ReadLine();
                length = letter.Length;
                character = letter.Last();
                switch (character)
                {
                    case '2':
                        typedLetter='a'+length-1;
                        break;
                    case '3':
                        typedLetter = 'd' + length-1;
                        break;
                    case '4':
                        typedLetter = 'g' + length-1;
                        break;
                    case '5':
                        typedLetter = 'j' + length-1;
                        break;
                    case '6':
                        typedLetter = 'm' + length-1;
                        break;
                    case '7':
                        typedLetter = 'p' + length-1;
                        break;
                    case '8':
                        typedLetter = 't' + length-1;
                        break;
                    case '9':
                        typedLetter = 'w' + length-1;
                        break;
                    case '0':
                        typedLetter = ' ' + length-1;
                        break;
                    default:
                        break;
                }
                message += (char)typedLetter;
            }
            Console.Write(message);
        }
    }
}
