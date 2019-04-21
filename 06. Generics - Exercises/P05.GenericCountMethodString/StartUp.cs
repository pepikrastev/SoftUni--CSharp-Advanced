using System;
using System.Collections.Generic;

namespace P05.GenericCountMethodString
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());

            Box<string> box = new Box<string>();

            for (int i = 0; i < linesCount; i++)
            {
                string line = Console.ReadLine();
                box.Add(line);
            }

            string element = Console.ReadLine();

            int count = GetCountOfGreaterElement(box.Data, element);

            Console.WriteLine(count);
        }

        public static int GetCountOfGreaterElement<T>(List<T> listWithData, T element)
            where T : IComparable
        {
            int count = 0;

            foreach (var item in listWithData)
            {
                if (item.CompareTo(element) > 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
