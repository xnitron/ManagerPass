using System;
using System.Collections.Specialized;

namespace PasswordManager
{

    public class Controller
    {
        NameValueCollection newPass = new NameValueCollection();
        IView view;
        Model model;

        public Controller(IView view, Model model)
        {
            this.view = view;
            this.model = model;
        }

        public void AddPass()
        {
            newPass.Add(view.Site, view.Password);
            model.AddPass(newPass);
        }

    }
   
}
