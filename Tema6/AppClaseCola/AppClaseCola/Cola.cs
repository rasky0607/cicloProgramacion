using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClaseCola.pbl
{
    public class NoHayDatosException : Exception { }
    /// <Uso>
    /// Gestiona un conjunto de string de tipo cola usando un array FIFO
    /// </uso>
    class Cola
    {
        const int LONGITUD = 3;      
        int _entrada = 0;
        int _salida = 0;
        string[] _cola = new string[LONGITUD];

        /// <Encolar un dato en el array>
        /// Encola o añade en la primera posicion del array disponible osea por la posicion "entrada"
        /// </Encolar un dato en el array>
        /// <param name="nombre">El dato a añadir</param>
        /// <returns> la posicion donde se ñadio el dato o -1 si no se añadio</returns>
        public int Encolar(string nombre)
        {
            int nDatos = _entrada - _salida;//Nuestros datos validos (o los que manejamos)"No tienen pro que ser todos los que hay en el Array"
            if (nDatos == _cola.Length)// si el Array esta lleno, devuelve que no pudo añadir el dato
                return -1;
            _cola[_entrada++ % _cola.Length] = nombre;//Primero se añade  e dato y luego se aumenta entada, por eso luego devolvemos entrada -1 por que al terminar la operacion de abra aumentado en 1 y sera en la siguiente posicion de entrada
             //El modulo, es para que en la ultima posicion,  no se salga del array y vuelva a la primera posicion.
            return _entrada-1; 
        }
        /// <Limpiar cola>
        /// Limpia de elementos nuestra cola
        /// </Limpiar cola>
        public void Limpiar()
        {
            _entrada = _salida;
        }

        /// <Desencola un dato de la cola>
        /// Saca el ultimo dato introducido
        /// </Desencola un dato de la cola>
        /// <returns>Devuelve un string con el dato</returns>
        public string Desencolar()
        {
            if (_entrada == _salida)//cuando la cola esta vacia
             throw new  NoHayDatosException();
            
            else//Si si hay datos
                return _cola[_salida++ % _cola.Length];
            /*
             * Otra forma de hacer el "ELSE"
                 _salida++;
                 return cola[_salida-1];
             */
        }
       /* public string MirarDatoASalir()
        { 
            
        }*/

        /// <Obtener numero de datos>
        /// Obtener numero de datos validos para nosotros en nuestro array
        /// que no tienen por que ser todos
        /// </Obtener numero de datos>
        /// <returns>devuelve un entero con la candiadad de datos</returns>
        public int GetNdatos()
        {
            return _entrada - _salida;
        }
        /// <Capacidad maximade nuestra cola>
        /// Indica la capacidad maxima de elemntos que puede contener nuestra cola 
        /// </Capacidad maximade nuestra cola>
        /// <returns>devuelve un entero con la cantidad maxima</returns>
        public int GetCapacidad()
        {
            return _cola.Length;
        }
    }
}
