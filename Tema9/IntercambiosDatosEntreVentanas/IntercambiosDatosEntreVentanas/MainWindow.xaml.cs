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

namespace IntercambiosDatosEntreVentanas
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Crea una instancia del formulario que queremos abrir
            Window2 w2 = new Window2();
            w2.OnEnviar += w2_OnEnviar;
            w2.ShowDialog();//abre la ventana 2
        }

        //metodo que se ejecutara tras producirse el evento OnEnviar
        void w2_OnEnviar(string[] datos)
        {
            tbxdato1.Text = datos[0];
            tbxdato2.Text = datos[1];
        }
    }
}
