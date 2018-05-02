using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//añadido
using System.ComponentModel;//para añadir el Interfaz INotifyPropertyChanged


namespace pbl.EnlaceADatosConDeContexoDeDatos
{
    class Persona:INotifyPropertyChanged
    {
        #region Campos

        private int id;
        private string _nombre;      
        private string _apellidos;
        private DateTime _fechaNacimiento;     
        private double _estatura;
     
        #endregion
      
        #region Constructores

        public Persona()
        {
            _nombre = "IES";
            _apellidos = "Portada Alta";
            _fechaNacimiento = DateTime.Parse("01/01/2000");
            _estatura = 0.0;
        }

        public Persona(string nombre, string apellidos, DateTime fn, double estatura)
        {
            _nombre = nombre;
            _apellidos = apellidos;
            _fechaNacimiento = fn;
            _estatura = estatura;
        }

        #endregion

        #region Propiedades

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value;
            OnPropertyChanged("Nombre");
            }
        }

        public string Apellidos
        {
            get { return _apellidos; }
            set { _apellidos = value;
            OnPropertyChanged("Apellidos");
            }
        }

        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value;
            //Añadido para el ejemplo sobre el INotifyPropertyChanged, para propagar el cambio en el interfaz grafico si ha habido un cambio
            OnPropertyChanged("FechaNacimiento");
            }
        }

        public double Estatura
        {
            get { return _estatura; }
            set { _estatura = value;
            OnPropertyChanged("Estatura");
            }
        }

        #endregion


        //Notificador o forma de usar el evento que implementa interfaz INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        //Metodo usado por el evento para Propagar la propiedad indicada
        private void OnPropertyChanged(string nombrePropiedad)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(nombrePropiedad));
            }
        }
    }
}
