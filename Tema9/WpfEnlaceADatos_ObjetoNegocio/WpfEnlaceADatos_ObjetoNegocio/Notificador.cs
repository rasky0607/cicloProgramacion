using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-------------------------------------------------------------------
using System.ComponentModel;


namespace Sebas.WpfEnlaceADatos_ObjetoNegocio
{
    /// <summary>
    /// Clase usada para informar de los cambios del valor de la propiedad en la clase
    /// </summary>
    public class Notificador : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        // Codificamos el método que controla el evento
        protected void OnPropertyChanged(string nombre)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(nombre));
        }
    }

}
