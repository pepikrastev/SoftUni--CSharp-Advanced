using System;
using System.Collections.Generic;
using System.Linq;

namespace P09.ListOfPredicates
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int endRange = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            List<int> sequence = new List<int>();

            for (int i = 1; i <= endRange; i++)
            {
                sequence.Add(i);
            }

            for (int i = 0; i < dividers.Length; i++)
            {
                sequence = sequence.Where(x => x % dividers[i] == 0).ToList();
            }

            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}
