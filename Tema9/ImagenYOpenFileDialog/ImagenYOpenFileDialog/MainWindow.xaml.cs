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
using Microsoft.Win32;

namespace ImagenYOpenFileDialog
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

        //con imagenes NO asociadas al proyecto, si noq ue son cogidas o leidas fuera de este
        private void btnCargarImagen_Click(object sender, RoutedEventArgs e)
        {
            string ruta = string.Empty;
            BitmapImage src = new BitmapImage();
            OpenFileDialog miCruadroDialog = new OpenFileDialog();
            miCruadroDialog.InitialDirectory = @"C:\Users\Usuario\Desktop";//Abre el recuedro de dialogo siempre en el directorio
            Nullable<bool> resultado = miCruadroDialog.ShowDialog();//tipo booleado que acepta nulo"tambien puede aprecer como ( bool? ) "
            if (resultado == true)
            {
                ruta = miCruadroDialog.FileName;
                this.Title = ruta;
                src.BeginInit();//Inicializa el objeto para poder gestionarlo estando este fuera del proyecto
                src.UriSource = new Uri(ruta,UriKind.RelativeOrAbsolute);//Añade la ruta donde esta el objeto(UriKid  para definir lsi la ruta va ser relativa o absoluta, sin o le decimos nada es relativa)
                src.CacheOption = BitmapCacheOption.OnLoad;//LLena el contenedor de imagen(Carga una cantidad de imagenes)
                src.EndInit();//marca el fin del objeto que marcamos para gestionar fuera del proyecto
                imgImagen.Source = src;//tras lo anterior , ya  podemos asignar  el objeto compatible para  la propiedad source de el control imagen.
                imgImagen.Stretch = Stretch.Uniform;//Estable como debe distribuirse la imagen en el contenedor
               
            }

        }

        //Con imagenes asociadas al proyecto.
        private void btcargarImagen2_Click(object sender, RoutedEventArgs e)
        {
          
            /* Otra forma de hacerlo:
             BitmapImage src = new BitmapImage(new Uri("./img/img1.jpg",UriKind.Relative));
             */
            Uri miUri = new Uri("./img/img1.jpg", UriKind.Relative);// Diferencia con CacheOption (Recarga solo la imagen actual)
            BitmapImage src = new BitmapImage(miUri);
            imgImagen2.Source = src;
        }
    }
}
