using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Queue<string> cars = new Queue<string>();

        int counter = 0;

        while (true)
        {
            string command = Console.ReadLine();

            if (command == "end")
            {
                break;
            }
            else if (command == "green")
            {

                int min = Math.Min(n, cars.Count());

                for (int i = 0; i < min; i++)
                {
                    Console.WriteLine($"{cars.Dequeue()} passed!");
                    counter++;
                }
            }
            else
            {
                cars.Enqueue(command);
            }
        }

        Console.WriteLine($"{counter} cars passed the crossroads.");
    }

}
