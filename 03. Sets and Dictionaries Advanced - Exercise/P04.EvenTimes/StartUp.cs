using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.EvenTimes
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Dictionary<int, int> numberCount = new Dictionary<int, int>();

            for (int i = 0; i < number; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (!numberCount.ContainsKey(num))
                {
                    numberCount[num] = 0;
                }

                numberCount[num]++;
            }

            foreach (var item in numberCount.Where(x => x.Value % 2 == 0))
            {

                Console.WriteLine(item.Key);

            }
        }
    }
}
