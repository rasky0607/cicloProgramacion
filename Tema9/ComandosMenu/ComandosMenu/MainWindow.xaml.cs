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

namespace ComandosMenu
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            //comprueba si esta habilitado o no
            e.CanExecute = true;//Habilita el comando y el control en el que esta asociado.
        }

        private void OpenCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            //Lo que va realizar el comando
            tbxMensaje.Text = " Estas usando el comando Open...";
        }

        private void CloseCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;//Habilita el comando y el control en el que esta asociado.
        }

        private void CloseCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            //Lo que va realizar el comando
            tbxMensaje.Text = " Estas usando el comando Cerrar...";
        }
    }
}
