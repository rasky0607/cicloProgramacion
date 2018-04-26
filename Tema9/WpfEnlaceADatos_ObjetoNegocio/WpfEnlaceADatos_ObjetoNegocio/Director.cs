using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-------------------------------------------------------
using System.Collections.ObjectModel;


namespace Sebas.WpfEnlaceADatos_ObjetoNegocio
{
    public class Director:Notificador
    {
        // Esta colección contiene un conjunto de films 
       
        public string Nombre { get; set; }
        public string Nacionalidad { get; set; }
        // Propiedad que gestiona la colección con los nombres los films
        
       
        // NOTA: La colección Filmes no puede ser una autopropiedad porque al ejecutar
        //       la aplicación se lanza una Excepcción, en modo de diseño va bien.
        
    }
}
