namespace ObserverPattern
{
    class Program
    {
        static void Main()
        {
            Termometer termometer = new Termometer();
            termometer.Register(new Phone());
            termometer.Register(new Computer());

            termometer.Temperature = 32;
            termometer.Temperature = 28;
            termometer.Temperature = 26;
        }
    }
}
