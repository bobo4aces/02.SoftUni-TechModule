using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int counter = 1;
            string resource = "";
            int quantity = 0;
            Dictionary<string, int> resoursesWithQuantities = new Dictionary<string, int>();
            while (input != "stop")
            {

                if (counter % 2 != 0)
                {
                    resource = input;
                    quantity = 0;
                }
                else
                {
                    quantity = int.Parse(input);
                }
                if (resoursesWithQuantities.ContainsKey(resource))
                {
                    int oldQuantity = 0;
                    bool isFound = resoursesWithQuantities.TryGetValue(resource, out oldQuantity);
                    if (isFound)
                    {
                        resoursesWithQuantities.Remove(resource);
                        resoursesWithQuantities.Add(resource, oldQuantity+quantity);
                    }
                    
                }
                else
                {
                    resoursesWithQuantities.Add(resource, 0);
                }
                input = Console.ReadLine();
                counter++;
            }
            foreach (var item in resoursesWithQuantities)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
