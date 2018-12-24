using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstArr = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
            char[] secondArr = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

            int length = Math.Min(firstArr.Length, secondArr.Length);

            bool isFirst = false;

            for (int i = 0; i < length; i++)
            {
                if (firstArr[i]!=secondArr[i])
                {
                    if (firstArr[i]<secondArr[i])
                    {
                        isFirst = true;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            if (isFirst)
            {
                Console.WriteLine(string.Join("",firstArr));
                Console.WriteLine(string.Join("",secondArr));
            }
            else
            {
                if (firstArr.Length<secondArr.Length)
                {
                    Console.WriteLine(string.Join("", firstArr));
                    Console.WriteLine(string.Join("", secondArr));
                }
                else
                {
                    Console.WriteLine(string.Join("", secondArr));
                    Console.WriteLine(string.Join("", firstArr));
                } 
            }
        }
    }
}
