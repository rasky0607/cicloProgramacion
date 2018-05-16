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
using Adri.DataContext_Nyanchan;

namespace DataContext_Nyanchan
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
         ListaPersonas _listaPersona = new ListaPersonas();
         
        Persona tmp = null;
        int posActual = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnPosterior_Click(object sender, RoutedEventArgs e)
        {
            posActual++;
            if (posActual == _listaPersona.Count)
            {
                posActual = 0;
            }
            tmp = _listaPersona[posActual];
            stkDatos.DataContext = tmp;

            //ejemplo2 mostrar la lista de personas en un listbox
            lbxlistaPersonas.DataContext = _listaPersona;
        }

        private void btnAnterior_Click(object sender, RoutedEventArgs e)
        {
            posActual--;
            if (posActual < 0)
            {
                posActual = _listaPersona.Count -1;
            }
            tmp = _listaPersona[posActual];
            stkDatos.DataContext = tmp;
        }

        private void btnMostrarListapersonas_Click(object sender, RoutedEventArgs e)
        {
            ListadoPersonas ltP = new ListadoPersonas();
            ltP.ShowDialog();
        }
    }
}
