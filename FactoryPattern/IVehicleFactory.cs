using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    interface IVehicleFactory
    {
        public IVehicle GetVehicle(string vehicleType);
    }
}
