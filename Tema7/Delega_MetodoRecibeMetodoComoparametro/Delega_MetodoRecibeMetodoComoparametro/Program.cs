/*
 Autor: Pablo Lopez
 Ejemplo consola: un metodo que recibe otro metodo como parametro a traves de un delegado
 Fecha:1801/2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delega_MetodoRecibeMetodoComoparametro.pbl
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

            //LLamada al metodo que recibe otro metodo como parametro a atraves de su delegado
            metodoConDevolucion("Texto Recibido", llamada);


            Console.ReadLine();
        }

        #region Metodos

        //Metodo que engancharemos al delegado
        static void MetodoQueUsaElDelegado1(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
        //Pasamos un metodo como parametro a a traves de  su delegado
        static void metodoConDevolucion(string texto, MiDelegado delegado)
        {
            Console.WriteLine(texto + " " + delegado);

        }

        #endregion
    }
}
