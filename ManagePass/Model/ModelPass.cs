using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerPass
{
    public class Model
    {
        public readonly string filename = "serialized.bin";
        public Model ()
        {
            if (!File.Exists(filename))
                using (FileStream fs = File.Create(filename)) ;
        }
        public void BinFile()
        {
            
                
        }
    }
}
