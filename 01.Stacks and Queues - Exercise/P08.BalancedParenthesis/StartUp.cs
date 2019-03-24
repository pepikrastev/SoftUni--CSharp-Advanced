using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main(string[] args)
    {
        string parentheses = Console.ReadLine();

        Stack<char> stackOfParentheses = new Stack<char>();

        char[] openParentheses = new char[] { '(', '{', '[' };

        bool isValid = true;

        for (int i = 0; i < parentheses.Length; i++)
        {
            char currentBracet = parentheses[i];

            if (openParentheses.Contains(currentBracet))
            {
                stackOfParentheses.Push(currentBracet);
                continue;
            }

            if (stackOfParentheses.Count == 0)
            {
                isValid = false;
                break;
            }

            if (stackOfParentheses.Peek() == '(' && currentBracet == ')')
            {
                stackOfParentheses.Pop();
            }
            else if (stackOfParentheses.Peek() == '{' && currentBracet == '}')
            {
                stackOfParentheses.Pop();
            }
            else if (stackOfParentheses.Peek() == '[' && currentBracet == ']')
            {
                stackOfParentheses.Pop();
            }
        }

        if (isValid && stackOfParentheses.Count == 0)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}