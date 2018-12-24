using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(' ').ToArray();
            string firstWord = text[0];
            string secondWord = text[1];
            int minLenght = Math.Min(firstWord.Length, secondWord.Length);
            string longerWord = "";
            if (firstWord.Length==minLenght)
            {
                longerWord = firstWord;
            }
            else
            {
                longerWord = secondWord;
            }

            int sum = 0;

            for (int i = 0; i < minLenght; i++)
            {
                sum += firstWord[i] * secondWord[i];
            }

            for (int i = minLenght; i < longerWord.Length ; i++)
            {
                sum += longerWord[i];
            }

            Console.WriteLine(sum);
        }
    }
}
