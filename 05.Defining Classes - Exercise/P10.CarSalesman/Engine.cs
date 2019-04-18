using System;
using System.Collections.Generic;
using System.Text;

namespace P10.CarSalesman
{
    public class Engine
    {
        private const string DefaultValueString = "n/a";
        private const int DefaultValueInt = -1;

        private string model;
        private int power;
        private int displacement;
        private string efficiency;

        

        public Engine(string model, int power, int displacement, string efficiency)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }

        public Engine(string model, int power, string efficiency) 
            : this(model, power, DefaultValueInt, efficiency)
        {
        }

        public Engine(string model, int power, int displacement) 
            : this(model, power, displacement, DefaultValueString)
        {
        }

        public Engine(string model, int power) 
            : this(model, power, DefaultValueInt, DefaultValueString)
        {
        }

        public string Model { get => model; set => model = value; }
        public int Power { get => power; set => power = value; }
        public int Displacement { get => displacement; set => displacement = value; }
        public string Efficiency { get => efficiency; set => efficiency = value; }
    }
}
