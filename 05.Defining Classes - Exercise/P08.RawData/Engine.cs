﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P08.RawData
{
    public class Engine
    {
        private int speed;
        private int power;

        public Engine(int speed, int power)
        {
            this.speed = speed;
            this.Power = power;
        }

        public int Power { get => power; set => power = value; }
    }
}
