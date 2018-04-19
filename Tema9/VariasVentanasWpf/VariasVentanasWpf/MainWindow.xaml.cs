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

namespace VariasVentanasWpf
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

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            //Creamos un objeto de App  donde guardaremos el objeto de la aplicacion actual que esta en ejecucion
            App objApp = Application.Current as App;//La palabra "as"(solo se puede usar con tipos de datos por referencia es como un cating una conversion como si tubiera un try, si puede lo hace, si no, no
            if (objApp != null)//Si esta lleno o mi objeto que estoy creando apunta a App
            {
                tbxOrigen.Text = objApp.Compartir;// Lo que esta en la porpiedad compartir lo guardamos en  la propiedad de textbox
            }
        }
    }
}
