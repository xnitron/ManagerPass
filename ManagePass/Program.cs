using System;


namespace PasswordManager
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            Model model = new Model();
            View view = new View(model);
            Controller controller = new Controller(view, model);

            //"New Password or View created passwords(Press 1 or 2). Esc to leave";
           do
            {
                cki = Console.ReadKey(true);

                if (cki.Key == ConsoleKey.D1)
                {
                    view.AddInfo();
                    controller.AddPass();
                }

                if (cki.Key == ConsoleKey.D2)
                {
                 
                    view.ShowPass();
          
                }

            } while (cki.Key != ConsoleKey.Escape);

        }
    }
}
