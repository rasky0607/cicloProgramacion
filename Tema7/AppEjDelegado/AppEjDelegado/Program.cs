/*
 Autor: Pablo Lopez
 Ejemplo consola: Delegados, eventos 
 
 --Descripcion de lo que se va hacer:
 * Crearemos un delegado conun determinado nombre
 * Crearemos un objeto de ese delegado
 * Crearemos un metodo con un nombre
 * Enlazaremos el  delegado a dicho metodo para que  dicho delegado pueda llamar a este metodo.
 
 Fecha:18/01/2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEjDelegado.pbl
{
    class Program
    {
        #region Delegados
        //Declaracion de delegado 1-> ambito, 2 -> delegate 3-> Lo que devuelve 4-> nombre de delegado 5->(firma del metodo que al que va a puntar)
        public delegate void MiDelegado(string msj);


        #endregion
        static void Main(string[] args)
        {
            //LLamada normal sin u sar el delegado 
            MetodoQueUsaElDelegado1(" Hola Caracola, soy el método");

            //Creo una instancia del tipo de delegado MiDelegado
            MiDelegado llamada = MetodoQueUsaElDelegado1;

            //Llamada al delegado
            llamada(" Hola pishhha, soy el delegado");

            Console.ReadLine();
        }

        #region Metodos

        //Metodo que engancharemos al delegado
        static void MetodoQueUsaElDelegado1(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        #endregion
    }
}
