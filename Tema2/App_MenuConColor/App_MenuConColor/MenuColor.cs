/*
 #############################################################
 #Autor: Pablo Lopez
 #Definicion de App: este programa generara un Menu en la posicion (10,5) con distintos colores.
 #Fecha: 06-10-2017
 ############################################################
 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_MenuConColor
{
    class MenuColor
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan; //Cambia el color de las letras que pinta en la consola. 
            Console.SetCursorPosition(10, 5);   //Cambia la posicion del cursor (Primer valor en  relacion a  las lineas  de la pantalla "de arriba abajo" y segundo valor a las columnas (de izquierda a derecha).
            Console.WriteLine(" MENU PRINCIPAL");
            Console.SetCursorPosition(11, 6);//Cambia la posicion del cursor
            Console.WriteLine("--------------");
            Console.ForegroundColor = ConsoleColor.DarkYellow;//Cambia el color de las letras
            Console.SetCursorPosition(11, 7);//Cambia la posicion del cursor
            Console.WriteLine("1. Alta");
            Console.SetCursorPosition(11, 8);//Cambia la posicion del cursor
            Console.WriteLine("2. Baja");
            Console.SetCursorPosition(11, 9);//Cambia la posicion del cursor
            Console.WriteLine("3. Consulta");
            Console.SetCursorPosition(11, 10);//Cambia la posicion del cursor
            Console.WriteLine("4. Modificaciones");
            Console.SetCursorPosition(11, 12);//Cambia la posicion del cursor
            Console.WriteLine("0. Salir");
            Console.ForegroundColor = ConsoleColor.Cyan;//Cambia el color de las letras
            Console.SetCursorPosition(11, 13);//Cambia la posicion del cursor
            Console.Write("\t\t Elige una opción: ");
            Console.ReadLine();
        }
    }
}
