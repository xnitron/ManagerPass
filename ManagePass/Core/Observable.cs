using System.Collections.Generic;

namespace PasswordManager
{
    public abstract class Observable
    {
        private List<IObserver> observers = new List<IObserver>();

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        protected void NotifyObservers()
        {
            foreach (IObserver o in observers)
            {
                o.Update();
            }
        }
    }
}
