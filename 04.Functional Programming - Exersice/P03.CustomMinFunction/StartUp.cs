using System;
using System.Linq;

namespace P03.CustomMinFunction
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int[], int> func = x => x.Min();

            Console.WriteLine(func(input));
        }
    }
}
