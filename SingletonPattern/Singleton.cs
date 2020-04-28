using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    class Singleton
    {
        private static Singleton instance = null;

        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (Singleton.instance == null)
            {
                Singleton.instance = new Singleton();
            }
            return Singleton.instance;
        }

        public void SayHello()
        {
            Console.WriteLine("Singleton says hello");
        }
    }
}
