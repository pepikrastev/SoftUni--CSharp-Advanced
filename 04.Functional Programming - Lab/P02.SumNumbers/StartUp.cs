using System;
using System.Linq;

namespace P02.SumNumbers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Func<string, int> parser = int.Parse;

            int[] sequence = input
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(parser)// or int.Parse
                .ToArray();

            Console.WriteLine(sequence .Length);
            Console.WriteLine(sequence .Sum());
        }
    }
}
