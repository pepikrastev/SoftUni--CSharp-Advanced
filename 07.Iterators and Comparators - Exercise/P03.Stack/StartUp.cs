using System;
using System.Linq;

namespace P03.Stack
{
    class StartUp
    {
        static void Main(string[] args)
        {
            CustomStack<int> stack = new CustomStack<int>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                string[] splitedInput = input.Split(" ", 2);

                string command = splitedInput[0];

                if (command == "Push")
                {
                    int[] numbers = splitedInput[1].Split(", ").Select(int.Parse).ToArray();
                    stack.Push(numbers);
                }
                else
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message);
                    }

                }
            }

            for (int i = 0; i < 2; i++)
            {
                foreach (var item in stack)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
