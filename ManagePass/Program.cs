using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ManagerPass
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            View view = new View();
            Model model = new Model();
            Controller controller = new Controller();

           do
            {
                view.MenuQuestion = "New Password or View created passwords(Press 1 or 2). Esc to leave";
                Console.WriteLine(view.MenuQuestion);

                cki = Console.ReadKey(true);

                if (cki.Key == ConsoleKey.D1)
                {
                    Console.Write("Site: ");
                    model.Site = Console.ReadLine();
                    Console.Write("Password: ");
                    model.Password = Console.ReadLine();
                    controller.AddPass(model);

                }
                if (cki.Key == ConsoleKey.D2)
                    controller.ShowPass();


            } while (cki.Key != ConsoleKey.Escape);
            

        }
    }
}
