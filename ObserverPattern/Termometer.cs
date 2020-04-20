using System.Collections.Generic;

namespace ObserverPattern
{
    class Termometer : IObservable
    {
        private int temperature;
        public int Temperature
        {
            get
            {
                return temperature;
            }
            set
            {
                temperature = value;
                Notify();
            }
        }

        readonly List<IObserver> observers;

        public Termometer()
        {
            this.observers = new List<IObserver>();
        }

        public void Register(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void Remove(IObserver observer)
        {
            this.observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(this);
            }
        }
    }
}
