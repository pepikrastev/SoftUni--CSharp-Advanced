using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main(string[] args)
    {
        int bulletPrice = int.Parse(Console.ReadLine());
        int barrelSize = int.Parse(Console.ReadLine());
        int[] bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] locks = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int money = int.Parse(Console.ReadLine());

        Stack<int> bulletsValue = new Stack<int>(bullets);
        Stack<int> locksValue = new Stack<int>(locks.Reverse());

        int bulletCount = bulletsValue.Count;

        for (int i = 1; bulletsValue.Any() && locksValue.Any(); i++)
        {
            int bullet = bulletsValue.Pop();
            int @lock = locksValue.Pop();

            if (bullet > @lock)
            {
                Console.WriteLine("Ping!");
                locksValue.Push(@lock);
            }
            else if (bullet <= @lock)
            {
                Console.WriteLine("Bang!");
            }

            if (i == barrelSize && bulletsValue.Any())
            {
                Console.WriteLine("Reloading!");
                i = 0;
            }
        }

        if (locksValue.Any())
        {
            Console.WriteLine($"Couldn't get through. Locks left: {locksValue.Count}");
        }
        else
        {
            Console.WriteLine($"{bulletsValue.Count} bullets left. Earned ${money - (bulletCount - bulletsValue.Count) * bulletPrice}");
        }
    }
}