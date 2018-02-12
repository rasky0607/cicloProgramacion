using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AppOrdenaObjIComparable
{
    class Persona:IComparable<Persona>//Implementacion del Interfaz pero con tipo(aun que puede ser sin tipo osea generico.. como objet y andar haciendo casting )
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

        //Criterios de Ordenacion
        public int CompareTo(Persona otra)
        {
            /*Ej1: Ordena por Codigo:
            if (this._codigo > otra._codigo) return 1;//si el que estamos comparando es mayor que el que le llega al metodo.
            if (this._codigo < otra._codigo) return -1;//si el que estamos comparando es menor que el que le llega al metodo.
            return 0;//Si es 0 son iguales
               */ 

            //Compara por apellidos
            return String.Compare(this._apellidos, otra._apellidos);
        }
    }
}
