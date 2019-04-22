using System;
using System.Linq;

namespace P02.Collection
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ListyIterator<string> listyIterator = null;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                string[] splitedInput = input.Split();

                string command = splitedInput[0];

                if (command == "Create")
                {
                    listyIterator = new ListyIterator<string>(splitedInput.Skip(1).ToList());
                }
                else if (command == "Move")
                {
                    Console.WriteLine(listyIterator.Move());
                }
                else if (command == "Print")
                {
                    Console.WriteLine(listyIterator.Print());
                }
                else if (command == "HasNext")
                {
                    Console.WriteLine(listyIterator.HasNext());
                }
                else if (command == "PrintAll")
                {
                    Console.WriteLine(string.Join(" ", listyIterator));
                }
            }
        }
    }
}
