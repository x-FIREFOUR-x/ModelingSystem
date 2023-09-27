﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Model.DelayGenerator
{
    public class ExponentialDelayGenerator : IDelayGenerator
    {
        private double _averageDelay;

        private Random _random;

        public ExponentialDelayGenerator(double averageDelay)
        {
            _averageDelay = averageDelay;

            _random = new Random();
        }

        public double GetDelay()
        {
            float randNumber = (float)_random.NextDouble();

            if (randNumber == 0)
                randNumber = float.Epsilon;

            return -_averageDelay * MathF.Log(randNumber);
        }
    }
}
