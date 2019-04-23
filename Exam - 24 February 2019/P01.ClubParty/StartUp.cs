using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.ClubParty
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Queue<string> halls = new Queue<string>();
            Queue<int> hallWithPeople = new Queue<int>();

            int capacity = int.Parse(Console.ReadLine());
            int temporaryCapacity = capacity;

            var input = Console.ReadLine().Split().Reverse();

            foreach (var element in input)
            {
                if (char.IsLetter(element[0]))
                {
                    halls.Enqueue(element);
                }

                else
                {
                    int people = int.Parse(element);

                    while (halls.Count > 0)
                    {
                        if (temporaryCapacity >= people)
                        {
                            hallWithPeople.Enqueue(people);
                            temporaryCapacity -= people;
                            break;
                        }

                        else
                        {
                            Console.WriteLine($"{halls.Dequeue()} -> {string.Join(", ", hallWithPeople)}");
                        }

                        hallWithPeople.Clear();
                        temporaryCapacity = capacity;
                    }
                }
            }
        }
    }
}
