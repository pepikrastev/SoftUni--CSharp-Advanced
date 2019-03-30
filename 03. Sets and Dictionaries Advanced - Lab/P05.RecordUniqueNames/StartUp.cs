﻿using System;
using System.Collections.Generic;

namespace P05.RecordUniqueNames
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < number; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}