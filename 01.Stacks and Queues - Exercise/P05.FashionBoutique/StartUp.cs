using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main(string[] args)
    {
        int[] inputValues = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int rackCapacity = int.Parse(Console.ReadLine());

        Stack<int> clothesValues = new Stack<int>(inputValues.Reverse());

        int countOfRacks = 1;
        int currentRackCapacity = 0;

        while (clothesValues.Any())
        {
            if (currentRackCapacity + clothesValues.Peek() <= rackCapacity)
            {
                currentRackCapacity += clothesValues.Pop();
            }
            else
            {
                currentRackCapacity = 0;
                countOfRacks++;
            }
        }

        Console.WriteLine(countOfRacks);
    }
}

