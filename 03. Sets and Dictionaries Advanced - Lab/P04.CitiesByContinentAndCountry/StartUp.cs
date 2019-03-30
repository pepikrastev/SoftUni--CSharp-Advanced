using System;
using System.Collections.Generic;

namespace P04.CitiesByContinentAndCountry
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split();

                string continent = input[0];
                string contry = input[1];
                string city = input[2];

                if (!continents.ContainsKey(continent))
                {
                    continents[continent] = new Dictionary<string, List<string>>();
                }

                if (!continents[continent].ContainsKey(contry))
                {
                    continents[continent][contry] = new List<string>();
                }

                continents[continent][contry].Add(city);
            }

            foreach (var kvp in continents)
            {
                Console.WriteLine($"{kvp.Key}:");
                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"    {item.Key} -> {string.Join(", ", item.Value)}");
                }
            }
        }
    }
}
