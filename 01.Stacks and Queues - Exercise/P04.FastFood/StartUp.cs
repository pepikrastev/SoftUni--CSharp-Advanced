using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main(string[] args)
    {
        int quantityOfFood = int.Parse(Console.ReadLine());

        int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Queue<int> queue = new Queue<int>(orders);

        Console.WriteLine(queue.Max());

        if (quantityOfFood >= queue.Sum())
        {
            Console.WriteLine("Orders complete");
        }
        else
        {
            while (quantityOfFood > queue.Peek())
            {
                quantityOfFood -= queue.Dequeue();
            }

            Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
        }
    }
}