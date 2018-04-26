using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Añadidos
using System.Collections.ObjectModel;

namespace pbl.EnlaceDeDatosClaseFilm
{
    class Director : Notificador
    {
        //ObservableCollection Es un tipo de lsita especial que ya implementa  INotifyPropertyChanged ya de por si entre otros, para que se sincronice autmaticamente.

        //Campos
        //ObservableCollection<Films> _filmes;

        //(Autopropiedad)
        public string Nombre { get; set; }
        public string Nacionalidad { get; set; }
        /*public ObservableCollection<Films> Filmes//Necesitan declararse de forma expecifica el get y el Set, si no al ejecutar Referencia a NULL
        {
            get { return _filmes; }
            set { _filmes = value; }
        }*/
    }
}
