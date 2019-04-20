using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.KnightsOfHonor
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split()
                .ToList();

            Func<string, string> format = x => $"Sir {x}";

            Action<List<string>> action = x => Console.WriteLine(string.Join(Environment.NewLine, x.Select(format)));

            action(input);
        }
    }
}
