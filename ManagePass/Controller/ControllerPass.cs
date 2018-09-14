using System;

namespace PasswordManager
{
    public class Controller
    {
        Model model;
        View view;

        public Controller(Model model)
        {
            this.model = model;
            view = new View(model, this);   

            view.Show();
        }

        public void AddPassword(string site, string password)
        {
            try
            {
                model.AddPassword(site, password);
            }
            catch (Exception)
            {
                view.ShowError("Error: Can't add new password");
            }
        }

        public void GetPassword(string site)
        {
            try
            {
                model.GetPassword(site);
            }
            catch (Exception)
            {
                view.ShowError("Error: Can't get password");
            }
        }
    } 
}
