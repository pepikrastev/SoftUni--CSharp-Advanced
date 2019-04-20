using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.FindEvensOrOdds
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] rangeArgs = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int start = rangeArgs[0];
            int end = rangeArgs[1];

            string typeNumbers = Console.ReadLine();

            List<int> numbers = new List<int>();

            //Predicate<int> filter = x => typeNumbers == "odd" ? x % 2 != 0 : x % 2 == 0; 
            Func<int, bool> filter = x => typeNumbers == "odd" ? x % 2 != 0 : x % 2 == 0;

            for (int i = start; i <= end; i++)
            {
                numbers.Add(i);
            }

            Console.WriteLine(string.Join(" ", numbers.Where(filter)));
        }
    }
}
