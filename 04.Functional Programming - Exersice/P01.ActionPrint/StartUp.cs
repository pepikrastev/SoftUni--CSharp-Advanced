using System;

namespace P01.ActionPrint
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Action<string[]> print = x => Console.WriteLine(string.Join(Environment.NewLine, x));

            print(input);
        }
    }
}
