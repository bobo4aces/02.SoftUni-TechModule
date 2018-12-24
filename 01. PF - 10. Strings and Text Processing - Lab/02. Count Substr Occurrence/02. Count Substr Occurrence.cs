using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Count_Substr_Occurrence
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string searchString = Console.ReadLine().ToLower();
            int index=text.IndexOf(searchString);
            int counter = 0;
            while (index!=-1)
            {
                counter++;
                index =text.IndexOf(searchString,index+1);
                
            }
            Console.WriteLine(counter);
        }
    }
}
