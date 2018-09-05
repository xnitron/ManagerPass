using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerPass
{
    public class ControllerSignUp
    {
        ModelSignUp modelPass = new ModelSignUp();
        HybridDictionary newUser = new HybridDictionary();
        

        public void AddPass(string login, string pass)
        {
            newUser.Add(login, pass);
            modelPass.AddData(newUser);
        }

    }
}
