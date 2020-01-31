using ATM.Forms;
using ATM.Forms.adminForms;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ATM
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
       
      
       private static bool activate ;

        public static bool Activate { get => activate; set => activate = value; }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MainWindow login = new MainWindow();
            login.Show();
 
        }

    }
}
