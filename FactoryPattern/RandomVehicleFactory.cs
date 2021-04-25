using System;

namespace FactoryMethodPattern
{
    class RandomVehicleFactory : IVehicleFactory
    {
        public IVehicle GetVehicle()
        {
            int randomNumber;
            randomNumber = new Random().Next(2);

            return randomNumber switch
            {
                0 => new Car(),
                1 => new Truck(),
                _ => null,
            };
        }
    }
}
