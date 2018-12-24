using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List <int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i]<0)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }

            list.Reverse();
            if (1<=list.Count)
            {
                Console.WriteLine(string.Join(" ", list)); 
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
