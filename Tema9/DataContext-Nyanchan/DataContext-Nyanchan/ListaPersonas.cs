using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;
using System.IO;


namespace Adri.DataContext_Nyanchan
{
    class ListaPersonas : ObservableCollection<Persona>
    {
        Random rnd = new Random();
        List<BitmapImage> fotos = new List<BitmapImage>();

        public ListaPersonas()
            : base()
        {
            ListaDeImagenes();
            Add(new Persona("Adrian","Muñoz",CrearFechaNacimiento(),CrearEstatura(),CrearFoto()));
            Add(new Persona("Pablo", "Escobar", CrearFechaNacimiento(), CrearEstatura(), CrearFoto()));
            Add(new Persona("Manuel", "Escobache", CrearFechaNacimiento(), CrearEstatura(), CrearFoto()));
            Add(new Persona("Pepito", "Grillo", CrearFechaNacimiento(), CrearEstatura(), CrearFoto()));
        }

        private BitmapImage CrearFoto()
        {
            return fotos[rnd.Next(fotos.Count)];
        }

        private void ListaDeImagenes()
        {
            foreach (string item in Directory.EnumerateFiles(@"./../../Fotos/").ToList())
            {
                fotos.Add(new BitmapImage(new Uri(item, UriKind.Relative)));
            }
        }

        private DateTime CrearFechaNacimiento()
        {
            DateTime fecha = new DateTime();
            fecha = DateTime.Now - TimeSpan.FromDays(rnd.Next(1,365*20));
            return fecha;
        }

        private double CrearEstatura()
        {
            double estatura;
            estatura = rnd.Next(150, 211);
            estatura /= 100;
            return estatura;
        }
    }
}
