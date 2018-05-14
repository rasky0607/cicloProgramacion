using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Media.Imaging;

namespace Adri.DataContext_Nyanchan
{
    class Persona : INotifyPropertyChanged
    {
        string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set 
            { 
                _nombre = value;
                OnPropertyChanged("Nombre");
            }
        }

        string _apellido;

        public string Apellido
        {
            get { return _apellido; }
            set 
            { 
                _apellido = value;
                OnPropertyChanged("Apellido");
            }
        }

        DateTime _fechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set 
            { 
                _fechaNacimiento = value;
                OnPropertyChanged("FechaNacimiento");
            }
        }

        double _estatura;

        public double Estatura
        {
            get { return _estatura; }
            set 
            { 
                _estatura = value;
                OnPropertyChanged("Estatura");
            }
        }

        BitmapImage _foto;

        public BitmapImage Foto
        {
            get { return _foto; }
            set 
            { 
                _foto = value;
                OnPropertyChanged("Foto");
            }
        }

        public Persona()
        {
            this._nombre = "Unknown";
            this._apellido = "Unknown";
            this._fechaNacimiento = DateTime.Parse("1/1/1");
            this._estatura = 0;
            this.Foto = null;
        }

        public Persona(string nombre, string apellido, DateTime fechaNac, double estatura, BitmapImage foto)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._fechaNacimiento = fechaNac;
            this._estatura = estatura;
            this._foto = foto;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propiedad)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propiedad));
            }
        }
    }
}
