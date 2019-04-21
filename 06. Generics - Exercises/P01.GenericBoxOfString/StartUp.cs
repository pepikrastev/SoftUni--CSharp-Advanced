using System;

namespace P01.GenericBoxOfString
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string text = Console.ReadLine();
                Box<string> box = new Box<string>(text);
                Console.WriteLine(box);
            }
        }
    }
}
