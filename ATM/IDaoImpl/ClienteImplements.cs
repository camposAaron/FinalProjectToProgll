﻿using ATM.IDAO;
using ATM.POJO_s;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ATM.IDaoImpl
{
    class ClienteImplements : ClienteIDao
    {
        ManejadorClientes mnj = new ManejadorClientes();
        string nombre = "clientes.dat";
   
        public ClienteImplements()
        {
          
        }
             
        public bool Delete(string numeroCedula)
        {
            bool flat = false;
            try
            {
               
                BinaryFormatter formatter = new BinaryFormatter();
                Stream lsStream = new FileStream(nombre, FileMode.Open, FileAccess.Read, FileShare.None);
                mnj = (ManejadorClientes)formatter.Deserialize(lsStream);
                lsStream.Close();
                List<Cliente> clientes = mnj.getClientes();

                for (int i = 0; i < clientes.Count; i++)
                {
                    if (clientes[i].Id.Equals(numeroCedula))
                    {
                        clientes.RemoveAt(i);
                        flat = true;
                    }
                }

                mnj.setClientes(clientes);
                
                lsStream = new FileStream(nombre, FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(lsStream, mnj);  //serialisamos mnj con la nueva lista
                lsStream.Close();

            }catch(Exception ex)
            {
               // Aqui un messagebox
            }

            return flat;
        }

        public List<Cliente> FindAll()
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                Stream lsStream = new FileStream(nombre, FileMode.Open, FileAccess.Read, FileShare.None);
                mnj = (ManejadorClientes)formatter.Deserialize(lsStream);
                lsStream.Close();
            }
            catch(FileNotFoundException ex)
            {
                //Aqui otro messageBox
            }
           
            return mnj.getClientes();

        }

        public void Save(Cliente t)
        {

            Stream lsStream = new FileStream(nombre, FileMode.Create, FileAccess.Write, FileShare.None);
            mnj.AddCliente(t);
          
            BinaryFormatter  formatter = new BinaryFormatter();
            formatter.Serialize(lsStream, mnj);
            lsStream.Close();
        }


        public List<Cliente> FindById(string id)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Stream lsStream = new FileStream(nombre, FileMode.Open, FileAccess.Read, FileShare.None);
            mnj = (ManejadorClientes)formatter.Deserialize(lsStream);
            lsStream.Close();
            List<Cliente> clientes = mnj.getClientes();
            List<Cliente> cliente = new List<Cliente>();
            for (int i = 0; i < clientes.Count; i++)
            {
                if (clientes[i].Id.Equals(id))
                {
                    cliente.Add(clientes[i]);
                }
            }

            return cliente;
        }

        public int Update(Cliente t)
        {
            throw new NotImplementedException();
        }
    }
}
