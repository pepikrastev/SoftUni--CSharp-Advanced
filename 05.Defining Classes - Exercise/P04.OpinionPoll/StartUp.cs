using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace P04.OpinionPoll
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] personArgs = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Person person = new Person(personArgs[0], int.Parse(personArgs[1]));
                
                people.Add(person);
            }

            people = people.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList();

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}
