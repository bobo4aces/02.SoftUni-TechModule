using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command!="print")
            {
                string[] argument = command.Split(' ').ToArray();

                if (argument[0]=="add")
                {
                    int index = int.Parse(argument[1]);
                    int element = int.Parse(argument[2]);
                    inputList.Insert(index, element);
                }

                else if (argument[0] == "addMany")
                {
                    int index = int.Parse(argument[1]);
                    List<int> elements = new List<int>();

                    for (int i = 2; i < argument.Length; i++)
                    {
                        elements.Add(int.Parse(argument[i]));
                    }
                    inputList.InsertRange(index,elements);
                }

                else if (argument[0] == "contains")
                {
                    Console.WriteLine(inputList.IndexOf(int.Parse(argument[1])));
                }

                else if (argument[0] == "remove")
                {
                    inputList.RemoveAt(int.Parse(argument[1]));
                }

                else if (argument[0] == "shift")
                {
                    int rotations = int.Parse(argument[1]);

                    for (int i = 0; i < rotations; i++)
                    {
                        int currentNumber = inputList[0];

                        for (int j = 1; j < inputList.Count; j++)
                        {
                            inputList[j - 1] = inputList[j];
                        }
                        inputList[inputList.Count - 1] = currentNumber;
                    }
                }
                else if (argument[0]=="sumPairs")
                {
                    for (int i = 0; i < inputList.Count-1; i++)
                    {
                        inputList[i] = inputList[i] + inputList[i + 1];
                        inputList.RemoveAt(i + 1);
                    }
                }


                command = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ",inputList)}]");
        }
    }
}
