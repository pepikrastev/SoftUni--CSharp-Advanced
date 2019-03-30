using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.AverageStudentGrades
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> list = new Dictionary<string, List<double>>();

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split();

                string name = input[0];
                double grade = double.Parse(input[1]);

                if (!list.ContainsKey(name))
                {
                    list[name] = new List<double>();
                }

                list[name].Add(grade);
            }

            foreach (var kvp in list)
            {
                Console.Write(kvp.Key + " -> ");

                foreach (var secondItem in kvp.Value)
                {
                    Console.Write($"{secondItem:f2} ");
                }
                Console.WriteLine($"(avg: {kvp.Value.Average():f2})");
            }
        }
    }
}
