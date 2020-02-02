using System;

using System.Windows;
using ATM;
using ATM.IDaoImpl;

namespace ATM.Forms.adminForms
{
    /// <summary>
    /// Lógica de interacción para AdminForm.xaml
    /// </summary>
    public partial class AdminForm : Window
    {

   

        public AdminForm()
        {
            InitializeComponent();
          
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Border_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {
            GridPrincipal.Children.Clear();
            GridPrincipal.Children.Add(new RegistrarUsuarioControl());
        }

        private void ListViewItem_Selected_1(object sender, RoutedEventArgs e)
        {
            GridPrincipal.Children.Clear();
            GridPrincipal.Children.Add(new VerUsuariosControl());
        }
    }
}
