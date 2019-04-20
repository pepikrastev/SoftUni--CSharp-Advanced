using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.Add_VAT
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<double> sequence = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(x => x * 1.2)
                .ToList();

            foreach (var number in sequence)
            {
                Console.WriteLine($"{number:F2}");
            }
        }
    }
}
