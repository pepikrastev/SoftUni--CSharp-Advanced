using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.ReverseAndExclude
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Reverse()
                .ToList();

            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Join(" ", numbers.Where(x => x % number != 0)));
        }
    }
}
