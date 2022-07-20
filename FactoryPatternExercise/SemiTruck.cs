﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    public class SemiTruck : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a truck");
        }
    }
}
