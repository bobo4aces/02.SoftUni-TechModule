using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] searchArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool isFound = false;
            List<int> searchList = new List<int>();
            for (int i = 0; i < searchArray[0]; i++)
            {
                searchList.Add(list[i]);
            }
            for (int i = 0; i < searchArray[1]; i++)
            {
                searchList.Remove(searchList[0]);
            }
            for (int i = 0; i < searchList.Count; i++)
            {
                if (searchList[i]==searchArray[2])
                {
                    isFound=true;
                }
            }
            if (isFound)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
