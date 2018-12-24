using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> command = Console.ReadLine().Split(' ').ToList();
            while (command[0]!="Odd"&&command[0]!="Even")
            {
                
                if (command[0]=="Delete")
                {
                    int numberToDelete = int.Parse(command[1]);
                    while (list.Contains(numberToDelete))
                    {
                        list.Remove(numberToDelete);
                    }
                }
                else if (command[0]=="Insert")
                {
                    int numberToInsert = int.Parse(command[1]);
                    int insertPosition = int.Parse(command[2]);
                    list.Insert(insertPosition,numberToInsert);
                }
                command = Console.ReadLine().Split(' ').ToList();
            }
            if (command[0]=="Odd")
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i]%2!=0)
                    {
                        Console.Write(list[i]+" ");
                    }
                }
            }
            else if (command[0] == "Even")
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 == 0)
                    {
                        Console.Write(list[i] + " ");
                    }
                }
            }
        }
    }
}
