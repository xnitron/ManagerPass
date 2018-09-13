using System;
using System.Collections.Specialized;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace PasswordManager
{
    public class Model 
    {
        public readonly string filename = "serialized.bin";

        public void BinFile(string file)
        {
            if (!File.Exists(file))
                using (FileStream fs = File.Create(file))
                    File.SetAttributes(filename, FileAttributes.Hidden); 
        }

        public void AddPass(NameValueCollection newPass)
        {
            BinFile(filename);
            IFormatter formatter = new BinaryFormatter();
            using (FileStream s = File.OpenWrite(filename))
            {
                formatter.Serialize(s, newPass);
            }
        }

        public void DeserializeFile(NameValueCollection newPass)
        {
            newPass.Clear();
            BinFile(filename);
            IFormatter formatter = new BinaryFormatter();
            using (FileStream s = File.OpenRead(filename))
            {
                try
                {
                    newPass.Add((NameValueCollection)formatter.Deserialize(s));
                   
                }
                catch (Exception ex)
                {
                    Console.WriteLine("You do not have any passwords");
                }
            }
        }
    }
}
    