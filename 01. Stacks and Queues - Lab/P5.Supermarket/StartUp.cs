using System;
using System.Collections.Generic;
using System.Text;

class StartUp
{
    static void Main(string[] args)
    {
        StringBuilder stringBuilder = new StringBuilder();

        Queue<string> names = new Queue<string>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "End")
            {
                break;
            }
            else if (input == "Paid")
            {
                while (names.Count > 0)
                {
                    stringBuilder.AppendLine(names.Dequeue());
                }
            }
            else
            {
                names.Enqueue(input);
            }
        }

        stringBuilder.AppendLine($"{names.Count} people remaining.");

        Console.Write(stringBuilder);
    }
}