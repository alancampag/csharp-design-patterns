using System;

namespace ObserverPattern
{
    class Phone : IObserver
    {
        private int temperature;
        public void Update(IObservable observable)
        {
            this.temperature = ((Termometer)observable).Temperature;
            Console.WriteLine($"Phone shows: {temperature} Celsius");
        }
    }

}
