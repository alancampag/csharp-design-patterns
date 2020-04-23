using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    interface IVehicleFactory
    {
        public Vehicle GetVehicle(string vehicleType);
    }
}
