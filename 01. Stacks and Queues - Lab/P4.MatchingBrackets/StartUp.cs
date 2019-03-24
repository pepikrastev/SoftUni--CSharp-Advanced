using System;
using System.Collections.Generic;

class StartUp
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < input.Length; i++)
        {
            char element = input[i];

            if (element == '(')
            {
                stack.Push(i);
            }
            else if (element == ')')
            {
                int startIndex = stack.Pop();
                string result = input.Substring(startIndex, i - startIndex + 1);

                Console.WriteLine(result);
            }
        }
    }
}