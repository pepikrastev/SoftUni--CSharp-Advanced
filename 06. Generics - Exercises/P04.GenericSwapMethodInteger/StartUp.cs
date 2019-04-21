using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.GenericSwapMethodInteger
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());

            Box<int> box = new Box<int>();

            for (int i = 0; i < linesCount; i++)
            {
                int line = int.Parse(Console.ReadLine());
                box.Add(line);
            }

            int[] indexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int firstIndex = indexes[0];
            int secondIndex = indexes[1];

            box.Swap(firstIndex, secondIndex);

            Console.WriteLine(box);
        }
    }
    
}
