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
//-------------------------------------------------------------------
using Sebas.WpfEnlaceADatos_ObjetoNegocio;

namespace WpfEnlaceADatos_ObjetoNegocio
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

        private void btnCambiarTitulo_Click(object sender, RoutedEventArgs e)
        {
            // cambiamos algunas propiedades del objeto film creado como recurso accediendo al mismo
            // Cambia el valor de Titulo de la clase Film accediendo a los recursos
            Film film = Resources["filmInfiltrados"] as Film;
            if (film != null)
            {
                // Esta línea de código es una alternativa a la anterior
                // Film film = (Film)Resources["filmInfiltrados"];
                film.Titulo = "Titanic";
                film.Genero = Genero.Catastrofismo;
                film.Oscar = true;
                film.Calificacion = 4.5;
            }

        }
    }
}
