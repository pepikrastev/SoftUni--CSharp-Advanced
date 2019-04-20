using System;
using System.Linq;

namespace P08.CustomComparator
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Array.Sort(numbers);

            int[] num = numbers;

            Console.Write(string.Join(" ", numbers.Where(x => x % 2 == 0)) + " ");
            Console.WriteLine(string.Join(" ", num.Where(x => x % 2 != 0)));
        }
    }
}
