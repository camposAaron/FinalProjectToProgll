using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.POJO_s
{
    [Serializable]
    class Cliente
    {
        private string id;                          
        private string numeroCuenta;                
        private string pin;                          
        private string nombre, apellido;                      

        public Cliente()
        {
        }

        public Cliente(String id, String numeroCuenta, String PIN, String nombre, String apellido)
        {
            this.numeroCuenta = numeroCuenta;
            this.nombre = nombre;
            this.apellido = apellido;

            this.id = id;
            this.pin = PIN;
        }

        public string Id { get => id; set => id = value; }
        public string NumeroCuenta { get => numeroCuenta; set => numeroCuenta = value; }
        public string Pin { get => pin; set => pin = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
    }


    [Serializable]

    class ManejadorClientes
    {
        List<Cliente> clientes = new List<Cliente>();

        public void AddCliente(Cliente cliente)
        {
            clientes.Add(cliente);
        }


        public void setClientes(List<Cliente> list)
        {
            clientes = list;
        }
        public List<Cliente> getClientes()
        {
            return clientes;
        }
    }
}
