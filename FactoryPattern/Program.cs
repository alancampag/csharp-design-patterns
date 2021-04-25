namespace FactoryMethodPattern
{
    class Program
    {
        static void Main()
        {
            // the factory encapsulates the object creation logic
            IVehicleFactory vehicleFactory = new RandomVehicleFactory();

            // in this one, vehicle type gets decided randomly at runtime
            IVehicle vehicle = vehicleFactory.GetVehicle();
            vehicle.Start();

            // this factory alternates between different vehicle types
            vehicleFactory = new BalancedVehicleFactory();

            // we swapped the creation logic, the rest of the code still works
            vehicle = vehicleFactory.GetVehicle();
            vehicle.Start();
        }
    }
}
