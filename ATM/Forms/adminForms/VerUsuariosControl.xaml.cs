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

namespace ATM.Forms.adminForms
{
    /// <summary>
    /// Lógica de interacción para VerUsuariosControl.xaml
    /// </summary>
    public partial class VerUsuariosControl : UserControl
    {
        ClienteImplements imp = new ClienteImplements();

        public VerUsuariosControl()
        {
            InitializeComponent();
            dgUsers.ItemsSource = imp.FindAll();
            
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBoxTipoBuscar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
