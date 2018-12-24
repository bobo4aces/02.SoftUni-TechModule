using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            list.Sort();
            int counter = 1;
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i - 1] == list[i])
                {
                    counter++;
                    
                }
                else
                {
                    Console.WriteLine($"{list[i - 1]} -> {counter}");
                    counter = 1;
                }
                if (i == list.Count - 1)
                {
                    Console.WriteLine($"{list[i]} -> {counter}");
                }
            }
            if (list.Count==1)
            {
                Console.WriteLine($"{list[0]} -> 1");
            }
        }
    }
}
