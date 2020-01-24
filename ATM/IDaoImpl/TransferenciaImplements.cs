using ATM.IDAO;
using ATM.POJO_s;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ATM.IDaoImpl
{
    class TransferenciaImplements : IDao<Transferencia>
    {
        ManejadorTransferencia mnj = new ManejadorTransferencia();
        String fileName = "Transferencias.dat";

        public TransferenciaImplements()
        {

        }

        public bool Delete(string numberAccount)
        {

            bool flat = false;
            try
            {

                BinaryFormatter formatter = new BinaryFormatter();
                Stream lsStream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.None);
                mnj = (ManejadorTransferencia)formatter.Deserialize(lsStream);
                lsStream.Close();
                List<Transferencia> transferencias = mnj.getTransferencias();

                for (int i = 0; i < transferencias.Count; i++)
                {
                    if (transferencias[i].NumeroCuenta.Equals(numberAccount))
                    {
                        transferencias.RemoveAt(i);
                        flat = true;
                    }
                }

                mnj.setTransferencias(transferencias);

                lsStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(lsStream, mnj);  //serialisamos mnj con la nueva lista
                lsStream.Close();

            }
            catch (Exception ex)
            {
                // Aqui un messagebox
            }

            return flat;
        }
            public List<Transferencia> FindAll()
            {
                try
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    Stream lsStream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.None);
                    mnj = (ManejadorTransferencia)formatter.Deserialize(lsStream);
                    lsStream.Close();
                }
                catch (FileNotFoundException ex)
                {
                    //Aqui otro messageBox
                }

                return mnj.getTransferencias();
            }

            public void Save(Transferencia t)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                Stream lsStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);
                mnj.AddTransferencia(t);
                formatter.Serialize(lsStream, mnj);
                lsStream.Close();
            }

            public int Update(Transferencia t)
            {
                throw new NotImplementedException();
            }

           public List<Transferencia> FindByNumberAccount(String numberAccount) 
           {
            BinaryFormatter formatter = new BinaryFormatter();
            Stream lsStream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.None);
            mnj = (ManejadorTransferencia)formatter.Deserialize(lsStream);
            lsStream.Close();
            List<Transferencia> transferencias = mnj.getTransferencias();
            List<Transferencia> buscados = new List<Transferencia>();
            for (int i = 0; i < transferencias.Count; i++)
            {
                if (transferencias[i].NumeroCuenta.Equals(numberAccount))
                {
                    buscados.Add(transferencias[i]);
                }
            }

            return buscados;
        }
        
    }
}
