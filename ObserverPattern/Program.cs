namespace ObserverPattern
{
    class Program
    {
        static void Main()
        {
            // termometer is the publisher of temperatures
            Termometer termometer = new Termometer();

            // phone and computer subscribe to temperature readings
            termometer.Register(new Phone());
            termometer.Register(new Computer());

            // everytime temperature cahnges, subscribers get notified
            termometer.Temperature = 32;
            termometer.Temperature = 28;
            termometer.Temperature = 26;
        }
    }
}
