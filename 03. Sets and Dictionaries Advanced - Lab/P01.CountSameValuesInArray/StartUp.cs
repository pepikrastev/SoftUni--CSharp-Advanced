using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.CountSameValuesInArray
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double[] sequence = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Dictionary<double, int> dictionary= new Dictionary<double, int>();

            foreach (var number in sequence)
            {
                if (!dictionary.ContainsKey(number))
                {
                    dictionary[number] = 0;
                }
                dictionary[number]++;
            }

            foreach (var number in dictionary)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }
    }
}
