/*
 #########################################
 #Autor: Pablo Lopez
 #Programacion: Tema1:"Caracteristicas de lenguaje C#."
 #Ejemplo 1: Lee por teclado tu nombre y te saluda.
 #########################################
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_claseConsole
{
    class Program
    {
        static void Main(string[] args) //INICIO del programa
        {
            //Variables que usaremos

            string nombre = " ";

            //---------------------------//

            //Desarrollo del programa

            Console.WriteLine("Este programa te saludara por tu nombre.");            //Escribe  por pantalla el texto que encontramos entre comillas.
            Console.WriteLine("===================================================");//Puramente visual, para separar el titulo del programa del resto de informacion a mostrar
            Console.Write("Dime tu nombre ");                                          //Escribe  por pantalla el texto que encontramos entre comillas.
            nombre = Console.ReadLine();                                                //Lectura de mi nombre por teclado y lo guarda en la varaible $nombre
            Console.WriteLine("===================================================");   //Puramente visual, para separar el titulo del programa del resto de informacion a mostrar
            Console.WriteLine("Hola, te llamas " + nombre);                             //Escribe lo que hay entre comillas dobres, y ademas lo que esta guardado en la variable $nombre
            Console.WriteLine(" Pulsa intro para salir...");
            Console.ReadLine();                                                         //Pausa para que no se cierre la pantalla de la consola una vez ejecutemos el programa , hasta que pulsemos intro.

          //FIN

            //--------------------------------------------------------------//
        }
    }
}
