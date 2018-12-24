using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace _09.Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = 0;
            bool isItInt = true;
            do
            {
                try
                {
                    int number = int.Parse(Console.ReadLine());
                    numberCount++;
                }
                catch
                {
                    isItInt = false;
                }
            } while (isItInt);
            Console.WriteLine(numberCount);
        }
    }
}
