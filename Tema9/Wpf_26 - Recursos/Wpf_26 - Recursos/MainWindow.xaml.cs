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

namespace Wpf_26___Recursos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SolidColorBrush[] brocha = new SolidColorBrush[6];
        int posAct = 0;

        public MainWindow()
        {
            InitializeComponent();
            brocha[0] = this.Resources["ColorFondo1"] as SolidColorBrush;
            brocha[1] = this.Resources["ColorFondo2"] as SolidColorBrush;
            brocha[2] = App.Current.Resources["ColorFondo3"] as SolidColorBrush;
            brocha[3] = App.Current.Resources["ColorFondo4"] as SolidColorBrush;
            brocha[4] = App.Current.Resources["ColorFondo5"] as SolidColorBrush;
            brocha[5] = App.Current.Resources["ColorFondo6"] as SolidColorBrush;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // alterna el color de fondo usando los recursos
            botonColor.Background = brocha[posAct % brocha.Length];
            this.Title = brocha[posAct % brocha.Length].Color.ToString();
            posAct++;
        }
    }
}
