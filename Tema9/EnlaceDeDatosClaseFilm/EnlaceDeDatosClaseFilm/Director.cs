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

       
       

        //(Autopropiedad)
        public string Nombre { get; set; }
        public string Nacionalidad { get; set; }
        //Campo
        ObservableCollection<Films> _filmes = new ObservableCollection<Films>();
        //Necesitan declararse de forma expecifica el get y el Set, si no al ejecutar Referencia a NULL
        public ObservableCollection<Films> Filmes
        {
            get { return _filmes; }
            set { _filmes = value; }
        }
    }
}