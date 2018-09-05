﻿using ManagePass;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                    view.Site = Console.ReadLine();
                    Console.Write("Password: ");
                    view.Password = Console.ReadLine();
                    controller.AddPass(view);
                }
                if (cki.Key == ConsoleKey.D2)
                    model.ShowPass();
                if (cki.Key == ConsoleKey.D3)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new SignUp());
                }


            } while (cki.Key != ConsoleKey.Escape);
            

        }
    }
}
