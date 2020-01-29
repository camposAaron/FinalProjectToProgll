using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ATM.IDaoImpl
{
    class AdminAcces 
    {
        private String pass = "BANCOWPF";
        private BinaryFormatter formatter = new BinaryFormatter();
        private FileStream stream;

        public AdminAcces()
        {
            stream = new FileStream("AdminPasswordFile.dat",FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, pass);
            stream.Close();
        }

        public  String DeserializePass()
        {
            string pass;

            stream = new FileStream("AdminPasswordFile.dat", FileMode.Open, FileAccess.Read, FileShare.None);
            pass =Convert.ToString(formatter.Deserialize(stream));
            stream.Close();
            return pass;
        }
            
    }
}
