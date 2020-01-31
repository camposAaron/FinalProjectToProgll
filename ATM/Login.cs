using ATM.Forms;
using ATM.IDaoImpl;
using ATM.POJO_s;
using System;
using System.Collections.Generic;

using System.Windows;
using System.Windows.Controls;

namespace ATM
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public  partial class MainWindow : Window
    {
        ClienteImplements impl = new ClienteImplements();

        AdminLogin admin = new AdminLogin();

        public  MainWindow()
        {
            InitializeComponent();
            GridLog.Children.Add(new UserLogin());
     

        }

        private void Border_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Application.Current.Shutdown(); 

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(((Button)e.Source).Uid);
         if(index  == 2){
                gridCursor.Margin = new Thickness(268, 23, 0, 1);
            }
            else
            {
                gridCursor.Margin = new Thickness(118, 23, 0, 1);
            }


            switch (index)
            {
                case 1:
                    GridLog.Children.Clear();
                    GridLog.Children.Add(new UserLogin());

                    break;


                case 2:
                    GridLog.Children.Clear();
                    GridLog.Children.Add(new AdminLogin());
                   
                    break;
            }

        }




      
    }
}

