using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main()
        {
            // we can keep wraping the original object with decorators, adding functionality
            Pizza customPizza = new ChickenDecorator(new TomatoDecorator(new ClassicPizza()));

            // in this case the costs are added
            Console.WriteLine(customPizza.Cost());
        }
    }
}
