using System;
using System.Collections.Generic;
using System.Linq;

namespace P08.PetClinic
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int lineCount = int.Parse(Console.ReadLine());

            List<Pet> pets = new List<Pet>();
            List<Clinic> clinics = new List<Clinic>();

            for (int i = 0; i < lineCount; i++)
            {
                string[] commandArgs = Console.ReadLine().Split();
                string command = commandArgs[0];

                if (command == "Create")
                {
                    string typeObject = commandArgs[1];

                    if (typeObject == "Pet")
                    {
                        string name = commandArgs[2];
                        int age = int.Parse(commandArgs[3]);
                        string kind = commandArgs[4];

                        Pet pet = new Pet(name, age, kind);
                        pets.Add(pet);
                    }
                    else if (typeObject == "Clinic")
                    {
                        string name = commandArgs[2];
                        int rooms = int.Parse(commandArgs[3]);

                        try
                        {
                            Clinic clinic = new Clinic(name, rooms);
                            clinics.Add(clinic);
                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine(ex.Message);
                        }
                    }
                }
                else if (command == "HasEmptyRooms")
                {
                    string name = commandArgs[1];
                    Clinic clinic = clinics.FirstOrDefault(x => x.Name == name);

                    if (clinic != null)
                    {
                        Console.WriteLine(clinic.HasEmptyRooms());
                    }
                }
                else if (command == "Release")
                {
                    string name = commandArgs[1];
                    Clinic clinic = clinics.FirstOrDefault(x => x.Name == name);

                    if (clinic != null)
                    {
                        Console.WriteLine(clinic.Release());
                    }
                }
                else if (command == "Add")
                {
                    string petName = commandArgs[1];
                    string clinicName = commandArgs[2];
                    Pet pet = pets.FirstOrDefault(x => x.Name == petName);
                    Clinic clinic = clinics.FirstOrDefault(x => x.Name == clinicName);

                    if (pet != null && clinic != null)
                    {
                        Console.WriteLine(clinic.AddPet(pet));
                    }
                }
                else if (command == "Print")
                {
                    string clinicName = commandArgs[1];
                    Clinic clinic = clinics.FirstOrDefault(x => x.Name == clinicName);
                    if (clinic != null)
                    {
                        if (commandArgs.Length == 2)
                        {
                            Console.WriteLine(clinic);
                        }
                        else
                        {
                            int roomNumber = int.Parse(commandArgs[2]);
                            Console.WriteLine(clinic.GetPet(roomNumber));
                        }
                    }

                }
            }
        }
    }
}
