using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int tires)
        {
            switch (tires)
            {
                case 4:
                    return new Car();

                case 2:
                    return new Motorcycle();

                case 18:
                    return new SemiTruck();

                default:
                    return new Car();
            }
        }
    }
}
