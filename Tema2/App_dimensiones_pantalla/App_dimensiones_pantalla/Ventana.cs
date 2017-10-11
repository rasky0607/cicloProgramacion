using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_dimensiones_pantalla
{
    class Ventana
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============================");
            Console.WriteLine("  P A N T A L L A");
            Console.WriteLine("==============================");
            Console.WriteLine();

            //Devuelve el alto tamaño actual de la consola
            Console.Write("ALto actual: {0}", Console.WindowHeight);
            //Devuelve el ancho tamaño actual de la consola *PD: el \n da un salto de linea, es similar a "Console.WriteLine();"
            Console.Write("\nAncho actual: {0}", Console.WindowWidth);

                             /*EJEMPLO 1*/

            /*Borrar esta linea para descomentar este parrafo:
             
            //Cambiamos las dimensiones de la pantalla
             Console.WindowHeight = 24; //Valor dado a las propiedad de alto de la pantalla
             Console.WindowWidth = 80;   //Valor dado a las propiedad de ancho de la pantalla

            Console.WriteLine("\n\n\t\tDespues del cambio... \n");
            //Devuelve el alto tamaño actual de la consola
            Console.Write("ALto actual: {0}", Console.WindowHeight);
            //Devuelve el ancho tamaño actual de la consola *PD: el \n da un SALTO DE LINEA, es similar a "Console.WriteLine(); \t una TABULACION"
            Console.Write("\nAncho actual: {0}", Console.WindowWidth);

            /*--------------------------------------------------------------*/

                            /*EJEMPLO 2*/
            //*Comentar este parrafo para ver visualmete la accion del EJEMPLO 1

            Console.WriteLine("\n\n\t\tDespues del cambio... \n");

            //Colocar el maximo permitido de la ventana
            Console.WindowWidth = Console.LargestWindowWidth;
            Console.WindowHeight = Console.LargestWindowHeight;
            //Devuelve el alto tamaño actual de la consola
            Console.Write("ALto actual: {0}", Console.WindowHeight);
            //Devuelve el ancho tamaño actual de la consola *PD: el \n da un salto de linea, es similar a "Console.WriteLine();"
            Console.Write("\nAncho actual: {0}", Console.WindowWidth);

            /*--------------------------------------------------------------*/

            Console.ReadLine();
        }
    }
}
