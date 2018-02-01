/*
 Autor: Pablo Lopez
 Ejemplo consola:Contaremos los numeros de un array(solo los numeros PAR), 
     basandonos en el criterio de una Expresion Lamda que se le pasara al metodo "count" sobrecargado
 Fecha:31/01/2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appCriterioContarLambda.pbl
{
    class Program
    {
        static void Main(string[] args)
        {

            /*--------------------Ejemplo1-----------------------------*/
            int[] numeros = {1,3,4,77,12,67,90,22,99,21,0};
            /*Expresión Lamda para evaluar si el valor es PAR o no.
            Dicha expresion internamente (coge un valor del count divide entre 2 y devuelve un boolean)*/
            int nPares = numeros.Count<int>(n => n%2 ==0);
            Console.WriteLine("En el array hay {0} números pares.",nPares);

            /*--------------------Ejemplo2-----------------------------*/

            /*Consultaremos en un Array de String con metodo anonimo y con Expresion Lambda si un determinado nombre esta en la lista.*/
            string[] arrayString = { "juan", "paco", "maria", "lurdes", "sara", "zamburrio" };


            /*Llamada al metodo Anonimo Func<string,bool>miExpresion
            "El cual lo llamaremos con  un delegado que estamos creando en la misma llamada del metodo  BusquedaDeUnNombre
             al pasarle los parametros donde recibe la llamda a dicho metodo anonimo"*/

            BusquedaDeUnNombre(arrayString,delegate(string nombre)
            {
                //Que va hacer el MetodoAnonimo
                return nombre == "juan";
            });

            //Lo mismo  pero con una Expresion Lamda
            BusquedaDeUnNombre(arrayString, nombre => nombre == "maria");
    


            Console.ReadLine();
        }
         //***Func<String,bool>miExpresion:Los primeros tipos que recive entre <> son los tipos que maneja en este caso "string" y el ULTIMO es el tipo que devuelve en este caso "Boolean"
        public static void BusquedaDeUnNombre(string[] arrayString, Func<string,bool>miExpresion)
        {
            Console.WriteLine("Uso de Lambda con método anónimo");
            foreach (string tmp in arrayString)
            {
                if (miExpresion(tmp))
                    Console.WriteLine("Encontrado: {0}", tmp);
            }
        
        }
    }
}
