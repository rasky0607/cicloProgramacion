/*
 Autor: Pablo Lopez
 Ejemplo consola:Un ejemplo de como podemos añadir a un delegado varias direcciones de memoria de varios  metodos
 ( o en resumen agregar varios metodos a un delegado)
 Fecha:18/01/2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDelegadosConVariosMetodos.pbl
{
    class Program
    {
        
        #region Delegados
        //Declaramos el delegado
        public delegate void MiDelegado();
        #endregion

        static void Main(string[] args)
        {
            //Creo una instancia del tipo de delegado MiDelegado
            MiDelegado llamada = M1;

            //Añadimos varios metodos a un delegado
            llamada += M2;
            llamada += M3;
            llamada += M4;

            //lanzamos el delegado
            llamada();
            //Cuando metodos ahi en la lista de mi delegado
            Console.WriteLine("\n Hay {0} metodos en la lista. \n", llamada.GetInvocationList().GetLength(0));


            Console.WriteLine("------------------");
            //Quitar metodos a un delegado
            llamada -= M2;
            //lanzamos  el delegado
            llamada();

            //Cuando metodos ahi en la lista de mi delegado
            Console.WriteLine("\n Hay {0} metodos en la lista. ",llamada.GetInvocationList().GetLength(0));

            Console.ReadLine();
        }
        #region Metodos
        static void M1()
        {
            Console.WriteLine("Soy M1");
        }
        static void M2()
        {
            Console.WriteLine("Soy M2");
        }
        static void M3()
        {
            Console.WriteLine("Soy M3");
        }
        static void M4()
        {
            Console.WriteLine("Soy M4");
        }
        #endregion
    }
}
