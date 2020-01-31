using ATM.Forms.adminForms;
using ATM.Properties;
using ATM.IDaoImpl;
using System;
using System.Windows;
using System.Windows.Controls;


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
                AdminForm admin = new AdminForm();

                MessageBox.Show("Contrase;a correcta", "Buena dog");

                //obtiene la ventana principal, para asi cerrarla
                MainWindow log =(ATM.MainWindow) Application.Current.MainWindow; 

                log.Close();

                admin.ShowDialog();

                

            
           
            
            }
            else
            {

                ValidateLabel.Text = "Contraseña incorrecta, por favor intente de nuevo";
             
            }

           
       

        }

        private void UserControl_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            
        }
    }
}
