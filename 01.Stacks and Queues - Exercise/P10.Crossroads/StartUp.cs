using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main(string[] args)
    {
        int greenLight = int.Parse(Console.ReadLine());
        int freeWindow = int.Parse(Console.ReadLine());

        Queue<string> line = new Queue<string>();

        int totalCarPassed = 0;

        while (true)
        {
            string command = Console.ReadLine();
            if (command?.ToLower() == "end")
            {
                break;
            }

            if (command != "green")
            {
                line.Enqueue(command);
                continue;
            }

            int currGreenLight = greenLight;
            string passingCars = null;

            while (currGreenLight > 0 && line.Any())
            {
                passingCars = line.Dequeue();
                currGreenLight -= passingCars.Length;
                totalCarPassed++;
            }

            int freeWindowLeft = freeWindow + currGreenLight;

            if (freeWindowLeft < 0)
            {
                int symbolsDidntPass = Math.Abs(freeWindowLeft);
                int indexOfHitSymbols = passingCars.Length - symbolsDidntPass;
                char symbolHit = passingCars[indexOfHitSymbols];
                Crash(passingCars, symbolHit);
            }
        }
        Console.WriteLine("Everyone is safe.");
        Console.WriteLine($"{totalCarPassed} total cars passed the crossroads.");
    }

    private static void Crash(string car, char symbolHit)
    {
        Console.WriteLine("A crash happened!");
        Console.WriteLine($"{car} was hit at {symbolHit}.");
        Environment.Exit(0);
    }
}