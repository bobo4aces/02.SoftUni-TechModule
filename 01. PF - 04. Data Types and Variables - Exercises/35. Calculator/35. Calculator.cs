using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstOperand = int.Parse(Console.ReadLine());
            string operatorA = Console.ReadLine();
            int secondOperand = int.Parse(Console.ReadLine());
            switch (operatorA)
            {
                case "+":
                    Console.WriteLine($"{firstOperand} {operatorA} {secondOperand} = {firstOperand + secondOperand}");
                    break;                                                          
                case "-":                                                           
                    Console.WriteLine($"{firstOperand} {operatorA} {secondOperand} = {firstOperand - secondOperand}");
                    break;                                                          
                case "*":                                                           
                    Console.WriteLine($"{firstOperand} {operatorA} {secondOperand} = {firstOperand * secondOperand}");
                    break;                                                          
                case "/":                                                           
                    Console.WriteLine($"{firstOperand} {operatorA} {secondOperand} = {firstOperand / secondOperand}");
                    break;
                default:
                    break;
            }
        }
    }
}
