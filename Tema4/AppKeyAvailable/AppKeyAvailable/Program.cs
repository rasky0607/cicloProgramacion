/*
 Autor: Pa Lopez
 Ejemplo consola:Ejemplo de Key Available pulsando una tecla
 Fecha:30/10/2017
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Añadido 
using System.Threading;

namespace AppKeyAvailable
{
    class Program
    {
        static void Main(string[] args)
        {
            char  caracter = '*';
            ConsoleKeyInfo tecla;
            int left= 0;
            int top = 0;
            Random rnd = new Random();
            int maxAncho =  Console.WindowWidth;
            int maxAlto = Console.WindowHeight;
            int retardo = 100;
            do
            {
                left = rnd.Next(maxAncho);
                top = rnd.Next(maxAlto);
                Console.SetCursorPosition(left,top);
                Console.Write(caracter);
                Thread.Sleep(retardo);
            }while(!Console.KeyAvailable);//si no hay una tecla en el bufer 
            tecla = Console.ReadKey();
            Console.WriteLine(" Has pulsado: {0}", tecla.Key);          

            Console.ReadLine();
        }
    }
}
