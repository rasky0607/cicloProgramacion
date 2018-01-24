/*
 Autor: Pablo Lopez
 Ejemplo consola: Ejemplo de  sintaxys de expresion Lambda
 Fecha:24/01/2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExpresionesLamda.pbl
{
    class Program
    {
        delegate int MiDelegado(int i);


        /*
         Ejemplo de varias  forma  de sintaxys de una expresion lambda
         *  
         *  Esta expresion Lambda devuelve un Boolean
         *   (x,y) => x==y;
         *   
         *  Esta expresion Lambda le especificamos que tipo de valor recibe
         *  (int x, string s) => s.Length > x   (esta devolvera verdad cuando el valor de al cadena sea mayor que x)
         *  
         *  Expresion Lambda que no recibe ningun parametro
         * () => algunMetodo();
         * 
         * Esta expresion Lambda recibe un parametro que se llama 'n' y que recibe la instruciones que estan ente las '{  }'
         *  Midelegado  eldelegado = n => {      }
         *  
         *                           
         *
         */
        static void Main(string[] args)
        {
            int j;   
                                //Expresion Lamda ( la  primera x es el parametro que recibe nuestra firma del delegado , despues del operado => la expresion o las sentencia que se realizarian en una funcion normal
            MiDelegado eldelegado = x => x * x;

            //LLamada al delegado
            j = eldelegado(10);
            Console.Write(j);

            Console.ReadLine();
        }

        //Este metodo hace lo mismo que la expresion Lamda con el delegado
        static int Cuadrado(int i)
        {
            return i * i;
        }
    }
}
