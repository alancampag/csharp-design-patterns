using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    abstract class Vehicle
    {
        protected ICargoMechanism cargoMechanism;
        protected IFlyingMechanism flyingMechanism;

        public abstract void Start();
    }
}
