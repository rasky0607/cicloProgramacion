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

namespace ControlSliderWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double valorActualAnchura = 0;
        double valorActualAltura = 0;
        double valorOpacidadActual = 0;
        public MainWindow()
        {
            InitializeComponent();
            sldAltura.Value = imgImagen.Height;
            sldAnchura.Value = imgImagen.Width;
            sldOpacidad.Value = imgImagen.Opacity;
        }

        private void sldAnchura_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (valorActualAnchura > sldAnchura.Value)
                imgImagen.Width = sldAnchura.Value;
            else
                imgImagen.Width = sldAnchura.Value;

        }

        private void sldAltura_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (valorActualAltura > sldAltura.Value)
                imgImagen.Height = sldAltura.Value;
            else
                imgImagen.Height = sldAltura.Value;
        }

        private void sldOpacidad_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (valorOpacidadActual > sldOpacidad.Value)
                imgImagen.Opacity = sldOpacidad.Value;
            else
                imgImagen.Opacity = sldOpacidad.Value;
        }
    }
}
