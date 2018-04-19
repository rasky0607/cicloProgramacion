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

namespace EventPosicionDelRaton
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

        //Evento que se lanza cada vez que se mueve el raton
        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            this.Title ="(" +e.GetPosition(this).X+", "+e.GetPosition(this).Y+" )";
            this.Title += e.Source.GetType().Name;//Muestra el titulo de donde se encuentra el raton, ya que el que lanza ele vento, es el controlador que esta lanzado este evento del padre(la ventan) se propaga a los hijos

        }

        private void Ellipse_MouseMove(object sender, MouseEventArgs e)
        {
            e.Handled = true; // interrumpe la propagacion del evento cuando llega ala elipse(siempre que el evento NO sea DIRECTO , es posible hacer esto)
        }
    }
}
