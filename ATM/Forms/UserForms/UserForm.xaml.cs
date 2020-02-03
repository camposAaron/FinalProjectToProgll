using ATM.IDaoImpl;
using ATM.POJO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ATM.Forms.UserForms
{
    /// <summary>
    /// Lógica de interacción para UserForm.xaml
    /// </summary>
    public partial class UserForm : Window
    {

        Cliente usuario = new Cliente();
        ClienteImplements clienteImplements = new ClienteImplements();
        TransferenciaImplements transferenciaImplements = new TransferenciaImplements();

       
        //identificador de control
        private int identifier;  


        //Controles
       
      
        ControlDepositar depositar;
        ControlRetirar retirar;


        private string numeroCuenta;





        public int Identifier { get => identifier; set => identifier = value; }
        internal Cliente Usuario { get => usuario; set => usuario = value; }

        public UserForm()
        {

            ControlMenu menu = new ControlMenu();
            InitializeComponent();
            gridDinamico.Children.Clear();
            gridDinamico.Children.Add(menu);
            menu.setUserForm(this);
           


        }


        //manejo de la ventana
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }


        /*UsersControllers setters*/
        internal void setControlDepositar(ControlDepositar controlDepositar)
        {
            depositar = controlDepositar;
        }


        internal void setControlRetirar(ControlRetirar controlRetirar)
        {
            retirar = controlRetirar;
        }


   





        #region botones numericos
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            
            switch (identifier)
            {
                

                case 1:
                    string passInputDeposito = depositar.txtDeposito.Text;
                    depositar.txtDeposito.Text = passInputDeposito + "1";

                    break;
                case 2:
                    string passInputRetiro = retirar.txtRetiro.Text;
                    retirar.txtRetiro.Text = passInputRetiro + "1";
                    break;


            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {

            switch (identifier)
            {


                case 1:
                    string passInputDeposito = depositar.txtDeposito.Text;
                    depositar.txtDeposito.Text = passInputDeposito + "2";

                    break;
                case 2:
                    string passInputRetiro = retirar.txtRetiro.Text;
                    retirar.txtRetiro.Text = passInputRetiro + "2";
                    break;


            }
        }

        internal void setCliente(Cliente c)
        {
            usuario = c;
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {

            switch (identifier)
            {


                case 1:
                    string passInputDeposito = depositar.txtDeposito.Text;
                    depositar.txtDeposito.Text = passInputDeposito + "3";

                    break;
                case 2:
                    string passInputRetiro = retirar.txtRetiro.Text;
                    retirar.txtRetiro.Text = passInputRetiro + "3";
                    break;


            }
        }




        private void btn4_Click(object sender, RoutedEventArgs e)
        {

            switch (identifier)
            {


                case 1:
                    string passInputDeposito = depositar.txtDeposito.Text;
                    depositar.txtDeposito.Text = passInputDeposito + "4";

                    break;
                case 2:
                    string passInputRetiro = retirar.txtRetiro.Text;
                    retirar.txtRetiro.Text = passInputRetiro + "4";
                    break;


            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {

            switch (identifier)
            {


                case 1:
                    string passInputDeposito = depositar.txtDeposito.Text;
                    depositar.txtDeposito.Text = passInputDeposito + "5";

                    break;
                case 2:
                    string passInputRetiro = retirar.txtRetiro.Text;
                    retirar.txtRetiro.Text = passInputRetiro + "5";
                    break;


            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {

            switch (identifier)
            {


                case 1:
                    string passInputDeposito = depositar.txtDeposito.Text;
                    depositar.txtDeposito.Text = passInputDeposito + "6";

                    break;
                case 2:
                    string passInputRetiro = retirar.txtRetiro.Text;
                    retirar.txtRetiro.Text = passInputRetiro + "6";
                    break;


            }
        }


       

        private void btn7_Click(object sender, RoutedEventArgs e)
        {

            switch (identifier)
            {


                case 1:
                    string passInputDeposito = depositar.txtDeposito.Text;
                    depositar.txtDeposito.Text = passInputDeposito + "7";

                    break;
                case 2:
                    string passInputRetiro = retirar.txtRetiro.Text;
                    retirar.txtRetiro.Text = passInputRetiro + "7";
                    break;


            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {

            switch (identifier)
            {


                case 1:
                    string passInputDeposito = depositar.txtDeposito.Text;
                    depositar.txtDeposito.Text = passInputDeposito + "8";

                    break;
                case 2:
                    string passInputRetiro = retirar.txtRetiro.Text;
                    retirar.txtRetiro.Text = passInputRetiro + "8";
                    break;


            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {

            switch (identifier)
            {


                case 1:
                    string passInputDeposito = depositar.txtDeposito.Text;
                    depositar.txtDeposito.Text = passInputDeposito + "9";

                    break;
                case 2:
                    string passInputRetiro = retirar.txtRetiro.Text;
                    retirar.txtRetiro.Text = passInputRetiro + "9";
                    break;

            }
        }

     

        private void btn0_Click(object sender, RoutedEventArgs e)
        {

            switch (identifier)
            {


                case 1:
                    string passInputDeposito = depositar.txtDeposito.Text;
                    depositar.txtDeposito.Text = passInputDeposito + "0";

                    break;
                case 2:
                    string passInputRetiro = retirar.txtRetiro.Text;
                    retirar.txtRetiro.Text = passInputRetiro + "0";
                    break;


            }
        }

        #endregion


        private void btnE_Click(object sender, RoutedEventArgs e)
        {
            //ojooooooooo
            switch (identifier)
            {
                case 1:

                    validarDeposito();
                    MessageBox.Show("Transferencia con exito","",MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
               
                case 2:
                    ValidarRetiro();
                     break;

            }



        }

        public void validarDeposito()
        {
            double monto = Convert.ToDouble(depositar.txtDeposito.Text);
            List<Transferencia> registroUsuario = new List<Transferencia>();
            List<Transferencia>   transferencias = transferenciaImplements.FindAll();
            

            foreach(Transferencia trans in transferencias)
            {
                if (usuario.NumeroCuenta.Equals(trans.NumeroCuenta))
                {
                    registroUsuario.Add(trans);
                }
            }

            var ultimo =  registroUsuario[registroUsuario.Count-1].Saldo;

            Transferencia t = new Transferencia();
            t.HoraTransaccion = DateTime.Now.ToString("h:mm:ss");
            t.FechaTransaccion = DateTime.Now.ToString("dd/MM/yyyy");
            t.NumeroCuenta = usuario.NumeroCuenta;
            t.Tipo = "Deposito";
            t.Entrada = monto;
            t.Saldo =  ultimo + monto;

            transferenciaImplements.Save(t);
        }


        public void ValidarRetiro()
        {
            double monto = Convert.ToDouble(retirar.txtRetiro.Text);
            List<Transferencia> registrosUsuario = new List<Transferencia>();
            List<Transferencia> transferencias = transferenciaImplements.FindAll();


            foreach (Transferencia trans in transferencias)
            {
                if (usuario.NumeroCuenta.Equals(trans.NumeroCuenta))
                {
                    registrosUsuario.Add(trans);
                }
            }


            var ultimo = registrosUsuario[registrosUsuario.Count - 1].Saldo; //obtiene el saldo de la ultima transaccion

            if (monto < ultimo)
            {
                Transferencia t = new Transferencia();
                t.HoraTransaccion = DateTime.Now.ToString("h:mm:ss");
                t.FechaTransaccion = DateTime.Now.ToString("dd/MM/yyyy");
                t.NumeroCuenta = usuario.NumeroCuenta;
                t.Tipo = "Retiro";
                t.Salida = monto;
                t.Saldo = ultimo - monto;

                transferenciaImplements.Save(t);
                MessageBox.Show("Transferencia con exito", "", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                retirar.validateText.Text = "Saldo insuficiente!";
            }

        }


        









        //boton cancel o borrar todo
        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            switch (identifier)
            {


                case 1:
                    string passInputDeposito = "";
                    depositar.txtDeposito.Text = passInputDeposito;

                    break;
                case 2:
                    string passInputRetiro = "";
                    retirar.txtRetiro.Text = passInputRetiro;
                    break;


            }
        }

        //boton clear

        private void btnclr_Click(object sender, RoutedEventArgs e)
        {
            switch (identifier)
            {


                case 1:
                    string passInputDeposito = depositar.txtDeposito.Text;
                    try
                    {
                        passInputDeposito = passInputDeposito.Remove(passInputDeposito.Length - 1);

                    }
                    catch (Exception ex)
                    {

                    }
                    depositar.txtDeposito.Text = passInputDeposito;

                    break;
                case 2:
                    string passInputRetiro = retirar.txtRetiro.Text;
                    try
                    {
                        passInputRetiro = passInputRetiro.Remove(passInputRetiro.Length - 1);

                    }
                    catch (Exception ex)
                    {

                    }
                    retirar.txtRetiro.Text = passInputRetiro;

                    break;


            }
        }

        public void setNumeroCuenta(String numeroCuenta)
        {
            this.numeroCuenta = numeroCuenta;
        }

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
            labelName.Text = usuario.Nombre + " " + usuario.Apellido;
        }
    }
}
