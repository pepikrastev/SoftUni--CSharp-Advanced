using System;
using System.Collections.Generic;

class StartUp
{
    static void Main(string[] args)
    {

        Stack<char> text = new Stack<char>();

        string input = Console.ReadLine();

        foreach (char item in input)
        {
            char ch = item;
            text.Push(ch);
        }

        while (text.Count != 0)
        {
            Console.Write(text.Pop());
        }
        Console.WriteLine();
    }
}