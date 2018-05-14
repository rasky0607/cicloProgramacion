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


namespace pbl.EnlaceADatosConDeContexoDeDatos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //creo una lista de personas
        ListaPersonas _listaDePersonas = new ListaPersonas();
        Persona personaTmp = null;//Persona donde cargaremos losdatos extraidos de la lista
        int posActual = 0; //para saberpo la posicion de la lista por la que voy
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAnterior_Click(object sender, RoutedEventArgs e)
        {
            personaTmp = _listaDePersonas[posActual++%_listaDePersonas.Count];//1º guarda la persona actual en "personaTmp" y luego avanza a la siguiente sin salirse de  la lista

            if(posActual ==0)
                btnAnterior.IsEnabled = false;

            if(posActual == _listaDePersonas.Count-1)
            {
                btnAnterior.IsEnabled = true;
                posActual--;
                personaTmp = _listaDePersonas[posActual];
            }
            else
            {
                if (posActual>0)
                {
                    btnAnterior.IsEnabled = true;
                    posActual--;
                    personaTmp = _listaDePersonas[posActual];
                }
              

            }

            stpDatos.DataContext = personaTmp;//Añadir al contexto de datos la persona leida.
           
        }

        private void btnSiguiente_Click(object sender, RoutedEventArgs e)
        {
            if (posActual == _listaDePersonas.Count-1)
                btnSiguiente.IsEnabled = false;

            if (posActual == 0)
            {
                btnSiguiente.IsEnabled = true;              
                personaTmp = _listaDePersonas[posActual];
                posActual++;
            }
            else
            {
                if (posActual < _listaDePersonas.Count-1)
                {
                    btnSiguiente.IsEnabled = true;                  
                    personaTmp = _listaDePersonas[posActual];
                    posActual++;
                }
                else
                {
                    btnSiguiente.IsEnabled = false;
                }
                
            }
          
            stpDatos.DataContext = personaTmp;//Añadir al contexto de datos la persona leida.
        }
    }
}
