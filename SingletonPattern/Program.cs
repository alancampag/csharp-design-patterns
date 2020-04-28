using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main()
        {
            Singleton singleton = Singleton.GetInstance();
            singleton.SayHello();
        }
    }
}
