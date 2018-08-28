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
        NameValueCollection newPass = new NameValueCollection();
        
        public void AddPass(Model model)
        {
            newPass.Add(model.Site, model.Password);
            IFormatter formatter = new BinaryFormatter();
            using (FileStream s = File.Create("serialized.bin"))
                formatter.Serialize(s, newPass);

        }
   
        public void ShowPass()
        {
            IFormatter formatter = new BinaryFormatter();
            newPass.Clear();
            using (FileStream s = File.OpenRead("serialized.bin"))
            {
                newPass.Add((NameValueCollection)formatter.Deserialize(s)); 
            }
            for (int i = 0; i < newPass.Count; i++)
                Console.WriteLine("{0}  -  {1}", newPass.GetKey(i), newPass.Get(i));
        }
    }
   
}
