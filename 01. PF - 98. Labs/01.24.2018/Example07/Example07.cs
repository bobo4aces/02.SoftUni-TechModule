using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example07
{
    class Example07
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int number=0;
            var result = int.TryParse(text, out number);
        }
    }
}
