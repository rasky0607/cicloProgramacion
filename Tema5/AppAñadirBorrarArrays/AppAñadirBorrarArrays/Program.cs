﻿/*
 Autor: Pablo Lopez
 Ejemplo consola: de añadir datos en un array y de borrar datos de un array
 Fecha:23/11/2017
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAñadirBorrarArrays.pbl
{
    class Program
    {
        //Datos compartidos para todos los miembros de la clase.
        static int[] array = null;
        static int nDatos = 0; //Numero de datos añadidos en el array

        static void Main(string[] args)
        {
            const int LONGITUD = 100;
            array = new int[LONGITUD];

            AnadirDato(9);
            AnadirDato(8);
            MostraArray(array);
            BorraDatosArray(array);
            MostraArray(array);

            Console.ReadLine();
        }

        #region Metodos

        /// <Borrar los datos del array>
        ///  Borra los datos dela rray que introducimos anteriormente
        /// </Borrar los datos del array>
        /// <param name="array">nombre del array</param>
        static void BorraDatosArray(int[] array)
        {
            nDatos = 0;
        }

        /// <Añadir un dato al array>
        ///  Añade un dato al final del array si hay espacio
        /// </Añadir un dato al array>
        /// <param name="dato">valor  int del dato a introducir</param>
        /// <returns> true si pudo añadir el dato, false si el array esta lleno</returns>
        static bool AnadirDato(/*int[] ,*/ int dato/*,int nDatos*/) //nDatos no podemos aumentarlo "nDatos++" por que es realmente una copia del original, por loq ue deberiamos pasarlo por referencia, o poner nDatos publico  para compartirlo con el metodo, ya que nDatos gestiona un unico array concreto.
        {
            if (nDatos == array.Length) //Si esta lleno ..(por que ndatos es igual a array.length ) por que el ultimo dato añadido lo lleno..
                return false;
            array[nDatos++] = dato;//si no esta lleno, aumenta la posicion del array , para introducir el dato en la siguiente libre.
            return true;
        }

        #region Metodos copiados del primer ejemplo de los Arrays

        /// <Busqueda secuencial de un dato en el array>
        /// Busca el dato de forma secuencial en el array dado.
        /// </Busqueda secuencial de un dato en el array>
        /// <param name="array">nombre del array en el que deseamos buscar</param>
        /// <param name="buscado"> valor int que deseamos buscar ene l array</param>
        /// <returns>posicion en la que esta en el array</returns>
        static int BusquedaSecuencial(int[] array, int buscado)
        {
            int tamano = array.Length;
            int contador = 0;
            if (tamano == 0)//Si no hay ná en el array..
                return -1;
            while (contador < tamano && buscado != array[contador])
                contador++;

            if (contador >= tamano)
                return -1;//-1 no lo ha encontrado el valor
            else
                return contador;//Posicion en la que se encuentra el dato como la varaible "i" de un for ..


        }

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
        static void MostraArray(int[] a)//Modificado en este ejemplo.
        {
            for (int i = 0; i < nDatos; i++)//Modificado , ya que ahora no llega hasta "Lenght" ahora  llega hasta "nDatos"
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
