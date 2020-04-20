using System;

namespace ObserverPattern
{
    class Computer : IObserver
    {
        private int temperature;
        public void Update(IObservable observable)
        {
            this.temperature = ((Termometer)observable).Temperature;
            Console.WriteLine($"Computer shows: {temperature} Celsius");
        }
    }
}
