using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ManagerPass
{

    public class Controller
    {
        Model modelPass = new Model();
        NameValueCollection newPass = new NameValueCollection();

        public void AddPass(View viewPass)
        {
            newPass.Add(viewPass.Site, viewPass.Password);
            modelPass.AddPass(newPass);
        }

    }
   
}
