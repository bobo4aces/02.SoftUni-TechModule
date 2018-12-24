using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Catch_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            string idNumeralType = Console.ReadLine();
            int idCount = int.Parse(Console.ReadLine());
            long thiefID = long.MinValue;
            for (int i = 0; i < idCount; i++)
            {
                long id = long.Parse(Console.ReadLine());
                if (idNumeralType=="sbyte"&&sbyte.MaxValue>=id)
                {
                    if (id>=thiefID)
                    {
                        thiefID = id;
                    }
                }
                else if (idNumeralType == "int" && int.MaxValue >= id)
                {
                    if (id >= thiefID)
                    {
                        thiefID = id;
                    }
                }
                else if (idNumeralType == "long" && long.MaxValue >= id)
                {
                    if (id >= thiefID)
                    {
                        thiefID = id;
                    }
                }
            }
            Console.WriteLine(thiefID);
        }
    }
}
