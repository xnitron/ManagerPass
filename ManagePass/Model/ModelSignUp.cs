using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerPass
{
    public class ModelSignUp : Model
    {
        HybridDictionary usersData = new HybridDictionary();
        public readonly string filename = "usersdata.bin";

        public void AddData(HybridDictionary newPass)
        {
            base.BinFile(filename);
            IFormatter formatter = new BinaryFormatter();
            using (FileStream s = File.OpenWrite(filename))
                formatter.Serialize(s, newPass);
        }
    }
}
