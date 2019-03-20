using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main(string[] args)
    {
        string[] values = Console.ReadLine().Split();

        Stack<string> stack = new Stack<string>(values.Reverse());

        while (stack.Count() != 1)
        {
            int firstNumber = int.Parse(stack.Pop());
            string operand = stack.Pop();
            int secondNumber = int.Parse(stack.Pop());

            if (operand == "+")
            {
                stack.Push((firstNumber + secondNumber).ToString());
            }
            else if (operand == "-")
            {
                stack.Push((firstNumber - secondNumber).ToString());
            }
        }

        Console.WriteLine(stack.Pop());
    }
}