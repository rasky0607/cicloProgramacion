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

namespace BotnonesWpf
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            imgFoto.Opacity = slImagen.Value;
        }

        private void chkColor_Checked(object sender, RoutedEventArgs e)
        {
            rec.Fill = new SolidColorBrush(Colors.Red);
        }

        private void chkColor_Unchecked(object sender, RoutedEventArgs e)
        {
            rec.Fill = new SolidColorBrush(Colors.White);
        }

        //Evento compartido pro los 3 botones de radio
        private void ClickColorRadioButton(object sender, RoutedEventArgs e)
        {
            //OriginalSource pregunta donde se ha iniciado el evento
            if (e.OriginalSource == rbtBlanco)
                rec.Fill = new SolidColorBrush(Colors.White);
            if (e.OriginalSource == rbtAzul)
                rec.Fill = new SolidColorBrush(Colors.Blue);
            if (e.OriginalSource == rbtRojo)
                rec.Fill = new SolidColorBrush(Colors.Red);
        }

        private void EntraEnElBoton(object sender, MouseEventArgs e)
        {           
            tbxInfo.Visibility = Visibility.Visible;
        }

        private void SalidaEnBoton(object sender, MouseEventArgs e)
        {
            tbxInfo.Visibility = Visibility.Hidden;
        }

        //Cambia el color de fondo de negroa  blanco
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            grPrincipal.Background = new SolidColorBrush(Color.FromRgb((byte)sildercolores.Value,(byte)sildercolores.Value,(byte)sildercolores.Value));
        }

        private void slImagen_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            imgFoto.Opacity = slImagen.Value / 100;
            tbcImagen.Text = slImagen.Value.ToString("00.00");
        }

        
    }
}
