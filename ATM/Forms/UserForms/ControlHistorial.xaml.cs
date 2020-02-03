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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ATM.Forms.UserForms
{
    /// <summary>
    /// Lógica de interacción para ControlHistorial.xaml
    /// </summary>
    public partial class ControlHistorial : UserControl
    {
        TransferenciaImplements transferencia = new TransferenciaImplements();
        UserForm userForm;
        ControlMenu controlMenu;

        public ControlHistorial()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            userForm.gridDinamico.Children.Clear();
            userForm.gridDinamico.Children.Add(controlMenu);
        }

        public void setUserForm(UserForm userForm)
        {
            this.userForm = userForm;
        }

        public void setControlMenu(ControlMenu controlMenu)
        {
            this.controlMenu = controlMenu;
        }

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
            List<Transferencia> registroUsuario = new List<Transferencia>();
            List<Transferencia> transferencias = transferencia.FindAll();
            Cliente usuario = userForm.Usuario;

            foreach (Transferencia trans in transferencias)
            {
                if (usuario.NumeroCuenta.Equals(trans.NumeroCuenta))
                {
                    registroUsuario.Add(trans);
                }
            }

            dgHistorial.ItemsSource = registroUsuario;
        }
    }
}
