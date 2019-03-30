using System;
using System.Collections.Generic;

namespace P01.UniqueUsernames
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            HashSet<string> guest = new HashSet<string>();

            for (int i = 0; i < number; i++)
            {
                string name = Console.ReadLine();

                guest.Add(name);
            }
            Console.WriteLine(string.Join(Environment.NewLine, guest));
        }
    }
}
