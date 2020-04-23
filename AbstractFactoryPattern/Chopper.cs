using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class Chopper : Vehicle
    {
        public Chopper(AirVehicleFactory vehicleFactory)
        {
            this.flyingMechanism = vehicleFactory.AddFlyingMechanism();
        }

        public override void Start()
        {
            Console.WriteLine("The chopper starts...");
        }

        public void TakeOff()
        {
            this.flyingMechanism.TakeOff();
        }
    }
}
