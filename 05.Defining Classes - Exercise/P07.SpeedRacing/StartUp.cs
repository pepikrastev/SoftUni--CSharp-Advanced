using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.SpeedRacing
{
   public  class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carInformation = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = carInformation[0];
                double fuelAmount = double.Parse(carInformation[1]);
                double fuelConsumptionFor1km = double.Parse(carInformation[2]);

                Car currentCar = new Car(model, fuelAmount, fuelConsumptionFor1km);

                cars.Add(currentCar);
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = input[0];

                if (command == "End")
                {
                    break;
                }

                if (command == "Drive")
                {
                    string model = input[1];
                    double distance = double.Parse(input[2]);

                    Car car = cars.Where(x => x.Model == model).FirstOrDefault();

                    car.DriveCar(distance);

                    car.Model = "bimi";
                    car.FuelAmount = 12;
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
