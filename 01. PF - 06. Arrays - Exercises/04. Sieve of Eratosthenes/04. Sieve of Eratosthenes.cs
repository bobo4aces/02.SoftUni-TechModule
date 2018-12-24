using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            int[] numbersArray = new int[numbersCount-1];
            bool[] primes = new bool[numbersCount+1];
            for (int i = 0; i <= numbersCount; i++)
            {
                primes[i] = true;
                
            }
            primes[0] = false;
            primes[1] = false;
            for (int i = 2; i <= numbersCount; i++)
            {
                if (primes[i] == true)
                {
                    Console.Write(i+" ");
                    int counter = 2;
                    while (counter * i<= numbersCount)
                    {
                        primes[counter * i] = false;
                        counter++;
                    }
                }
                
            }
        }
    }
}
