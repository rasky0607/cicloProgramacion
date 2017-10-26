/*
 Ejemplo para pintar un Menu
 Autor: Pablo Lopez
 Fecha: 23-10-2017
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();   
        }

        static void Menu()
        {
            ConsoleColor color = ConsoleColor.DarkBlue;
            Console.BackgroundColor = color;
            Console.ForegroundColor = ConsoleColor.Yellow;
            ConsoleColor colordesactivado = ConsoleColor.Red;

            int izq = 10;
            int arriba = 5;
            int obcion = 0;
            
            do
            {
                Console.Clear();
                Console.SetCursorPosition(izq, arriba);               
                Console.CursorLeft = izq;
                Console.WriteLine("M E N U   P R I N C I P A L");
                Console.CursorLeft = izq;
                Console.WriteLine("===============================");
                Console.CursorLeft = izq;
                Console.WriteLine(" 1. Triangulo.");
                Console.CursorLeft = izq;
                Console.WriteLine(" 2. Cuadrado.");
                Console.CursorLeft = izq;
                Console.ForegroundColor = colordesactivado;
                Console.WriteLine(" 3. Rectangulo.");
                Console.CursorLeft = izq;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" 0. Salir.");
                Console.CursorLeft = izq + 5;
                Console.Write("Opcion?: ");
               
                obcion = int.Parse(Console.ReadLine());
                switch (obcion)
                {
                    case 1:
                        Console.WriteLine("Has pulsado la obcion de Triangulo.");
                        break;
                    case 2:
                        Console.WriteLine("Has pulsado la obcion de Cuadrado.");
                        break;
                    case 3:                                           
                        Console.WriteLine("Has pulsado la obcion de Rectangulo.");
                        break;
                    case 0:
                        Console.WriteLine("Has pulsado la obcion de Salir.");
                        break;

                    default:
                        Console.WriteLine("La opcion no es correcta.");
                        break;
                }
                Console.ReadLine();
            } while (obcion != 0);

  
            
        }
    }
}
