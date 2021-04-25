using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main()
        {
            // only a single instance of singleton will ever exists
            Singleton singleton1 = Singleton.GetInstance();

            // trying to create a new one will return a reference to the old one
            Singleton singleton2 = Singleton.GetInstance();

            Console.WriteLine(singleton1 == singleton2); // true, they are the same object
        }
    }
}
