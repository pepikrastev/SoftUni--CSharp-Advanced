﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P12.Google
{
    public class Car
    {
        public Car(string model, int speed)
        {
            this.Model = model;
            this.Speed = speed;
        }
        public string Model { get; set; }

        public int Speed { get; set; }
    }
}
