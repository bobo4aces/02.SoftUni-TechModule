using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int count = 0;
            int currentN = n;
            while (currentN >= m)
            {

                if (n == currentN * 2)
                {
                    try
                    {
                        currentN /= y;
                    }
                    catch
                    {
                        currentN -= m;
                    }
                    if (currentN<m)
                    {
                        continue;
                    }
                }
                else
                {
                    currentN -= m;

                }

                count++;

            }
            Console.WriteLine(currentN);
            Console.WriteLine(count);
        }
    }
}
