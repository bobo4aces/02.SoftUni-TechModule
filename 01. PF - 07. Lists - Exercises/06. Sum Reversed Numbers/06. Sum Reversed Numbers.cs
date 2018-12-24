using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            double sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                string numberAsText = list[i].ToString();
                string reversedNumberAsText = "";
                for (int j = numberAsText.Length-1; j >= 0; j--)
                {
                    reversedNumberAsText += numberAsText[j];
                }
                sum += double.Parse(reversedNumberAsText);
            }
            Console.WriteLine(sum);
        }
    }
}
