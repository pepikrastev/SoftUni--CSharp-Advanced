using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.SetsOfElements
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            HashSet<int> hashSetN = new HashSet<int>();
            HashSet<int> hashSetM = new HashSet<int>();

            for (int i = 0; i < input[0]; i++)
            {
                int n = int.Parse(Console.ReadLine());

                hashSetN.Add(n);
            }

            for (int i = 0; i < input[1]; i++)
            {
                int m = int.Parse(Console.ReadLine());

                hashSetM.Add(m);
            }

            Console.WriteLine(string.Join(" ", hashSetN.Intersect(hashSetM)));
        }
    }
}
