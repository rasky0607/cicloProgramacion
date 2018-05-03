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
//añadido
using EnlaceDeDatosClaseFilm;

namespace pbl.EnlaceDeDatosClaseFilm
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

        private void btnCambiar_Click(object sender, RoutedEventArgs e)
        {                   //Resources accede a la clave o la key "x:Key" del objeto en el XAML
            Films film = Resources["filmInfiltrados"] as Films;//Creamos un objeto que en lugar de ser uno nuevo apunta a el objeto "filmInfiltrados" que hemos creado en el XAML
            if (film == null)//Por si no puede enlazarse a este objeto"film"
                return;
            //Solo se cambiara las propiedades las que tengan programado el evento NotifyPropertyChanged
            //Cambiara en la clase y el interfaz por estos valores.
            film.Titulo = "Te lo borre";
            film.Genero = Genero.Catastrofismo;
            film.Calificacion = 3.3;
        }

        private void btnColecciones_Click(object sender, RoutedEventArgs e)
        {
            Win_Colecciones ventanaColeciones = new Win_Colecciones();
            ventanaColeciones.Show();
        }
    }
}
