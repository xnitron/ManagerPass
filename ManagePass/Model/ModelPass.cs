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
    public class Model
    {
        public readonly string filename = "serialized.bin";
        NameValueCollection newPass = new NameValueCollection();
        public Model ()
        {

        }
        public void BinFile(string file)
        {
            if (!File.Exists(file))
                using (FileStream fs = File.Create(file))
                    File.SetAttributes(filename, FileAttributes.Hidden); 
        }
        public void AddPass(NameValueCollection newPass)
        {
            this.BinFile(filename);
            IFormatter formatter = new BinaryFormatter();
            using (FileStream s = File.OpenWrite(filename))
                formatter.Serialize(s, newPass);
        }
        public void ShowPass()
        {
            this.BinFile(filename);
            newPass.Clear();
            IFormatter formatter = new BinaryFormatter();
            using (FileStream s = File.OpenRead(filename))
            {
                try
                {
                    newPass.Add((NameValueCollection)formatter.Deserialize(s));
                    for (int i = 0; i < newPass.Count; i++)
                        Console.WriteLine("{0}  -  {1}", newPass.GetKey(i), newPass.Get(i));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("You do not have any passwords");
                }
                
            }
        }
    }
}
    