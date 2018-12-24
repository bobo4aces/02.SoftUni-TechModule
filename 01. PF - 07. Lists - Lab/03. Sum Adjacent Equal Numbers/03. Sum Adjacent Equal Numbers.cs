using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> list = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            for (int i = 0; i < list.Count-1; i++)
            {
                while (list[i] == list[i+1])
                {
                    list[i+1] += list[i];
                    list.RemoveAt(i);
                    if (list.Count - 1>0)
                    {
                        i = 0;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(string.Join(" ",list));
        }
    }
}
