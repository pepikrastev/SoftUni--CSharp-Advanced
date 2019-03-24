using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int elementsToPush = numbers[0];
        int elementsToPop = numbers[1];
        int forSearch = numbers[2];

        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < elementsToPush; i++)
        {
            int numberToPush = input[i];
            stack.Push(numberToPush);
        }

        for (int i = 0; i < elementsToPop; i++)
        {
            stack.Pop();
        }

        if (stack.Contains(forSearch))
        {
            Console.WriteLine("true");
        }
        else
        {
            int maxNumber = int.MaxValue;
            for (int i = 0; i < stack.Count; i++)
            {
                int currentNumber = stack.Pop();

                if (currentNumber < maxNumber)
                {
                    maxNumber = currentNumber;
                }
            }
            if (maxNumber == int.MaxValue)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(maxNumber);
            }
        }
    }
}