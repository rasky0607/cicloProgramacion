using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//añadido 
using System.Collections;

namespace AppIenumeratorIenumerable
{
    class Lista:IEnumerator,IEnumerable
    {
        int[] numeros = { 1, 3, 5, 99, 110, 4, 7 };
        int posicion = -1; //ya que el iEnumerator y I enumerable , lo va incrementar en 1 y la primera posicion deuna lista o un array es 0

        #region IEnumerator
        public object Current
        {
            //Devuelve el elemento de la posicion actual
            get { return numeros[posicion]; }
        }

        public bool MoveNext()
        {
           /*Desplaza  el indice  que referencia la posicion al siguiente valor para desplazarse  al siguiente elemneto
            devuelve: true si avanzo
                     false si se alcanzo el final
            */

            if (posicion < numeros.Length - 1)
            {
                posicion++;
                return true;
            }
            else
            {
                Reset();
                return false;
            }

        }

        public void Reset()
        {
            //Reinicia el indice al comienzo o el pricipio el cual debe ser -1 ya que luego lo incrementara en 1 y avanzara ala primera posicion la "0"
            posicion = -1;
        }
        #endregion

        #region IEnumerable
        public IEnumerator GetEnumerator()
        {
            //devuelve  tipo IEnumerable a la clase
           return this;
        }
        #endregion
    }
}
