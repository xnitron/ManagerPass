using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace PasswordManager
{
    public class View : IView, IObservable, IObserver
    {
        public string Site { get; set; }
        public string Password { get; set; }
        NameValueCollection newPass = new NameValueCollection();
        private List<IObserver> observers;
        Model model;


        public View(Model model)
        {
            observers = new List<IObserver>();
            this.model = model;
            this.RegisterObserver(this);
            this.NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in observers)
            {
                o.Update();
            }
        }

        public void Update()
        {
            Console.WriteLine("New Password or View created passwords(Press 1 or 2). Esc to leave");
        }

        public void AddInfo()
        {
            try
            {
                Console.Write("Site: ");
                Site = Console.ReadLine();
                Console.Write("Password: ");
                Password = Console.ReadLine();
            }
            catch (Exception)
            {
                throw;
            }
            
            this.NotifyObservers();
        }

        public void ShowPass()
        {
            model.DeserializeFile(newPass);
            for (int i = 0; i < newPass.Count; i++)
                Console.WriteLine("{0}  -  {1}", newPass.GetKey(i), newPass.Get(i));
             this.NotifyObservers();
        }

    }
}