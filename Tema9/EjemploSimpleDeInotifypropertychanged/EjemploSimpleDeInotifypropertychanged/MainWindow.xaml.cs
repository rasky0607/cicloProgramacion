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

namespace EjemploSimpleDeInotifypropertychanged
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Class1 clase1 = new Class1();
        static int n = 0;
        public MainWindow()
        {
            InitializeComponent();
            dg1.DataContext = clase1;//Importante añadir el objeto creado al contexto de datos , para que el evento no apunte a null, si no a dicho objeto
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            n++;
            clase1.Mensaje = "Este mensaje ha sido modificado " + n + " numero de veces";
        }
    }
}
