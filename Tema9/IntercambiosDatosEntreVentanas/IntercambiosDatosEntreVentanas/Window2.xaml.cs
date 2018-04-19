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
using System.Windows.Shapes;

namespace IntercambiosDatosEntreVentanas
{
    /// <summary>
    /// Lógica de interacción para Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        //En primer lugar crearemos un delegado
        public delegate void dlgEnviar(string[] datos);
        //En segundo lugar creamos un evento basado ene la nterior delegado.
        public event dlgEnviar OnEnviar;
        public Window2()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, RoutedEventArgs e)
        {
            string[] datos = { tbxdato1.Text, tbxdato2.Text };
            if (OnEnviar != null)//Si alguien se apunto a evento
            {
                OnEnviar(datos);
            }
        }
    }
}
