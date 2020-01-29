using ATM.IDaoImpl;
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

namespace ATM.Forms
{
    /// <summary>
    /// Lógica de interacción para AdminLogin.xaml
    /// </summary>
    public partial class AdminLogin : UserControl
    {
        AdminAcces acces = new AdminAcces();
         
        public AdminLogin()
        {
            InitializeComponent();
       

        }

        private void ButtonInit_Click(object sender, RoutedEventArgs e)
        {
            String pseudoPassword = txtPass.Password;
           
            if (pseudoPassword.Equals(acces.DeserializePass()))
            {
                MessageBox.Show("Contrase;a correcta", "Buena dog");
            }
            else
            {

                ValidateLabel.Text = "Contraseña incorrecta, por favor intente de nuevo";
            }




        }
    }
}
