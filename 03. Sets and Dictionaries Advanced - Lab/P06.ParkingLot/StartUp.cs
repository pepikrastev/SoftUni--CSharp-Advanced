using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.ParkingLot
{
    class StartUp
    {
        static void Main(string[] args)
        {
            HashSet<string> cars = new HashSet<string>();

            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "END")
                {
                    break;
                }

                string command = input[0];
                string carNumber = input[1];

                if (command == "IN")
                {
                    cars.Add(carNumber);
                }
                else if (command == "OUT")
                {
                    cars.Remove(carNumber);
                }
            }

            if (cars.Any())
            {
                Console.WriteLine(string.Join(Environment.NewLine, cars));
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
