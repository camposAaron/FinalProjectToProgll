using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.POJO_s
{
    [Serializable]

    class Transferencia
    {
        private String numeroCuenta;
        private String tipo; 
        private double entrada; 
        private double salida; 
        private double saldo; 
        private String fechaTransaccion; 
        private String horaTransaccion; 


        public Transferencia()
        {

        }


        public Transferencia(String numeroCuenta, String tipo, String hora, String fecha, Double Entrada, Double Salida, Double Saldo)
        {
            this.numeroCuenta = numeroCuenta;
            this.entrada = Entrada;
            this.salida = Salida;
            this.saldo = Saldo;
            this.fechaTransaccion = fecha;
            this.tipo = tipo;
            this.horaTransaccion = hora;
        }

        public string NumeroCuenta { get => numeroCuenta; set => numeroCuenta = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public double Entrada { get => entrada; set => entrada = value; }
        public double Salida { get => salida; set => salida = value; }
        public double Saldo{ get => saldo; set => saldo = value; }
        public string FechaTransaccion { get => fechaTransaccion; set => fechaTransaccion = value; }
        public string HoraTransaccion { get => horaTransaccion; set => horaTransaccion = value; }
    }
      
    [Serializable]

        class ManejadorTransferencia
    {
        List<Transferencia> transferencias = new List<Transferencia>();

        public void AddTransferencia(Transferencia transferencia)
        {
            transferencias.Add(transferencia);
        }

        public void setTransferencias(List<Transferencia> list)
        {
            transferencias = list;
        }
        public List<Transferencia> getTransferencias()
        {
            return transferencias;
        }
    }
}
