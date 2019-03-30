using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.CountSymbols
{
    class StartUp
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            Dictionary<char, int> characters = new Dictionary<char, int>();

            for (int i = 0; i < input.Count(); i++)
            {
                char letter = input[i];
                if (!characters.ContainsKey(letter))
                {
                    characters[letter] = 0;
                }
                characters[letter]++;
            }

            foreach (var letter in characters.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{letter.Key}: {letter.Value} time/s");
            }
        }
    }
}
