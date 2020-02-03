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


namespace ATM.Forms.adminForms
{
    /// <summary>
    /// Lógica de interacción para VerUsuariosControl.xaml
    /// </summary>
    public partial class VerUsuariosControl : UserControl
    {
        ClienteImplements imp = new ClienteImplements();
        Cliente c = new Cliente();
        private bool bandera = false;  //bandera que se utiliza para modificar los datos en el grid

        

        public VerUsuariosControl()
        {
            InitializeComponent();
            dgUsers.ItemsSource = imp.FindAll();
            bandera = false;
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            bandera = true;

            switch (ComboBoxTipoBuscar.SelectedIndex)
            {
                case 0:

                    string cuenta = TxtBuscar.Text;
                    


                    break;

                case 1:

                    string cedula = TxtBuscar.Text;
                    dgUsers.ItemsSource = imp.FindById(cedula);
                     
                    break;
            }
        }

        private void iconClose_Click(object sender, RoutedEventArgs e)
        {
            bandera = false;
            TxtBuscar.Text = "";
            dgUsers.ItemsSource = imp.FindAll();
        }


        //Eliminar registros del data grid
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult dialogResult;

            dialogResult  = MessageBox.Show("Realmente deseas eliminar estos registros?\n?", "", MessageBoxButton.YesNo, MessageBoxImage.Question);
            
            if(dialogResult == MessageBoxResult.Yes)
            {

                List<Cliente> list = (List<Cliente>)dgUsers.ItemsSource;

                if (list != null)
                {
                    for (int i = 0; i < dgUsers.SelectedItems.Count; i++)
                    {
                        int indice = dgUsers.Items.IndexOf(dgUsers.SelectedItems[i]);
                        list.RemoveAt(indice);
                    }

                    dgUsers.ItemsSource = null;
                    dgUsers.ItemsSource = list;

                    imp.setAll(list);
                }
                else
                {
                    MessageBox.Show("Debe seleccionar por lo menos una fila.");
                }
            }
            
         
             

}

        //boton que permite la edicion en el datagrid
        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            switch (labelConfirmar.Text)
            {
                case "off":
                    dgUsers.IsReadOnly = false;
                    labelConfirmar.Text = "on";
                    break;

                case "on":
                    dgUsers.IsReadOnly = true;
                    labelConfirmar.Text = "off";
                    break;


            }  

        }


        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
           
            List<Cliente> list = (List<Cliente>)dgUsers.ItemsSource;
            List<Cliente> list2 = imp.FindAll();
           
           
            var index = 0;

            if (bandera)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    Cliente c = new Cliente(list[j].Id, list[j].NumeroCuenta, list[j].Pin, list[j].Nombre, list[j].Apellido);

                    for (int i = 0; i < list2.Count; i++)
                    {



                        if (list2[i].Id.Equals(TxtBuscar.Text))
                        {
                            list2.RemoveAt(index);
                            list2.Insert(index, c);

                        }
                        else
                        {
                            index++;
                        }



                    }
                }


                imp.setAll(list2);

            }
            else
            {
                imp.setAll(list);
            }



        }

      

    }
}
