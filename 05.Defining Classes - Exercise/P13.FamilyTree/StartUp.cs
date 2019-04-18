﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace P13.FamilyTree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string inputLine = Console.ReadLine();

            List<Person> people = new List<Person>();
            List<string> commands = new List<string>();

            while (inputLine != "End")
            {
                string[] information = inputLine.Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                if (information.Length == 1)
                {
                    string[] informationForPerson = information[0].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    string name = $"{informationForPerson[0]} {informationForPerson[1]}";
                    string birthday = informationForPerson[2];

                    if (!people.Any(x => x.Name == name))
                    {
                        Person currentPerson = new Person(name, birthday);
                        people.Add(currentPerson);
                    }
                }
                else
                {
                    commands.Add(inputLine);
                }

                inputLine = Console.ReadLine();
            }

            foreach (string command in commands)
            {
                string[] information = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string parent = information[0];
                string child = information[1];

                Person currentPerson;
                if (parent.Split(" ", StringSplitOptions.RemoveEmptyEntries).Count() == 1)
                {
                    currentPerson = people.FirstOrDefault(x => x.Birthday == parent);
                }
                else
                {
                    currentPerson = people.FirstOrDefault(x => x.Name == parent);
                }

                currentPerson.Children.Add(child);

                if (child.Split(" ", StringSplitOptions.RemoveEmptyEntries).Count() == 1)
                {
                    currentPerson = people.FirstOrDefault(x => x.Birthday == child);
                }
                else
                {
                    currentPerson = people.FirstOrDefault(x => x.Name == child);
                }

                currentPerson.Perents.Add(parent);
            }

            Person person;
            if (input.Length == 1)
            {
                person = people.FirstOrDefault(x => x.Birthday == input[0]);
            }
            else
            {
                string name = $"{input[0]} {input[1]}";
                person = people.FirstOrDefault(x => x.Name == name);
            }

            Console.WriteLine($"{person.Name} {person.Birthday}");
            Console.WriteLine("Parents:");
            foreach (string parent in person.Perents)
            {
                Person currentParent;
                if (parent.Split(" ", StringSplitOptions.RemoveEmptyEntries).Count() == 2)
                {
                    currentParent = people.FirstOrDefault(x => x.Name == parent);
                }
                else
                {
                    currentParent = people.FirstOrDefault(x => x.Birthday == parent);
                }

                Console.WriteLine($"{currentParent.Name} {currentParent.Birthday}");
            }

            Console.WriteLine("Children:");
            foreach (string child in person.Children)
            {
                Person currentChild;
                if (child.Split(" ", StringSplitOptions.RemoveEmptyEntries).Count() == 2)
                {
                    currentChild = people.FirstOrDefault(x => x.Name == child);
                }
                else
                {
                    currentChild = people.FirstOrDefault(x => x.Birthday == child);
                }

                Console.WriteLine($"{currentChild.Name} {currentChild.Birthday}");
            }
        }
    }
}
