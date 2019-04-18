using System;
using System.Collections.Generic;
using System.Text;

namespace P08.RawData
{
    public class Cargo
    {
        private int weight;
        private string cargoType;

        public Cargo(int weight, string type)
        {
            this.weight = weight;
            this.CargoType = type;
        }

        public string CargoType { get => cargoType; set => cargoType = value; }
    }
}
