using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime
{
    class DateTime
    {
        static void Main(string[] args)
        {
            var now = new DateTime(2010, 2, 14, 17, 52, 54);
            Console.Clear();
            var date = DateTime.Now;
            date = date.AddDays(30);
            
            var a = DateTime.Parse(Console.ReadLine());
            var b = DateTime.ParseEact(Console.ReadLine(),"yyyy");
        }
    }
}
