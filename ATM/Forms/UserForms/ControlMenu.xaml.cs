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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ATM.Forms.UserForms
{
    /// <summary>
    /// Lógica de interacción para ControlMenu.xaml
    /// </summary>
    public partial class ControlMenu : UserControl
    {
        private UserForm userForm;

        public ControlMenu()
        {
            InitializeComponent();
        }


        /* Eventos del visor*/


        private void btnDepositar_Click(object sender, RoutedEventArgs e)
        {
            ControlDepositar depositar = new ControlDepositar();
            userForm.gridDinamico.Children.Clear();
            userForm.gridDinamico.Children.Add(depositar);
           
            /*Estos setter sirven para restablecer el menu*/
            depositar.setControlMenu(this);
            depositar.setUserForm(userForm);

        }

        private void btnRetirar_Click(object sender, RoutedEventArgs e)
        {
            ControlRetirar retirar = new ControlRetirar();
            userForm.gridDinamico.Children.Clear();
            userForm.gridDinamico.Children.Add(retirar);

            /*Estos setter sirven para restablecer el menu*/
            retirar.setControlMenu(this);
            retirar.setUserForm(userForm);
        }

        private void btnBalance_Click(object sender, RoutedEventArgs e)
        {
            ControlBalance balance = new ControlBalance();
            userForm.gridDinamico.Children.Clear();
            userForm.gridDinamico.Children.Add(balance);

            
            /*Estos setter sirven para restablecer el menu*/
            balance.setControlMenu(this);
            balance.setUserForm(userForm);


        }

        private void btnHistorial_Click(object sender, RoutedEventArgs e)
        {
            ControlHistorial historial = new ControlHistorial();
            userForm.gridDinamico.Children.Clear();
            userForm.gridDinamico.Children.Add(historial);

            /*Estos setter sirven para restablecer el menu*/
            historial.setControlMenu(this);
            historial.setUserForm(userForm);
        }

        private void btncerrar_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();


        }

        public void setUserForm(UserForm userForm)
        {
            this.userForm = userForm;
        }
    }
}
