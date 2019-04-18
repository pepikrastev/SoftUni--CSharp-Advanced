using System;
using System.Collections.Generic;
using System.Text;

namespace P07.SpeedRacing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionFor1km;
        private double distance;

        public Car(string model, double fuelAmount, double fuelConsumptionFor1km)
        {
           this.Model = model;
           this.FuelAmount = fuelAmount;
           this.FuelConsumptionFor1km = fuelConsumptionFor1km;
           this.distance = 0;
        }

        public string Model { get => model; set => model = value; }
        public double FuelAmount { get => fuelAmount; set => fuelAmount = value; }
        public double FuelConsumptionFor1km { get => fuelConsumptionFor1km; set => fuelConsumptionFor1km = value; }

        public void DriveCar(double amountOfKm)
        {
            if (this.FuelAmount - (this.FuelConsumptionFor1km * amountOfKm) >= 0)
            {
                this.FuelAmount -= this.FuelConsumptionFor1km * amountOfKm;
                this.distance += amountOfKm;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        public override string ToString()
        {
            return $"{this.Model} {this.FuelAmount:f2} {this.distance}";
        }
    }
}
