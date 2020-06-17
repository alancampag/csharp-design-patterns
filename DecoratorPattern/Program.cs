using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza customPizza = new ChickenDecorator(new TomatoDecorator(new ClassicPizza()));

            Console.WriteLine(customPizza.Cost());
        }
    }
}
