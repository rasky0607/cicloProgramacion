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
//Espacio de nombre añadido: para usar la criterios de ordenacion con la clase sortDescription
using System.ComponentModel;


namespace SelectoresTabListComboBox
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

        private void btnOrdenar_Click(object sender, RoutedEventArgs e)
        {
            //Para ordenar  una lista de elementos
            listb.Items.SortDescriptions.Add(new SortDescription("Content",ListSortDirection.Ascending));
                                                            //Este constructor nos pide, el nombre la propiedad por la que se va ordenar, y con que orden lo ordenaremos
        }

        private void cbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Ordena los botones de forma ascendente o descendente, segun selecionamos en el combobox un modo de ordenacion
            listb.Items.SortDescriptions.Clear();
            if (cbx.SelectedIndex == 0)
            {
                listb.Items.SortDescriptions.Add(new SortDescription("Content", ListSortDirection.Ascending));
                lbTipoDeOrdenacion.Content = "Ordenado Ascendente";
            }
            if (cbx.SelectedIndex == 1)
            {
                listb.Items.SortDescriptions.Add(new SortDescription("Content", ListSortDirection.Descending));
                lbTipoDeOrdenacion.Content = "Ordenado Descendente";
            }
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.Title = tbc.SelectedIndex.ToString();                            
           
        }
    }
}
