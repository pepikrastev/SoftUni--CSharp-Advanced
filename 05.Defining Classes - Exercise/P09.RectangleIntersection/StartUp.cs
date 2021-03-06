﻿using System;
using System.Linq;

namespace P09.RectangleIntersection
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            int[] counts = Console.ReadLine()
                .Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Rectangle[] rectangles = new Rectangle[counts[0]];

            for (int i = 0; i < counts[0]; i++)
            {
                string[] tokens = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                string id = tokens[0];
                double width = double.Parse(tokens[1]);
                double height = double.Parse(tokens[2]);
                double x = double.Parse(tokens[3]);
                double y = double.Parse(tokens[4]);

                rectangles[i] = new Rectangle(id, width, height, x, y);
            }

            for (int i = 0; i < counts[1]; i++)
            {
                string[] tokens = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                Rectangle rectangle = rectangles.Where(r => r.Id == tokens[0]).First();
                Rectangle secondRectangle = rectangles.Where(r => r.Id == tokens[1]).First();
                //Console.WriteLine(rectangle.CheckIfTheyCross(secondRectangle));

                if (rectangle.CheckIfTheyCross(secondRectangle))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}
