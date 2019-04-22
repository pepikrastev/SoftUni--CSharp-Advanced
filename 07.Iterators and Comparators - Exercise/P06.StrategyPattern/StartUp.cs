using System;
using System.Collections.Generic;

namespace P06.StrategyPattern
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());

            SortedSet<Person> setByName = new SortedSet<Person>(new PersonNameLangthComparer());
            SortedSet<Person> setByAge = new SortedSet<Person>(new PersonAgeComparer());

            for (int i = 0; i < linesCount; i++)
            {
                string[] personArgs = Console.ReadLine().Split();

                string name = personArgs[0];
                int age = int.Parse(personArgs[1]);

                Person person = new Person(name, age);

                setByName.Add(person);
                setByAge.Add(person);
            }

            foreach (var person in setByName)
            {
                Console.WriteLine(person.Name + " " + person.Age);
            }

            foreach (var person in setByAge)
            {
                Console.WriteLine(person.Name + " " + person.Age);
            }
        }
    }
}
