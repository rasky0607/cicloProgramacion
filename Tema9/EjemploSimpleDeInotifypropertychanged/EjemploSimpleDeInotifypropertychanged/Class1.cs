using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Añadido
using System.ComponentModel;//Espacio de nombre para implementar INotifyPropertyChanged

namespace EjemploSimpleDeInotifypropertychanged
{
    class Class1:INotifyPropertyChanged
    {
        string _mensaje;

        public string Mensaje
        {
            get { return _mensaje; }
            set { _mensaje = value;
            Notificador("Mensaje");//Notifica el cambio de la propiedad
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        //Metodo que ejecuta el evento PropertyChanged
        private void Notificador(string nombrePropiedada)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(nombrePropiedada));//this el objeto que le llega , evento que recibe el nombre de la propiedad
        }   
    }
}
