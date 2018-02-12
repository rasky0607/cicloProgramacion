using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AppOrdenaObjICompare
{
   public class Persona
    {
        #region Campos

        private int _codigo;
        private string _nombre;      
        private string _apellidos;

        #endregion
      
        #region Constructores

        public Persona(string apellido, string nombre, int codigo)
        {
            Apellidos = apellido;
            Nombre = nombre;
            Codigo = codigo;
        }

        #endregion

        #region Propiedades

        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellidos
        {
            get { return _apellidos; }
            set { _apellidos = value; }
        }

       


        #endregion

        #region Metodos

        /// <ToStringInfo>
        /// Sobreescribe el metodo ToString() para mostrar los datos con  un determiando formato
        /// </ToStringInfo>
        /// <returns> devuelve el string con dicho formato</returns>
        public override string ToString()//Rescribe el metodo ToString() (PadlLeft() y PadRight() es solo para darle una separacion maxima constante a cada campo que va mostrar 
        {
            return string.Format("\t{0}\t{1}\t{2}",_codigo,_nombre,_apellidos);
        }



        #endregion

     
    }

    //Primera clase para un criterio de Ordenacion
    public class OrdenaNombres : IComparer<Persona>//Implementacion del Interfaz pero con tipo(aun que puede ser sin tipo osea generico.. como objet y andar haciendo casting )
    {

        public int Compare(Persona x, Persona y)
        {
            return string.Compare(x.Nombre, y.Nombre);
        }
    }

    public class OrdenaApellidos : IComparer<Persona>
    {

        public int Compare(Persona x, Persona y)
        {
            return string.Compare(x.Apellidos, y.Apellidos);
        }
    }
}
