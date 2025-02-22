﻿using ATM.Forms.UserForms;
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

namespace ATM.Forms
{
    /// <summary>
    /// Lógica de interacción para UserLogin.xaml
    /// </summary>
    public partial class UserLogin : UserControl
    {

        ClienteImplements imp = new ClienteImplements();

        public UserLogin()
        {
            InitializeComponent();
        }

        private void PreviewTextInputOnlyNumbers(object sender, TextCompositionEventArgs e)
        { 

            int character = Convert.ToInt32(Convert.ToChar(e.Text));
            if (character >= 48 && character <= 57)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Cliente  c  =  imp.ValidateUser(txtUsuario.Text, txtPin.Password);
          
            if (c != null)
            {
                UserForm userForm = new UserForm();

                MessageBox.Show("Exito");
                MainWindow log = (ATM.MainWindow)Application.Current.MainWindow;
                log.Close();
                userForm.setCliente(c);
                userForm.ShowDialog();
               

            }
            else
            {
                txtPin.Clear();
                txtUsuario.Clear();
                
                ValidateLabel.Text = "Contraseña o numero de cuenta invalida"; 
            }
           
        }
    }
}
