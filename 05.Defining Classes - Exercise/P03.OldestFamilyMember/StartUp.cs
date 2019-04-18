using System;
using DefiningClasses;

namespace P03.OldestFamilyMember
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Family family = new Family();

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] personArgs = Console.ReadLine().Split(new char[]{ ' ' },StringSplitOptions.RemoveEmptyEntries);

                Person person = new Person(personArgs[0], int.Parse(personArgs[1]));

                family.AddMember(person);
            }

            Person oldestMember = family.GetOldestMember();
            Console.WriteLine(oldestMember);
        }
    }
}
