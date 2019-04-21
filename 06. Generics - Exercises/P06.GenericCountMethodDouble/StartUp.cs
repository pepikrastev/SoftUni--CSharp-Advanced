﻿using System;
using System.Collections.Generic;

namespace P06.GenericCountMethodDouble
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());

            Box<double> box = new Box<double>();

            for (int i = 0; i < linesCount; i++)
            {
                double line = double.Parse(Console.ReadLine());
                box.Add(line);
            }

            double element = double.Parse(Console.ReadLine());

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
