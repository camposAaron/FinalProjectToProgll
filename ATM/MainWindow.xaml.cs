using ATM.IDaoImpl;
using ATM.POJO_s;
using System;
using System.Collections.Generic;

using System.Windows;

namespace ATM
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClienteImplements impl = new ClienteImplements();
      
        public MainWindow()
        {
            InitializeComponent();
        }

        //AGREGAR CLIENTE
        private void btnsave_Click(object sender, RoutedEventArgs e)
        {
          
            Cliente c = new Cliente(txtID.Text, txtNumero.Text, txtPin.Text, txtNombre.Text, txtApellido.Text);

            List<Cliente> clientes = impl.FindAll();
           
            impl.Save(c);

            MessageBox.Show("Guardado", "OK");
       
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Cliente> clientes = impl.FindAll();


            for (int i = 0; i < clientes.Count; i++)
            {
                Console.WriteLine(clientes[i].Nombre + "\n" + clientes[i].NumeroCuenta + "\n" + clientes[i].Id);

            }
        }

        //Evento Eliminar
        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            String numeroCedula = txtDelete.Text;
           
            if (impl.Delete(numeroCedula))
            {
                MessageBox.Show("Numero de cuenta borrada");
            }
            else
            {
                MessageBox.Show("Numero Cuenta invalida o no existe");
            }
        }

        private void ButtonVerUSer_Click(object sender, RoutedEventArgs e)
        {
            String id = txtBuscar.Text;
            List<Cliente> cls = impl.FindById(id);
            foreach(Cliente c in cls)
            {
                txtresult.AppendText("id: " + c.Id + " Nombre: " + c.Nombre);
            }
        }
    }
}

