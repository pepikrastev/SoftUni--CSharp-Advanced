using System;
using System.Collections.Generic;
using System.Text;

namespace P08.RawData
{
   public class Tire
   {
       private int age;
       private double tirePressure;

        public Tire(double tirePressure, int age)
        {
            this.TirePressure = tirePressure;
            this.age = age;
        }

        public double TirePressure { get => tirePressure; set => tirePressure = value; }
    }
}
