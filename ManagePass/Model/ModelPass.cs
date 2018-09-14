using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace PasswordManager
{
    public class Model : Observable
    {
        private Dictionary<string, string> passwords = new Dictionary<string, string>();

        private string _password = "";

        private readonly string filename = "serialized.bin";

        public string Password
        {
            get { return _password; }
        }

        private void CreateFile(string filename)
        {
            using (FileStream fs = File.Create(filename))
            {
                File.SetAttributes(filename, FileAttributes.Hidden);
            }
        }

        public void AddPassword(string site, string password)
        {
            passwords.Add(site, password);

            if (!File.Exists(filename))
            {
                CreateFile(filename);
            }

            IFormatter formatter = new BinaryFormatter();

            using (FileStream s = File.OpenWrite(filename))
            {
                formatter.Serialize(s, passwords);
            }
        }

        public void GetPassword(string site)
        {
            DeserializeFile();
            _password = passwords[site];

            NotifyObservers();
        }

        public void DeserializeFile()
        {
            passwords.Clear();
            
            if (!File.Exists(filename))
            {
                CreateFile(filename);
            }

            IFormatter formatter = new BinaryFormatter();

            using (FileStream s = File.OpenRead(filename))
            {
                passwords = (Dictionary<string, string>)formatter.Deserialize(s);
            }
        }
    }
}
    