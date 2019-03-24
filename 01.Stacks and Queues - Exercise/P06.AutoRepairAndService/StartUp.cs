using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class StartUp
{
    static void Main(string[] args)
    {
        string[] cars = Console.ReadLine().Split();

        Queue<string> notServed = new Queue<string>(cars);
        Stack<string> served = new Stack<string>();

        StringBuilder text = new StringBuilder();

        while (true)
        {
            string[] input = Console.ReadLine().Split('-', StringSplitOptions.RemoveEmptyEntries);

            string command = input[0];

            if (command == "End")
            {
                break;
            }

            else if (command == "Service")
            {
                if (notServed.Any() == false)
                {
                    continue;
                }
                string servedCar = notServed.Dequeue();
                text.AppendLine($"Vehicle {servedCar} got served.");
                served.Push(servedCar);
            }
            else if (command == "CarInfo")
            {
                string car = input[1];
                if (served.Contains(car))
                {
                    text.AppendLine("Served.");
                }
                else if (notServed.Contains(car))
                {
                    text.AppendLine("Still waiting for service.");
                }
            }
            else if (command == "History")
            {
                text.AppendLine(string.Join(", ", served));
            }
        }

        if (notServed.Any())
        {
            text.AppendLine($"Vehicles for service: {string.Join(", ", notServed)}");
        }

        if (served.Any())
        {
            text.AppendLine($"Served vehicles: { string.Join(", ", served)}");
        }

        Console.WriteLine(text);
    }
}