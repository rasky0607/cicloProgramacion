using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------------------------------------------------------------------------------------------
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Sebas.WpfEnlaceADatos_ObjetoNegocio
{
    public enum Genero
    {
        Mafia, Drama, Catastrofismo, Aventuras,
        Comedia, Oeste, CienciaFiccion
    };


    public class Film : Notificador
    {
        #region Campos privados
        string titulo;
        Genero genero;
        bool? oscar;
        double calificacion;
        Director _director;
        ObservableCollection<string> _actores = new ObservableCollection<string>();

        #endregion

        #region Constructores
        public Film()
        {
        }

        public Film(string titulo, Genero genero, bool? oscar, double calificación)
        {
            this.Titulo = titulo;
            this.Genero = genero;
            this.Oscar = oscar;
            this.Calificacion = calificacion;
        }
        #endregion

        #region Propiedades
        public string Titulo
        {
            get { return titulo; }
            set
            {
                // Si se cambia el valor assignalo y comunicalo pasando el nombre 
                //de la propiedad cambiada
                if (titulo != value)
                {
                    titulo = value;
                    OnPropertyChanged("Titulo");
                }
            }
        }

        public Genero Genero
        {
            get { return genero; }
            set
            {
                // Si se cambia el valor assignalo y comunicalo pasando el nombre de la propiedad cambiada
                if (genero != value)
                {
                    genero = value;
                    OnPropertyChanged("Genero");
                }
            }
        }

        public bool? Oscar
        {
            get { return oscar; }
            set
            {
                // Si se cambia el valor assignalo y comunicalo pasando el nombre de la propiedad cambiada
                if (oscar != value)
                {
                    oscar = value;
                    OnPropertyChanged("Oscar");
                }
            }
        }

        public double Calificacion
        {
            get { return calificacion; }
            set
            {
                // Si se cambia el valor assignalo y comunicalo pasando el nombre de la propiedad cambiada
                if (calificacion != value)
                {
                    calificacion = value;
                    OnPropertyChanged("Calificacion");
                }
            }
        }

        public Director DirectorFilm
        {
            get { return _director; }
            set { _director = value; }
        }

        public ObservableCollection<string> Actores
        {
            get { return _actores; }
            set { _actores = value; }
        }

        #endregion
    }

}
