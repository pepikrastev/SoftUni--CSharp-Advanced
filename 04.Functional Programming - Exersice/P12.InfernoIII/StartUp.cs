using System;
using System.Collections.Generic;
using System.Linq;

namespace P12.InfernoIII
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();

            List<int> active = Enumerable.Range(0, sequence .Count)
                .ToList();

            List<int> allIndices = new List<int>(active);

            Func<int, int, bool> sumLeft = (b, c) => b == 0 ? sequence [b] == c : sequence [b] + sequence [b - 1] == c;
            Func<int, int, bool> sumRight = (a, b) =>
            a == sequence .Count - 1 ? sequence [a] == b : sequence [a] + sequence [a + 1] == b;
            Func<int, int, bool> sumBoth = (a, b) =>
            sequence .Count == 1 ? sequence [0] == b : a == 0 ? sequence [a] + sequence [a + 1] == b : a == sequence .Count - 1 ? sequence [a] + sequence [a - 1] == b : sequence [a - 1] + sequence [a] + sequence [a + 1] == b;

            string command;

            while ((command = Console.ReadLine()) != "Forge")
            {
                string[] commandArgs = command
                    .Split(';');

                int sum = int.Parse(commandArgs[2]);

                List<int> current = new List<int>();

                switch (commandArgs[1])
                {
                    case "Sum Left":
                        current = allIndices.Where(i => sumLeft(i, sum)).ToList();
                        break;
                    case "Sum Right":
                        current = allIndices.Where(i => sumRight(i, sum)).ToList();
                        break;
                    case "Sum Left Right":
                        current = allIndices.Where(i => sumBoth(i, sum)).ToList();
                        break;
                }

                switch (commandArgs[0])
                {
                    case "Exclude":
                        active.RemoveAll(i => current.Contains(i));
                        break;
                    case "Reverse":
                        active.AddRange(current);
                        break;
                }

            }

            Console.WriteLine(String.Join(" ", sequence .Where((item, index) => active.Contains(index))));
        }
    }
}
