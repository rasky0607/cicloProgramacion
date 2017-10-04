/*
 #########################################
 #Autor: Pablo Lopez
 #Programacion: Tema1:"Caracteristicas de lenguaje C#."
 #Ejemplo 2: Sumamos dos numeros introducidos por teclado.
 #########################################
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_sumaDeEnteros
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables que vamos a usar, donde guardaremos los numeros queintroduzcamos por teclado
            int X = 0;
            int y = 0;
            //------------------//

            //Definicion o titulo del programa.
            Console.WriteLine("Voy a sumar dos numeros enteros .");
            Console.WriteLine("=============================================================");
            //---------------------------------//
            
            //Desarrollo del programa 
            Console.Write("Dime el primer numero entero: ");//Escribe el testo  intrudcido entre comillas dobles
            X = int.Parse(Console.ReadLine());              //Lee el dato que introduzcamos por teclado, convierte el tipo string a tipo INT y lo guardara en la variable X
            Console.WriteLine();                            //Salto de linea (puramente visutal)
            Console.Write("Dime el segundo numero entero: ");//Escribe el testo  intrudcido entre comillas dobles
            y = int.Parse(Console.ReadLine());              //Lee el dato que introduzcamos por teclado, convierte el tipo string a tipo INT y lo guardara en la variable Y
            Console.WriteLine();                            //Salto de linea (puramente visutal)
            Console.WriteLine("La suma de " + X + " más " + y + " es igual a: " + (X + y)); //Escribe el testo  intrudcido entre comillas dobles y concatena los valores de las variables X  e Y, ademas de realizar la suma de las varaible X + Y que mostrando el resultado de la suma directamente.
            //-------------------------------------------//
            Console.ReadLine();
        }
    }
}
