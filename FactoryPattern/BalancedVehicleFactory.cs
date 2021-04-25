namespace FactoryMethodPattern
{
    class BalancedVehicleFactory : IVehicleFactory
    {
        private int vehicleTypeTracker = 0;

        public IVehicle GetVehicle()
        {
            vehicleTypeTracker = (vehicleTypeTracker + 1) % 2;

            return vehicleTypeTracker switch
            {
                0 => new Car(),
                1 => new Truck(),
                _ => null,
            };
        }
    }
}

