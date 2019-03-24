using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < number; i++)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int command = input[0];

            if (command == 1)
            {
                stack.Push(input[1]);
            }
            else if (command == 2)
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
            }
            else if (command == 3)
            {
                if (stack.Count > 0)
                {
                    Console.WriteLine(stack.Max());
                }
            }
            else if (command == 4)
            {
                if (stack.Count > 0)
                {
                    Console.WriteLine(stack.Min());
                }
            }
        }

        Console.WriteLine(string.Join(", ", stack));
    }
}