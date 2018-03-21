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

namespace WrapPanelYCanvas
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
            //Crear un control rectangulo
            Rectangle _rect = new Rectangle();
            _rect.Width = 50;
            _rect.Height = 50;
            _rect.Fill = new SolidColorBrush(Colors.Blue);          
            //Especifica las posiciones del elemento dentro del canvas
            Canvas.SetLeft(_rect, 20);//(Porpiedad de dependencia
            Canvas.SetTop(_rect, 10);
            //Añadir al canvas un elemento
            cvContenedor.Children.Add(_rect);
        }
        
    }
}
