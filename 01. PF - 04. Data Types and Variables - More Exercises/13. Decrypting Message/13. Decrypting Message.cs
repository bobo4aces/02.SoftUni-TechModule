using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int charactersCount = int.Parse(Console.ReadLine());
            string message = "";
            for (int i = 0; i < charactersCount; i++)
            {
                char character = char.Parse(Console.ReadLine());
                int newCharacter = character + key;
                message += (char)newCharacter;
            }
            Console.WriteLine(message);
        }
    }
}
