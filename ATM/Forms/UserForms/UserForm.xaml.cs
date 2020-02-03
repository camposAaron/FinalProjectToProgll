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
        private int identifier;

        ControlBalance balance;
        ControlDepositar depositar;
        ControlHistorial historial;
        ControlRetirar retirar;





        private string numeroCuenta;

       
        
        
        
        
        public int Identifier { get => identifier; set => identifier = value; }

        public UserForm()
        {

            ControlMenu menu = new ControlMenu();
            InitializeComponent();
            gridDinamico.Children.Clear();
            gridDinamico.Children.Add(menu);
            menu.setUserForm(this);
           


        }

        

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        internal void setControlDepositar(ControlDepositar controlDepositar)
        {
            depositar = controlDepositar;
        }


        internal void setControlRetirar(ControlRetirar controlRetirar)
        {
            retirar = controlRetirar;
        }

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
                    
                    }catch(Exception ex)
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


        private void btnE_Click(object sender, RoutedEventArgs e)
        {
            //ojooooooooo




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
