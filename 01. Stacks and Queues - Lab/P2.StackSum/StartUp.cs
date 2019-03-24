using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main(string[] args)
    {
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Stack<int> reverseArray = new Stack<int>(array);

        while (true)
        {
            string startCommand = Console.ReadLine().ToLower();

            if (startCommand == "end")
            {
                break;
            }

            string[] input = startCommand.Split();
            string command = input[0];

            if (command == "add")
            {
                int firstNumber = int.Parse(input[1]);
                reverseArray.Push(firstNumber);
                int secondNumber = int.Parse(input[2]);
                reverseArray.Push(secondNumber);
            }
            else if (command == "remove")
            {
                int firstNumber = int.Parse(input[1]);

                if (firstNumber > reverseArray.Count)
                {
                    continue;
                }

                for (int i = 0; i < firstNumber; i++)
                {
                    reverseArray.Pop();
                }
            }
        }

        Console.WriteLine($"Sum: {reverseArray.Sum()}");
    }
}