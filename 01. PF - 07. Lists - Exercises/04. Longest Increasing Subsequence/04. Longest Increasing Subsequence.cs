using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> length = new List<int>();
            List<int> previous = new List<int>();
            int left = -1;
            length.Insert(0, 1);
            for (int position = 0; position < list.Count; position++)
            {
                
                if (left < position)
                {
                    if (position >= 1)
                    {
                        left++;
                        length.Insert(position, 1 + left);
                    }
                }
                else
                {
                    length.Insert(position, length[left]);
                }
                previous.Insert(position,left);
            }

            Console.WriteLine(string.Join(" ",length));
        }
    }
}
