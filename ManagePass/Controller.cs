using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerPass
{
    class Controller
    {
        NameValueCollection newPass = new NameValueCollection();

        public void AddPass(Model model)
        {
            newPass.Add(model.Site, model.Password);
        }
        public void ShowPass()
        {
            foreach (string item in newPass.Keys)
                Console.WriteLine("{0} - {1}", item, newPass[item]);
        }

    }
}
