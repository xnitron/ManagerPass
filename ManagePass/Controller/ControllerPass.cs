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
            modelPass.BinFile();
            newPass.Add(viewPass.Site, viewPass.Password);
            IFormatter formatter = new BinaryFormatter();
            using (FileStream s = File.OpenWrite(modelPass.filename))
                formatter.Serialize(s, newPass);
        }
   
        public void ShowPass()
        {
            newPass.Clear();
            modelPass.BinFile();
            IFormatter formatter = new BinaryFormatter();
            using (FileStream s = File.OpenRead(modelPass.filename))
            {
                newPass.Add((NameValueCollection)formatter.Deserialize(s));
                for (int i = 0; i < newPass.Count; i++)
                    Console.WriteLine("{0}  -  {1}", newPass.GetKey(i), newPass.Get(i));
            }
        }
    }
   
}
