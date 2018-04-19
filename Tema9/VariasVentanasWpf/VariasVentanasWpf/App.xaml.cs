using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace VariasVentanasWpf
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        //Propiedad
        public string Compartir
        {
            get;
            set;
        }

        private void Application_Activated(object sender, EventArgs e)
        {
            Compartir = "hola Caracola";//imagenemos ahora que lo guardemos ahora en la porpiedad compartir, sera lo que hay en el textbox de otra ventan como Window2.text
        }
    }
}
