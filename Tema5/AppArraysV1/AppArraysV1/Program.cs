/*
 Autor: Pablo Lopez
 Ejemplo consola:Inicializacion de Arrays, como recorrerlos,llenarlos y mostrarlos.
 Fecha:20/11/2017
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppArraysV1.pbl
{
    class Program
    {
        static void Main(string[] args)
        {
            const int LONGITUD = 10;
            int[] vector2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; //Inicializacion de un aray de manera manual.
            int[] vector1 = new int[LONGITUD];

            #region Ejemplos 1

            InicializaArray(vector1);
            MostraArray(vector1);

            InicializaArray(vector1, 5);
            MostraArray(vector1);

            InicializaArray(vector1, 0, 30, true);//la valiable  "valor" de este metodo esta a 0 por que realmente vamos generar valores aleatorios y nose usara.
            MostraArray(vector1);

            #endregion

            MostraArrayAlreves(vector1);//Mostramos el Array al reves
            MuestraArrayCilicamente(vector1);


            
        }
        #region Ejemplos1

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

        #endregion

        #region Ejemplo2

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
            for (int i = a.Length -1; i >= 0; i--)
             Console.WriteLine("Pos[{0}] valor -> {1}",i,a[i]);
                
            

            Console.WriteLine("\n No hay mas datos a mostrar....");
            Console.ReadLine();
           

        }

        #endregion

        /// <Recorre Circularmente un array>
        ///     Da varias vueltas recorriendo un array de forma que no se salga de rango al llegar a la ultima posicion
        /// </Recorre Circularmente un array>
        /// <param name="a"> Nombre array</param>
        static void MuestraArrayCilicamente(int[] a)//Usando la teoria del resto ( util en el juego de la vida) "i++%array.lenght
        {
            for (int i = 0; i < a.Length*3; i++)//En este caso da 3 vueltas.
                Console.WriteLine("Pos[{0}] valor -> {1}", i, a[i % a.Length]);

            Console.ReadLine();
        }


    }
}
