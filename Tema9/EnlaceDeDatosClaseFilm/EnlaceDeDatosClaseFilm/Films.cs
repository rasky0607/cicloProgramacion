using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Aañadido
using System.ComponentModel;
using System.Collections.ObjectModel;

/*Cosas que necesito para que mi clase nueva creada (Fils), se vea en mi XAML,
 1º tener un costructor vacio.
 2º Hacer referencia a esa clase en el XAML*/

namespace pbl.EnlaceDeDatosClaseFilm
{
    public enum Genero {Mafia, Drama, Catastrofismo, Aventuras, Comedia, Oeste, CienciaFiccion};

    public class Notificador : INotifyPropertyChanged
    {
        /// <summary>
        /// Clase usada para propagar/informar de los cambios de las propiedades
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged; //El evento es PropertyChanged  y el que controlador de este evento sera OnPropertyChanged

        //Controlador de eventos
        protected void OnPropertyChanged(string nombre)
        {
            if (PropertyChanged != null)//si esta apuntado al evento
                PropertyChanged(this, new PropertyChangedEventArgs(nombre));//Creando el Notificador, que requiere un objeto de PropertyChanged y un nuevo PropertyChangedEventArgs
        }

    }

    class Films: Notificador
    {
        /*Campos*/
        #region Campos

        string _titulo;
        Genero _genero;
        bool? _oscar; //Con interrogacion, que es un valor que puede ser Nullo tambien
        double _calificacion;
        ObservableCollection<string> _actores = new ObservableCollection<string>(); //de cada pelicula que tienun unico director.
        Director _director;

        #endregion

        #region Constructores
        /*Constructores*/
        public Films(string titutlo, Genero genero, bool? oscar, double calificacion)
        {
            this._titulo = titutlo;
            _genero = genero;
            _oscar = oscar;
            _calificacion = calificacion;

        }

        //Para crear una Instancia en XML, Necesitamos un Contructor vacio.., por lo que ahora  al crear uno nuevo.. n os cargamos el vacio... po lo que, necesitamos escribir especificamente el vacio de nuevo..
        public Films()
        { }
        #endregion

        #region Propiedades Lectura Escritura

        public string Titulo 
        {
            get { return _titulo; }

            set
            {
                if (_titulo != value)//Si ha cambiado el titulo..(opcional)
                {
                    _titulo = value;// lee el nuevo titulo
                    OnPropertyChanged("Titulo"); //Para que la propiedad se propague a la clase cuando cambie, o se notifique el cambio de la propiedad
                }
            }
        }

        public Genero Genero
        {
            get { return _genero; }
            set 
            {
                _genero = value;
                OnPropertyChanged("Genero");//Este evento que notificara a la clase, se le aplicara a las propiedades que queremos sincronizar y se notifiquen a la clase
            }
        }

        public bool? Oscar
        {
            get 
            {return _oscar; }
            set 
            {
                _oscar = value;
                OnPropertyChanged("Oscar");
            }
        }

        public double Calificacion
        {
            get { return _calificacion; }
            set
            {
                _calificacion = value;
                OnPropertyChanged("Calificacion");
            }
        }

        public ObservableCollection<string> Actores
        {
            get { return _actores; }
            set { _actores = value; }
        }

        public Director Director
        {
            get { return _director; }
            set { _director = value; }
        }

        #endregion
    }
}
