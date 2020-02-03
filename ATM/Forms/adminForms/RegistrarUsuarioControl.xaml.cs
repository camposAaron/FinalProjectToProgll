using ATM.IDaoImpl;
using ATM.POJO_s;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

using System.Windows.Input;

namespace ATM.Forms.adminForms
{
    /// <summary>
    /// Lógica de interacción para RegistrarUsuarioControl.xaml
    /// </summary>
    public partial class RegistrarUsuarioControl : UserControl
    {
        ClienteImplements clienteimplements = new ClienteImplements();
        TransferenciaImplements transferenciaImplements = new TransferenciaImplements();

        public RegistrarUsuarioControl()
        {
            InitializeComponent();
        }

        //Evento para boton registrar
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ValidateLabel.Text = "";
            try
            {
                double monto = Convert.ToDouble(txtApertura.Text);
          

            if (txtNumeroCedula.Text != "" && txtNombre.Text != "" && txtApellido.Text != "" && txtApertura.Text != "")
            {
                if (monto >= 300)
                {
                   //Guardandon los datos del cliente o usuario
                   
                    string pin =generarPIN();
                    string cuenta = generarNcuenta(txtNombre.Text, txtApellido.Text, txtNumeroCedula.Text);
                    Cliente c = new Cliente();
                    c.Id = txtNumeroCedula.Text;
                    c.Nombre = txtNombre.Text;
                    c.Apellido = txtApellido.Text;
                    c.NumeroCuenta = cuenta;
                    c.Pin = pin;
                        // actualiza el deserializador 
                        List<Cliente> list = clienteimplements.FindAll();
                        // guarda
                        clienteimplements.Save(c);

                        //Guardando los datos de transferencia o la apertura
                        Transferencia t = new Transferencia();
                        t.HoraTransaccion = DateTime.Now.ToString("h:mm:ss");
                        t.FechaTransaccion = DateTime.Now.ToString("dd/MM/yyyy");
                        t.NumeroCuenta = cuenta;
                        t.Tipo = "Apertura";
                        t.Entrada = monto;
                        t.Saldo = monto;

                        transferenciaImplements.Save(t);

                        MessageBox.Show("Nombres      : "+c.Nombre+"\n " +
                                        "Apellidos    : "+c.Apellido+"\n"+
                                        "Numero cuenta: "+c.NumeroCuenta+"\n"+
                                        "Numero PIN   : "+c.Pin+"\n"
                                        , "Usuario agregado correctamente!",MessageBoxButton.OK,MessageBoxImage.Information);




                    }
                else
                {
                    txtNumeroCedula.Text = "";
                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    txtApertura.Text = "";
                    ValidateLabel.Text = "El monto de apertura debe ser mayor a 300$!";
                }
            }
            else
            {
                txtNumeroCedula.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtApertura.Text = "";
                ValidateLabel.Text = "Debes rellenar todos los campos!";
            }
        
            }
            catch (FormatException EX)
            {

            }
        }

        private void txtNombre_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //solo letras
            int character = Convert.ToInt32(Convert.ToChar(e.Text));
            if ((character >=65  && character <= 90) || (character >= 97 && character <= 122) )
                e.Handled = false;
            else
                e.Handled = true;

        }



        private void txtApertura_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //Solo numeros
            int character = Convert.ToInt32(Convert.ToChar(e.Text));
            if (character >= 48 && character <= 57)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtApellido_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //solo letras
            int character = Convert.ToInt32(Convert.ToChar(e.Text));
            if ((character >= 65 && character <= 90) || (character >= 97 && character <= 122))
                e.Handled = false;
            else
                e.Handled = true;
        }

        //Metodo para generar un pin
        public string generarPIN()
        {

            var seed = Environment.TickCount;
            var random = new Random(seed);
            int[] n = new int[4];
               
            for (int i = 0; i < 4; i++)
                {
                   n[i] = random.Next(0, 9);
                }

                return "" + n[0] + "" + n[1] + "" + n[2] + "" + n[3];
          
        }

        //Metodo que genera un numero de cuenta especial por cliente
        public String generarNcuenta(string name, string last, string id)
        {
       
            String numeroCuenta = id.Substring(0, 3) + name.Substring(0, 1) + last.Substring(0, 1) + generarPIN();
            return numeroCuenta;
        }


    }
}
