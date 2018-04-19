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

namespace Comandos
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

        //Lo que realiza el comando
        private void Close_CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Close del boton");
            this.Close();
            
        }

        //Mira cuando esta habilitado o no el comando
        private void Close_CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
           // e.CanExecute = true;//Activa el comando y el control sobre el que se aloja
            if (chbSepuedecerrar != null) // hay que comprobar si el checbox es distinto  de nulo, ya que su valor es nulable y permite nulos
            {
                e.CanExecute =(bool)chbSepuedecerrar.IsChecked;//cogemos su valor booleano si es distinto de nulo y se lo aplicamos a la propiedad  canExecute
            }
           

        }
    }
}
