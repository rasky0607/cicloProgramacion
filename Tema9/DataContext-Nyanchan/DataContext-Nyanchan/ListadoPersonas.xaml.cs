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
//añadido
using Adri.DataContext_Nyanchan;

namespace DataContext_Nyanchan
{
    /// <summary>
    /// Lógica de interacción para ListadoPersonas.xaml
    /// </summary>
    public partial class ListadoPersonas : Window
    {
       
        public ListadoPersonas()
        {
            InitializeComponent();
           
            ListaPersonas lp = new ListaPersonas();
            lbxlistaPersonas.DataContext = lp;
        }

    }
}
