/*
 Autor: Pablo Lopez
 Ejemplo consola: Busqueda Binarias o Bigotomica en arrays "ORDENADOS", 
                basandose en si el dato de la posicion central del array es mayor o menos que el dato buscado,
                para buscar en una direccion u otra.
 Fecha:23/11/2017
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBusqBinariaArray.pbl
{
    class Program
    {
        static void Main(string[] args)
        {           
            int[] vector = { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; //Inicializacion de un aray de manera manual.    
            int buscar = 6;
            int pos = BusquedaBinaria(vector, buscar);
             BusquedaBinaria(vector, 4);

             if (pos != -1)
                 Console.WriteLine(" El valor {0} encontrado en la posicion [{1}]", buscar, pos);
             else
                 Console.WriteLine(" El valor {0} no encontrado en el array.", buscar);

            Console.ReadLine();


        }

        #region Metodos

        /// <Busqueda Binaria>
        /// Busca de forma binaria dato en un array ORDENADO
        /// </Busqueda Binaria>
        /// <param name="array">Nombre del array en elq ue buscamos</param>
        /// <param name="buscado">Valor int del dato buscado</param>
        /// <returns>Posicion en la que se encuentra el dato</returns>
        static int BusquedaBinaria(int[] array, int buscado)
        {
            int i = 0;//Posicion inicial del array
            int j;
            int medio;
            int tamano = array.Length;
            j = tamano - 1;//Extremo final del array
            medio = (i + j) / 2;// Posicion central del array 

            while (array[medio] != buscado && i <= j)
            {
                medio = (i + j) / 2;// Posicion central del array  conforme avanza la busuqeda.. de manera que va encontrando el centro de los pequeños array en los que va dividiendo el otriginal
                if (buscado > array[medio])
                    i = medio + 1;
                else
                    j = medio - 1;
            }

            if (array[medio] == buscado)
                return medio;//si esta
            else
                return -1;//No esta

        }

        #region Metodos copiados del primer ejemplo de los Arrays

        /// <Inicializa el array a cero>
        /// Rellena un array con ceros en todas sus posiciones.
        /// </Inicializa el array a cero>
        /// <param name="a">Nombre del array</param>
        static void InicializaArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                a[i] = 0;

        }

        /// <Sobrecarga de Inicializar Array>
        /// Rellena el array cone l valor indicado...
        /// </Sobrecarga de Inicializar Array>
        /// <param name="a">Nombre del array</param>
        /// <param name="valor">valor con el que queremos rellenar el array</param>
        static void InicializaArray(int[] a, int valor)
        {
            for (int i = 0; i < a.Length; i++)
                a[i] = valor;

        }

        /// <Muestra el array>
        ///     Recorre el array con bucle For
        /// </Muestra el array>
        /// <param name="a">Nombre del array</param>
        static void MostraArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.WriteLine("Pos[{0}] valor -> {1}", i, a[i]);

            Console.WriteLine("\n No hay mas datos a mostrar....");
            Console.ReadLine();

        }

        /// <Muestra el array con Foreach>
        ///     Recorre el array con bucle foreach
        /// </Muestra el array con Foreach>
        /// <param name="a">Nombre del array</param>
        static void MostraArrayConForeach(int[] a)
        {
            foreach (int numero in a)
                Console.Write("{0,3},", numero);

            Console.WriteLine("\n No hay mas datos a mostrar....");
            Console.ReadLine();

        }



        /// <Sobrecarga de Inicializar Array>
        /// Rellena el array con el valor indicado... o aleatorio segun si aleatorio vale verdad, si no no.
        /// </Sobrecarga de Inicializar Array>
        /// <param name="a">Nombre del array</param>
        /// <param name="valor">valor con el que queremos rellenar el array</param>
        /// <param name="aleatorio">si es true, lo rellena con valroes aleatorios</param>
        static void InicializaArray(int[] a, int valor, int limite, bool aleatorio)
        {

            //Inicializa el array 'a' aleatoriamente hasta limite -1
            if (aleatorio)
            {
                Random rnd = new Random();
                for (int i = 0; i < a.Length; i++)
                    a[i] = rnd.Next(limite);
            }
            else//Si es aleatorio es falso, inicializa el array al valor indicado.
                for (int i = 0; i < a.Length; i++)
                    a[i] = valor;


        }



        /// <Muestra el Array al reves>
        ///  Recorre el Array desde la ultima posicion "Length -1" hasta la primera "0"
        /// </Muestra el Array al reves>
        /// <param name="a">Nombre del array</param>
        static void MostraArrayAlreves(int[] a)
        {
            for (int i = a.Length - 1; i >= 0; i--)
                Console.WriteLine("Pos[{0}] valor -> {1}", i, a[i]);



            Console.WriteLine("\n No hay mas datos a mostrar....");
            Console.ReadLine();


        }



        /// <Recorre Circularmente un array>
        ///     Da varias vueltas recorriendo un array de forma que no se salga de rango al llegar a la ultima posicion
        /// </Recorre Circularmente un array>
        /// <param name="a"> Nombre array</param>
        static void MuestraArrayCiclicamente(int[] a)//Usando la teoria del resto ( util en el juego de la vida) "i++%array.lenght
        {
            for (int i = 0; i < a.Length * 3; i++)//En este caso da 3 vueltas.
                Console.WriteLine("Pos[{0}] valor -> {1}", i, a[i % a.Length]);

            Console.ReadLine();
        }

        #endregion

        #endregion
    }
}
