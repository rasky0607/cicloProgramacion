/*
 Ejemplo de introduccion a Funciones o Metodos.
  Autor:Pablo Lopez
  Fecha: 23-10-2017
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppIntroducionFuncion
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = -100;
            int y = 20;
            int abs = 0;

            //Llamada al metodo guardando el valor que devuelve nuestro metodo en una variable.
            abs = Absoluto((int)3.00);//necesitamos convertirlo con un "Casting" primero , para poder guardarla en nuestra varaible entera.

                                                                      //Llammada al metodo y entre parentesis el dato que va recibir  en este caso "x"
            Console.WriteLine("-El valor absoluto de {0} es {1} .", x, Absoluto(x));
            Console.WriteLine("-El valor absoluto de {0} es {1} .", y, Absoluto(y));

            Console.ReadLine();
        }

       

        //Region ->Solo sirve para delimitar zonas y ocultarlas con comodidad,(lo recomiendo).
        #region Mis metodos

        //Metodo o Funcion
        /*
         *Orden de escritura del metodo o funcion*
         -------------------------------------------------
         -static -> referido  a no tener necesidad de crearun objeto de la clase parapoder usarlo(ahora mismo puede obviarlo).. usa siempre static.. hasta que lo diga Sebas.
         -Tipo de valor que devuelve "en este caso (int)"
         -Nombre de la funcion "en este caso (Absoluto)"<-Te lo puedes inventar .. el que tu quieras darle.
         -Los parametros que reciben, sean muchos o ninguno siempre entre parentesis "en este caso recibe un entero int llamado numero(int numero)" el nombre de dicha varaible es el que tu elijas
         "pero esta solo se usara en el metodo".
         */
        static int Absoluto(int numero)//Firma del Metodo o funcion
        {
            if (numero > 0)
                return numero;

            return -numero;//Devuelve el numero positivo
        }

        //Mas metodos..... etc..
        #endregion
    }
}
