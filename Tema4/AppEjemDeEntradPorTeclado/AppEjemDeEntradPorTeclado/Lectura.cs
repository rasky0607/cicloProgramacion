/*
 Autor: Pa Lopez
 Ejemplo consola: Tipos de lectura  por teclado con distintos metodos.
 Fecha:30/10/2017
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEjemDeEntradPorTeclado.pbl
{
    /*Que devuelve ConsoleKeyInfo:
     * key -> donde se guarda la tecla pulsada
     * consolekey -> donde se guarda la lista de nombres de las diferentes teclas
     * keychar -> donde se guarda la letra que sea pulsado Ej:A
     * consoleModifiers -> donde estan las teclas muertas (Alt, ctrl,Mayus)
     * Modifiers -> devuelve un booleano que dice si se a pulsado una
     */
    class Lectura
    {
        static void Main(string[] args)
        {
            #region Ejemplo1 ReadLine()
            /*
             
            int teclaN = 0;
            char teclaC = ' ';
            Console.Write("Dime un caracter . ");
            teclaN = Console.Read();
            Console.ReadLine();//Lectura vacia de ReadLine()  usado para limpiar el Bufer de este modo se parara para la siguiente lectura, si no siempre quedaria despeus de leer el caracter introducido aun que salga del bufer estara los caracteres "\n\r" que introduce siempre al  dar a "ENTER"
            teclaC = (char)teclaN;
            Console.WriteLine("El caracter {0} tiene el ASCII {1}", teclaC, teclaN);

            //Lectura con ReadLine()
            Console.Write("Pulsa ENTER para fin...");
            Console.ReadLine();
              
              */
            #endregion

            #region Ejemplo2 Readkey()
            /*
            string nombre = string.Empty;
            string numeros = string.Empty;
            ConsoleKeyInfo pulsacion;
            Console.Write("Leere: ");
            do{
               
                pulsacion = Console.ReadKey(true);//Al colocar true en la sobrecarga del metodo quitamos el eco de pantall, en cuanto se quite mostrara por pantalla loq ue escriba
                if(char.IsLetter(pulsacion.KeyChar))//char.IsLetter(pulsacion.key) de lo que pulsado, solo guardara lo que pertenezca al grupo de las letras
                {
                    nombre += pulsacion.KeyChar;
                }
                if (char.IsDigit(pulsacion.KeyChar))//char.IsLetter(pulsacion.key) de lo que pulsado, solo guardara lo que pertenezca al grupo de las letras
                {
                    numeros += pulsacion.KeyChar;
                }
            }while(pulsacion.Key != ConsoleKey.Enter);
            Console.WriteLine();

            //Console.SetCursorPosition(10, 10);
            Console.WriteLine("Has introducido las letras: {0} y numeros: {1} ",nombre,numeros);
            Console.WriteLine("\nPulsa ENTER para fin...");
            Console.ReadLine();*/
            #endregion


            
            #region Ejemplo3 Telas muertas pulsadas
            string nombre = string.Empty;
            string numeros = string.Empty;
            ConsoleKeyInfo pulsacion;
            Console.Write("Leere: ");
            do
            {

                pulsacion = Console.ReadKey(/*true*/);//Al colocar true en la sobrecarga del metodo quitamos el eco de pantall, en cuanto se quite mostrara por pantalla loq ue escriba
                if (char.IsLetter(pulsacion.KeyChar))//char.IsLetter(pulsacion.key) de lo que pulsado, solo guardara lo que pertenezca al grupo de las letras
                {
                    nombre += pulsacion.KeyChar;
                    Console.Write(pulsacion.KeyChar);
                }
       
               if (pulsacion.Modifiers == (ConsoleModifiers.Control | ConsoleModifiers.Alt))
                   Console.WriteLine("Pulsado Ctrl +Alt");
                
            } while (pulsacion.Key != ConsoleKey.Enter);
            Console.WriteLine();//Para saltar de linea y no sobreescriba lo escrito anteriormente 
                 
            Console.WriteLine("\nPulsa ENTER para fin...");
            Console.ReadLine();
            #endregion


        }
    }
}
