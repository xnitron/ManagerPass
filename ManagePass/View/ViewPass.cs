using System;

namespace PasswordManager
{
    public class View : IObserver
    {
        private Model model;
        private Controller controller;

        public View(Model model, Controller controller)
        {
            this.model = model;
            this.controller = controller;

            this.model.RegisterObserver(this);
        }

        public void Show()
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.WriteLine("New Password or View created passwords(Press 1 or 2). Esc to leave");

                cki = Console.ReadKey(true);

                if (cki.Key == ConsoleKey.D1)
                {
                    AddInfo();
                }

                if (cki.Key == ConsoleKey.D2)
                {
                    string site = Console.ReadLine();

                    controller.GetPassword(site);
                }

            } while (cki.Key != ConsoleKey.Escape);
        }

        public void ShowError(string error)
        {
            Console.WriteLine(error);
        }

        public void Update()
        {
            Console.WriteLine(model.Password);
        }

        public void AddInfo()
        {
            try
            {
                Console.Write("Site: ");
                string site = Console.ReadLine(); 
             
                Console.Write("Password: ");
                string password = Console.ReadLine();

                controller.AddPassword(site, password);
            }
            catch (Exception)
            {
                ShowError("ErrorView");
            }
        }
    }
}