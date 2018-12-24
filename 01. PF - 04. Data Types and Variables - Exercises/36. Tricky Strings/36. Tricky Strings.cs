using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36.Tricky_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string delimiter = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string stringSeparatedByDelimiter = Console.ReadLine();
            for (int i = 0; i < n-1; i++)
            {
                stringSeparatedByDelimiter += delimiter+Console.ReadLine();
            }
            Console.WriteLine(stringSeparatedByDelimiter);
        }
    }
}
