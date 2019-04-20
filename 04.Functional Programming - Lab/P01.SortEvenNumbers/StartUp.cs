using System;
using System.Linq;

namespace P01.SortEvenNumbers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var sequence = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(Parse)
                .Where(Filter)
                .OrderBy(Sort)
                .ToArray();


            Console.WriteLine(string.Join(", ", sequence));

            //or...
            //int[] sequence = Console.ReadLine()
            //    .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .Where(x => x % 2 == 0)
            //    .ToArray();

            //Console.WriteLine(string.Join(", ", sequence.OrderBy(x => x)));
        }

        private static int Sort(int number)
        {
            return number;
        }

        private static bool Filter(int x)
        {
            return x % 2 == 0;
        }

        private static int Parse(string x)
        {
            return int.Parse(x);
        }
    }
}
